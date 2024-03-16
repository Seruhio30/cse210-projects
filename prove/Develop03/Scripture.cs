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

    public void HideNextWord()
    {
        var words = _words.Where(word => !word.IsHidden()).ToList();
        if (words.Count == 0)
            return;

        var index = _random.Next(words.Count);
        words[index].Hide();
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden());
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()}\n\n{string.Join(" ", _words.Select(word => word.GetDisplayText()))}";
    }
}
