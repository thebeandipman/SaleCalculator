namespace FamilyBudget.Core;

public enum BudgetSectionType
{
    Income,
    Expense,
    SpendingBudget,
    Goal,
    Adjustment
}

public sealed class BudgetLineItem
{
    public string Name { get; set; } = string.Empty;
    public decimal Amount { get; set; }
}

public sealed class BudgetSection
{
    public string Name { get; set; } = string.Empty;
    public BudgetSectionType Type { get; set; }
    public List<BudgetLineItem> Items { get; set; } = new();

    public decimal Total => Items.Sum(x => x.Amount);
}

public sealed class MonthlyBudget
{
    public string MonthKey { get; set; } = string.Empty;
    public decimal RollOver { get; set; }
    public List<BudgetSection> Sections { get; set; } = new();
}

public sealed class BudgetSummary
{
    public decimal RollOver { get; init; }
    public decimal TotalIncome { get; init; }
    public decimal TotalExpenses { get; init; }
    public decimal TotalSpendingBudgets { get; init; }
    public decimal TotalGoals { get; init; }
    public decimal TotalAdjustments { get; init; }

    public decimal AvailableFromIncome => RollOver + TotalIncome;
    public decimal AfterExpenses => AvailableFromIncome - TotalExpenses;
    public decimal AfterSpendingBudgets => AfterExpenses - TotalSpendingBudgets;
    public decimal LeftForGoals => AfterSpendingBudgets;
    public decimal FinalRemaining => LeftForGoals - TotalGoals + TotalAdjustments;
}
