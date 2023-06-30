using System;
using AlphabetQuiz.Models;

namespace AlphabetQuiz;

public class LetterTable
{
    public LetterTranscription GetRandomLetter()
    {
        const string letters =
            "あ a.か ka.さ sa.た ta.な na.は ha.ま ma.ら ra.わ wa.や ya.い i.き ki.し shi.ち chi.に ni.ひ hi.み mi.り ri.を wo.ゆ yu.う u.く ku.す su.つ tsu.ぬ nu.ふ fu.む mu.る ru.ん n.よ yo.え e.け ke.せ se.て te.ね ne.へ he.め me.れ re.お o.こ ko.そ so.と to.の no.ほ ho.も mo.ろ ro";

        string[] split = letters.Split(".");
        string[] letter = split[Random.Shared.Next(0, split.Length)].Split(" ");

        return new LetterTranscription
        {
            Letter = Convert.ToChar(letter[0]),
            Transcription = letter[1]
        };
    }
}