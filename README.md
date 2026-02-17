# Family Budget Planner (C# Desktop-First)

This repository now contains a **desktop-first family budget app** written in C#.

## Goals implemented in v1 scaffold

- Monthly planning model with:
  - Roll over balance
  - Multiple income sources
  - Auto payments
  - Expected manual expenses
  - Spending budgets
  - Goals
  - Non-budgeted adjustments
- Section totals and summary calculations.
- Negative values are allowed and shown directly.
- Month priming: when a month does not exist, the app clones the previous month data.

## Solution layout

- `src/FamilyBudget.Core`
  - Domain models and budget calculation logic.
  - Default template for new budgets.
  - Clone/prime support for next month.
- `src/FamilyBudget.Desktop`
  - Avalonia desktop UI.
  - JSON file persistence in user app data folder.
  - Manual, spreadsheet-like editing for each section.

## Why this supports future Azure web hosting

The business logic lives in `FamilyBudget.Core` and is UI-independent.
A future ASP.NET Core/Blazor app can reuse this same core project while the desktop app continues to work.

## Run (after .NET SDK install)

```bash
dotnet restore SaleCalculator.sln
dotnet run --project src/FamilyBudget.Desktop/FamilyBudget.Desktop.csproj
```
