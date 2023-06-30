using AlphabetQuiz.ViewModels;
using AlphabetQuiz.Views;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

namespace AlphabetQuiz;

public class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is not IClassicDesktopStyleApplicationLifetime desktop) return;

        desktop.MainWindow = new MainWindow
        {
            DataContext = new MainWindowViewModel()
        };

        base.OnFrameworkInitializationCompleted();
    }
}