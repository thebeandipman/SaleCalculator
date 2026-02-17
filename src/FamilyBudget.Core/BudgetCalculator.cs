namespace FamilyBudget.Core;

public static class BudgetCalculator
{
    public static BudgetSummary Calculate(MonthlyBudget budget)
    {
        var income = SumByType(budget, BudgetSectionType.Income);
        var expense = SumByType(budget, BudgetSectionType.Expense);
        var spending = SumByType(budget, BudgetSectionType.SpendingBudget);
        var goals = SumByType(budget, BudgetSectionType.Goal);
        var adjustments = SumByType(budget, BudgetSectionType.Adjustment);

        return new BudgetSummary
        {
            RollOver = budget.RollOver,
            TotalIncome = income,
            TotalExpenses = expense,
            TotalSpendingBudgets = spending,
            TotalGoals = goals,
            TotalAdjustments = adjustments
        };
    }

    private static decimal SumByType(MonthlyBudget budget, BudgetSectionType type)
    {
        return budget.Sections
            .Where(section => section.Type == type)
            .Sum(section => section.Total);
    }
}
