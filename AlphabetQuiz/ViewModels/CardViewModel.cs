using System.Reactive;
using AlphabetQuiz.Models;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace AlphabetQuiz.ViewModels;

public class CardViewModel : ViewModelBase
{
    public CardViewModel()
    {
        var letterTable = new LetterTable();
        LetterTranscription = letterTable.GetRandomLetter();

        Letter = LetterTranscription.Letter.ToString();
        ShowLetterCommand = ReactiveCommand.Create(ShowLetter, this.WhenAnyValue(x => x.IsShown, b => !b));
    }


    [Reactive] private bool IsShown { get; set; }
    private LetterTranscription LetterTranscription { get; }

    public ReactiveCommand<Unit, Unit> ShowLetterCommand { get; set; }
    [Reactive] public string Letter { get; set; }


    private void ShowLetter()
    {
        IsShown = true;
        Letter = LetterTranscription.Transcription;
    }
}