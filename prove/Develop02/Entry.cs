using System;

//Class: Entry
// Attributes:
// * _dateOfResponse : string
// * _responsePrompt : string
// * _response : string

// Behaviors:
// * addEntry() : void
// * addEntryFromFile() : void
// * display() : void

class Entry
{
    public string _dateOfResponse;
    public string _responsePrompt;
    public string _response;

    //Creates entry object from user response
    public void addEntry(string prompt, string response)
    {
        DateTime theCurrentTime = DateTime.Now;
        _dateOfResponse = theCurrentTime.ToString();
        _responsePrompt = prompt;
        _response = response;
    }
    //Creates entry object from the loaded file.
    public void addEntryFromFile(string date, string prompt, string response)
    {
        _dateOfResponse = date;
        _responsePrompt = prompt;
        _response = response;
    }

    //Displays the date, prompt, and user response.
    public void Display()
    {
        Console.WriteLine($"{_dateOfResponse} {_responsePrompt} {_response}");
    }
}