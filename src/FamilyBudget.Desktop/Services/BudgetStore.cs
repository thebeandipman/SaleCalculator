using System.Text.Json;
using FamilyBudget.Core;

namespace FamilyBudget.Desktop.Services;

public sealed class BudgetStore
{
    private readonly JsonSerializerOptions _jsonOptions = new()
    {
        WriteIndented = true
    };

    private readonly string _dataDirectory;

    public BudgetStore()
    {
        var appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        _dataDirectory = Path.Combine(appData, "FamilyBudget");
        Directory.CreateDirectory(_dataDirectory);
    }

    public async Task<MonthlyBudget> LoadOrCreateAsync(string monthKey)
    {
        var existing = await TryLoadAsync(monthKey);
        if (existing is not null)
        {
            return existing;
        }

        var previous = await TryLoadAsync(GetPreviousMonthKey(monthKey));
        if (previous is not null)
        {
            return BudgetTemplates.CloneForNextMonth(previous, monthKey);
        }

        return BudgetTemplates.CreateBlank(monthKey);
    }

    public async Task SaveAsync(MonthlyBudget budget)
    {
        var file = GetFilePath(budget.MonthKey);
        await using var stream = File.Create(file);
        await JsonSerializer.SerializeAsync(stream, budget, _jsonOptions);
    }

    private async Task<MonthlyBudget?> TryLoadAsync(string monthKey)
    {
        var file = GetFilePath(monthKey);
        if (!File.Exists(file))
        {
            return null;
        }

        await using var stream = File.OpenRead(file);
        return await JsonSerializer.DeserializeAsync<MonthlyBudget>(stream, _jsonOptions);
    }

    private string GetFilePath(string monthKey) => Path.Combine(_dataDirectory, $"{monthKey}.json");

    private static string GetPreviousMonthKey(string monthKey)
    {
        if (!DateOnly.TryParse($"{monthKey}-01", out var thisMonth))
        {
            return monthKey;
        }

        var previous = thisMonth.AddMonths(-1);
        return $"{previous:yyyy-MM}";
    }
}
