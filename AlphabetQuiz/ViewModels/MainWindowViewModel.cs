using System.Reactive;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace AlphabetQuiz.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        Card = new CardViewModel();
        NextLetterCommand = ReactiveCommand.Create(NextLetter);
    }

    [Reactive] public CardViewModel Card { get; set; }
    public ReactiveCommand<Unit, Unit> NextLetterCommand { get; set; }

    private void NextLetter()
    {
        Card = new CardViewModel();
    }
}