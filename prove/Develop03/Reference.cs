using System;

//Class: Reference
// Attributes:
// * _book : string
// * _chapter : string
// * _verseStart : int
// * _verseEnd : int
// * _IsVerseRange : boolean

// Behaviors:
// * Reference(book : string, chapter : string, verseStart : int)
// * Reference(book : string, chapter : string, verseStart : int, verseEnd : int)
// * GetReference() : string
// * CheckIsVerseRange() : boolean

public class Reference
{
    private string _book;
    private string _chapter;
    private string _verseStart;
    private string _verseEnd;
    private bool _isVerseRange;

    // Default constructor
    public Reference()
    {
        _book = "Unknown";
        _chapter = "1";
        _verseStart = "1";
        _isVerseRange = false;
    }

    //Constructor for multiple verses
    public Reference(string book, string chapter, string verseStart, string verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
        _isVerseRange = true;
    }

    //Constructor for single verse
    public Reference(string book, string chapter, string verseStart)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _isVerseRange = false;
    }

    //Getters & setters
    public string Book
    {
        get { return _book; }
        set { _book = value; }
    }

    public string Chapter
    {
        get { return _chapter; }
        set { _chapter = value; }
    }

    public string VerseStart
    {
        get { return _verseStart; }
        set { _verseStart = value; }
    }

    public string VerseEnd
    {
        get { return _verseEnd; }
        set { _verseEnd = value; }
    }

    public bool IsVerseRange
    {
        get { return _isVerseRange; }
        set { _isVerseRange = value; }
    }

    //Creates a formatted reference string
    public string GetReference()
    {
        //Found .IsNullOrEmpty() which helps check if they string is null or empty
         if (string.IsNullOrEmpty(_book) || string.IsNullOrEmpty(_chapter) || string.IsNullOrEmpty(_verseStart))
        {
            //Return empty string if true
            return string.Empty;
        }
        else if (_isVerseRange)
        {
            //Format for multiple verses
            return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
        }
        else
        {
            //Format for single verse
            return $"{_book} {_chapter}:{_verseStart}";
        }
    }

    // Checks if the reference has multiple verses
    public bool CheckIsVerseRange()
    {
        
        return _isVerseRange;
    }
}