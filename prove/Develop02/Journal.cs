using System;
using System.IO; 

//Class: Journal
// Attributes:
// * _entries : List<Entry>

// Behaviors:
// * addEntry()
// * saveToFile()
// * loadFromFile()
// * display()

class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void addEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void saveToFile()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(Entry entry in _entries)
            {
                //$"{_dateOfResponse} {_responsePrompt} {_response}"
                outputFile.WriteLine($"{entry._dateOfResponse}|{entry._responsePrompt}|{entry._response}");
            }
        }

    }

    public void loadFromFile()
    {
        //Clears any entries that were not saved.
        _entries.Clear();

        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string date = parts[0];
            string promptQuestion = parts[1];
            string userResponse = parts[2];

            Entry tempEntry = new Entry();

            tempEntry.addEntryFromFile(date, promptQuestion, userResponse);
            addEntry(tempEntry);
        }
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
}