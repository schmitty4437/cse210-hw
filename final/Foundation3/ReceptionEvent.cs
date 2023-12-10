using System;

public class ReceptionEvent : Event
{
    private string _rsvp;

    //Constructor initializes reception details
    public ReceptionEvent(string eventType, string title, string description, string date, string time, Address address, string rsvp) : base(eventType, title, description, date, time, address)
    {
        _rsvp = rsvp;
    }

    //Method that gets reception details
    public new string GetReceptionFullDetails()
    {
        return $"{GetStandardDescription()}\nRSVP Email: {_rsvp}";
    }
}