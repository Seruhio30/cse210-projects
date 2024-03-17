using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private readonly Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
        _random = new Random();
    }

    public void HideRandomWords(int numberToHide)
    {
        if (numberToHide <= 0)
            return;

        var wordsToHide = _words.Where(word => !word.IsHidden()).ToList();
        if (wordsToHide.Count == 0)
            return;

        for (int i = 0; i < numberToHide; i++)
        {
            var index = _random.Next(wordsToHide.Count);
            wordsToHide[index].Hide();
            wordsToHide.RemoveAt(index);
            if (wordsToHide.Count == 0)
                break;
        }
    }

    public string GetDisplayText()
    {
        string text = _reference.GetDisplayText() + "\n\n";
        foreach (var word in _words)
        {
            text += word.GetDisplayText() + " ";
        }
        return text.Trim();
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
