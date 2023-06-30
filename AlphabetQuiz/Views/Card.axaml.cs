using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AlphabetQuiz.Views;

public partial class Card : UserControl
{
    public Card()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}