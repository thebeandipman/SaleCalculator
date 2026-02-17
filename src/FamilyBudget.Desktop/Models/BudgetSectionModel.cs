using System.Collections.ObjectModel;
using FamilyBudget.Core;
using FamilyBudget.Desktop.ViewModels;

namespace FamilyBudget.Desktop.Models;

public sealed class BudgetSectionModel : ObservableObject
{
    public BudgetSectionModel(string name, BudgetSectionType sectionType, IEnumerable<BudgetItemModel> items)
    {
        Name = name;
        SectionType = sectionType;
        Items = new ObservableCollection<BudgetItemModel>(items);

        foreach (var item in Items)
        {
            item.PropertyChanged += (_, _) => Notify(nameof(Total));
        }

        Items.CollectionChanged += (_, _) => Notify(nameof(Total));
    }

    public string Name { get; }

    public BudgetSectionType SectionType { get; }

    public ObservableCollection<BudgetItemModel> Items { get; }

    public decimal Total => Items.Sum(x => x.Amount);
}
