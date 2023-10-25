using System;

//Class: Math
// Attributes:
// * _textbookSection : string
// * _problems : string

// Behaviors:
// * GetHomeworkList() : string

public class Math : Assignment
{
    private string _textbookSection;
    private string _problems;

    public Math(string studentName, string topic, string textBook, string problems) : base(studentName, topic)
    {
        _textbookSection = textBook;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}