using System;
using System.Collections.Generic;

//Class: Scripture
// Attributes:
// * _reference : Reference
// * _text : string
// * _List<_hiddenWords> : string

// Behaviors:
// * Scripture(reference : Reference, text : string)
// * HideWords(count : int) : void
// * ShuffleWords(count : int) : void
// * GetRenderedScripture() : string
// * AllWordsHidden() : boolean

public class Scripture
{
    private string _reference;
    private string _text;
    private List<Words> _hiddenWords = new List<Words>();

    public Scripture(string reference, string text)
    {
        _reference = reference;
        _text = text;
        _hiddenWords = text.Split(' ').Select(word => new Words(word, false)).ToList();
    }

    //Getters & setters
    public string Reference
    {
        get { return _reference; }
        set { _reference = value; }
    }

    public string Text
    {
        get { return _text; }
        set { _text = value; }
    }

    public List<Words> HiddenWords
    {
        get { return _hiddenWords; }
        set { _hiddenWords = value; }
    }

    //Hides specified number of words
    public void HideWords(int count)
    {
        Random rnd = new Random();

        //List of non-hidden words
        List<Words> nonHiddenWords = _hiddenWords.Where(word => !word.IsHidden()).ToList();

        //Limit number of non-hidden words
        count = Math.Min(count, nonHiddenWords.Count);

        //Shuffle non-hidden words
        ShuffleWords(rnd, nonHiddenWords);

        for (int i = 0; i < count; i++)
        {
            nonHiddenWords[i].Hide();
        }
    }

    //Shuffle words randomly
    private void ShuffleWords(Random random, List<Words> words)
    {
        int number = words.Count;

        for (int i = number - 1; i > 0; i--)
        {
            int randomIndex = random.Next(0, i + 1);

            Words temp = words[i];
            words[i] = words[randomIndex];
            words[randomIndex] = temp;
        }
    }

    //Gets hidden word scripture text
    public string GetRenderedScripture()
    {
        string visibleText = string.Join(" ", _hiddenWords.Select(word => word.GetRenderedWord()));

        return $"{_reference.Trim()} {visibleText}";
    }

    //Check if all words are hidden
    public bool AllWordsHidden()
    {
        return _hiddenWords.All(word => word.IsHidden());
    }
}

