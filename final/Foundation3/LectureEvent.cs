using System;

public class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;

    //Constructor to initialize lecture details
    public LectureEvent(string eventType, string title, string description, string date, string time, Address address, string speaker, int capacity) : base(eventType, title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    //Method that gets lecture details
    public new string GetLectureFullDetails()
    {
        return $"{GetStandardDescription()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}