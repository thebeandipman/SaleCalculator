using FamilyBudget.Desktop.ViewModels;

namespace FamilyBudget.Desktop.Models;

public sealed class BudgetItemModel : ObservableObject
{
    private string _name;
    private decimal _amount;

    public BudgetItemModel(string name, decimal amount)
    {
        _name = name;
        _amount = amount;
    }

    public string Name
    {
        get => _name;
        set => SetProperty(ref _name, value);
    }

    public decimal Amount
    {
        get => _amount;
        set => SetProperty(ref _amount, value);
    }
}
