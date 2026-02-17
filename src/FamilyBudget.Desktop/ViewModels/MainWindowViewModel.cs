using System.Collections.ObjectModel;
using FamilyBudget.Core;
using FamilyBudget.Desktop.Models;
using FamilyBudget.Desktop.Services;

namespace FamilyBudget.Desktop.ViewModels;

public sealed class MainWindowViewModel : ObservableObject
{
    private readonly BudgetStore _store;
    private string _monthKey;
    private decimal _rollOver;
    private string _status = "Ready";

    public MainWindowViewModel(BudgetStore store)
    {
        _store = store;
        _monthKey = $"{DateTime.Today:yyyy-MM}";
        Sections = new ObservableCollection<BudgetSectionModel>();

        SaveCommand = new RelayCommand(() => _ = SaveAsync());
        LoadCommand = new RelayCommand(() => _ = LoadMonthAsync());

        _ = LoadMonthAsync();
    }

    public ObservableCollection<BudgetSectionModel> Sections { get; }

    public RelayCommand SaveCommand { get; }

    public RelayCommand LoadCommand { get; }

    public string MonthKey
    {
        get => _monthKey;
        set => SetProperty(ref _monthKey, value);
    }

    public decimal RollOver
    {
        get => _rollOver;
        set
        {
            if (SetProperty(ref _rollOver, value))
            {
                NotifyTotals();
            }
        }
    }

    public string Status
    {
        get => _status;
        set => SetProperty(ref _status, value);
    }

    public decimal IncomeTotal => SumByType(BudgetSectionType.Income);
    public decimal ExpenseTotal => SumByType(BudgetSectionType.Expense);
    public decimal SpendingBudgetTotal => SumByType(BudgetSectionType.SpendingBudget);
    public decimal GoalTotal => SumByType(BudgetSectionType.Goal);
    public decimal AdjustmentTotal => SumByType(BudgetSectionType.Adjustment);

    public decimal AvailableFromIncome => RollOver + IncomeTotal;
    public decimal AfterExpenses => AvailableFromIncome - ExpenseTotal;
    public decimal AfterSpendingBudgets => AfterExpenses - SpendingBudgetTotal;
    public decimal LeftForGoals => AfterSpendingBudgets;
    public decimal FinalRemaining => LeftForGoals - GoalTotal + AdjustmentTotal;

    private async Task LoadMonthAsync()
    {
        var budget = await _store.LoadOrCreateAsync(MonthKey);
        BindFromDomain(budget);
        Status = $"Loaded {MonthKey}";
    }

    private async Task SaveAsync()
    {
        var budget = ToDomain();
        await _store.SaveAsync(budget);
        Status = $"Saved {MonthKey}";
    }

    private void BindFromDomain(MonthlyBudget budget)
    {
        RollOver = budget.RollOver;
        Sections.Clear();

        foreach (var section in budget.Sections)
        {
            var items = section.Items.Select(x => new BudgetItemModel(x.Name, x.Amount)).ToList();
            var sectionModel = new BudgetSectionModel(section.Name, section.Type, items);
            sectionModel.PropertyChanged += (_, _) => NotifyTotals();
            foreach (var item in sectionModel.Items)
            {
                item.PropertyChanged += (_, _) => NotifyTotals();
            }

            Sections.Add(sectionModel);
        }

        NotifyTotals();
    }

    private MonthlyBudget ToDomain()
    {
        return new MonthlyBudget
        {
            MonthKey = MonthKey,
            RollOver = RollOver,
            Sections = Sections.Select(section => new BudgetSection
            {
                Name = section.Name,
                Type = section.SectionType,
                Items = section.Items.Select(item => new BudgetLineItem
                {
                    Name = item.Name,
                    Amount = item.Amount
                }).ToList()
            }).ToList()
        };
    }

    private decimal SumByType(BudgetSectionType type)
        => Sections.Where(x => x.SectionType == type).Sum(x => x.Total);

    private void NotifyTotals()
    {
        Notify(nameof(IncomeTotal));
        Notify(nameof(ExpenseTotal));
        Notify(nameof(SpendingBudgetTotal));
        Notify(nameof(GoalTotal));
        Notify(nameof(AdjustmentTotal));
        Notify(nameof(AvailableFromIncome));
        Notify(nameof(AfterExpenses));
        Notify(nameof(AfterSpendingBudgets));
        Notify(nameof(LeftForGoals));
        Notify(nameof(FinalRemaining));
    }
}
