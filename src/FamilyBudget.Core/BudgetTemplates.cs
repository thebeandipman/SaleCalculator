namespace FamilyBudget.Core;

public static class BudgetTemplates
{
    public static MonthlyBudget CreateBlank(string monthKey)
    {
        return new MonthlyBudget
        {
            MonthKey = monthKey,
            RollOver = 0,
            Sections =
            [
                new BudgetSection
                {
                    Name = "Income",
                    Type = BudgetSectionType.Income,
                    Items =
                    [
                        new BudgetLineItem { Name = "Husband Income", Amount = 0 },
                        new BudgetLineItem { Name = "Wife Income", Amount = 0 },
                        new BudgetLineItem { Name = "Bonuses / Miscellaneous", Amount = 0 }
                    ]
                },
                new BudgetSection
                {
                    Name = "Auto Payments",
                    Type = BudgetSectionType.Expense,
                    Items =
                    [
                        new BudgetLineItem { Name = "Insurance", Amount = 0 },
                        new BudgetLineItem { Name = "Utilities", Amount = 0 },
                        new BudgetLineItem { Name = "Subscriptions", Amount = 0 }
                    ]
                },
                new BudgetSection
                {
                    Name = "Expected Manual Expenses",
                    Type = BudgetSectionType.Expense,
                    Items =
                    [
                        new BudgetLineItem { Name = "Mortgage / Rent", Amount = 0 },
                        new BudgetLineItem { Name = "Debt Payments", Amount = 0 },
                        new BudgetLineItem { Name = "Other Bills", Amount = 0 }
                    ]
                },
                new BudgetSection
                {
                    Name = "Spending Budgets",
                    Type = BudgetSectionType.SpendingBudget,
                    Items =
                    [
                        new BudgetLineItem { Name = "Groceries", Amount = 0 },
                        new BudgetLineItem { Name = "Restaurants", Amount = 0 },
                        new BudgetLineItem { Name = "Gas", Amount = 0 },
                        new BudgetLineItem { Name = "Personal Spending", Amount = 0 }
                    ]
                },
                new BudgetSection
                {
                    Name = "Goals",
                    Type = BudgetSectionType.Goal,
                    Items =
                    [
                        new BudgetLineItem { Name = "Vacation", Amount = 0 },
                        new BudgetLineItem { Name = "Christmas", Amount = 0 },
                        new BudgetLineItem { Name = "Investments", Amount = 0 }
                    ]
                },
                new BudgetSection
                {
                    Name = "Non-Budgeted Items",
                    Type = BudgetSectionType.Adjustment,
                    Items =
                    [
                        new BudgetLineItem { Name = "Misc Adjustment (+/-)", Amount = 0 }
                    ]
                }
            ]
        };
    }

    public static MonthlyBudget CloneForNextMonth(MonthlyBudget previousMonth, string nextMonthKey)
    {
        return new MonthlyBudget
        {
            MonthKey = nextMonthKey,
            RollOver = previousMonth.RollOver,
            Sections = previousMonth.Sections
                .Select(section => new BudgetSection
                {
                    Name = section.Name,
                    Type = section.Type,
                    Items = section.Items
                        .Select(item => new BudgetLineItem
                        {
                            Name = item.Name,
                            Amount = item.Amount
                        })
                        .ToList()
                })
                .ToList()
        };
    }
}
