using System;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _eventType;

    //Constructor to initialize event details
    public Event(string eventType, string title, string description, string date, string time, Address address)
    {
        _eventType = eventType;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    //Getters and Setters
    public string Title
    {
        get {return _title;}
        set {_title = value;}
    }

    public string Description
    {
        get {return _description;}
        set {_description = value;}
    }

    public string Date
    {
        get {return _date;}
        set {_date = value;}
    }

    public string Time
    {
        get {return _time;}
        set {_time = value;}
    }

    public Address Address
    {
        get {return _address;}
        set {_address = value;}
    }

    public string EventType
    {
        get {return _eventType;}
        set {_eventType = value;}
    }

    //Method to get standard description
    public string GetStandardDescription()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time} \nAddress: {Address.GetAddress()}";
    }

    //Method gets short description
    public string GetShortDescription()
    {
        return $"{_eventType} Details: \nTitle: {_title}\nDate: {_date}";
    }

    //Method gets full details from lecture event
    public string GetLectureFullDetails()
    {
        return GetStandardDescription();
    }

    //Method gets full details from reception event
    public string GetReceptionFullDetails()
    {
        return GetStandardDescription();
    }

    //Method gets full details from outdoors event
    public string GetOutdoorsFullDetails()
    {
        return GetStandardDescription();
    }

    //Method displays the event details
    public void Display()
    {
        Console.WriteLine("Standard Details:");
        Console.WriteLine(GetStandardDescription());
        Console.WriteLine();

        Console.WriteLine("Full Details:");

        //Check current instance type
        //'this' refers to current instance of the class
        //'is' will check if the current instance is in the stated class
        if (this is LectureEvent)
        {
            Console.WriteLine(((LectureEvent)this).GetLectureFullDetails());
        }
        else if (this is ReceptionEvent)
        {
            Console.WriteLine(((ReceptionEvent)this).GetReceptionFullDetails());
        }
        else if (this is OutdoorsEvent)
        {
            Console.WriteLine(((OutdoorsEvent)this).GetOutdoorsFullDetails());
        }

        Console.WriteLine();

        Console.WriteLine("Short Details:");
        Console.WriteLine(GetShortDescription());
        Console.WriteLine();
    }
}