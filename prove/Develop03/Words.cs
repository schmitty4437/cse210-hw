using System;

//Class: Words
// Attributes:
// * _text : string
// _hidden : boolean

// Behaviors:
// * Words(text : string, hidden : boolean)
// * Hide() : void
// * IsHidden() : boolean
// * GetRenderedWord() : string

public class Words
{
    private string _text;
    private bool _hidden;

    //Default constructor
    public Words()
    {
        _text = string.Empty;
        _hidden = false;
    }

    //Constructor that sets the text and hidden attribute
    public Words(string text, bool hidden)
    {
        _text = text;
        _hidden = hidden;
    }

    //Getters & Setters
    public string Text
    {
        get { return _text; }
        set { _text = value; }
    }

    public bool Hidden
    {
        get { return _hidden; }
        set { _hidden = value; }
    }

    //Hide a word and set _hidden to true
    public void Hide()
    {
        // Hides the word
        _hidden = true;
    }

    public bool IsHidden()
    {
        // Checks if the word is hidden
        return _hidden;
    }

    //Check if a word is hidden
    public string GetRenderedWord()
    {
        // Returns the word with its visibility status
        if(_hidden)
        {
            //Replaces hidden words with '_'
            string hiddenWords = new string('_', _text.Length);
            return hiddenWords;
        }
        else
        {
            //Will return orginal word if it was not hidden
            return _text;
        }
        //Coworker showed me this line below. Shorthand version of what I have above.
        //Not using it since I didn't know until now but keeping so I have reference for future uses.
        //return _hidden ? new string('_', _text.Length) : _text;
    }
}