namespace AlphabetQuiz.Models;

public class LetterTranscription
{
    public LetterTranscription()
    {
        Letter = '\0';
        Transcription = "";
    }

    public char Letter { get; set; }
    public string Transcription { get; set; }
}