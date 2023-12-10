using System;

public class OutdoorsEvent : Event
{
    private string _weatherReport;

    //Constructor initializing outdoor details
    public OutdoorsEvent(string eventType, string title, string description, string date, string time, Address address, string weather) : base(eventType, title, description, date, time, address)
    {
        _weatherReport = weather;
    }

    //Method to get outdoors details
    public new string GetOutdoorsFullDetails()
    {
        return $"{GetStandardDescription()}\nWeather: {_weatherReport}";
    }
}