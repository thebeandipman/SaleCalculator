using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using FamilyBudget.Desktop.Services;
using FamilyBudget.Desktop.ViewModels;
using FamilyBudget.Desktop.Views;

namespace FamilyBudget.Desktop;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            var store = new BudgetStore();
            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainWindowViewModel(store)
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}
