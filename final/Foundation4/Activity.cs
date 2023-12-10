using System;

public abstract class Activity
{
    private int _duration;
    private DateTime _date;

    //Constructor that initializes the common attributes for all activities
    protected Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    //Getters and setters
    public DateTime Date
    {
        get {return _date;}
        set {_date = value;}
    }

    public int Duration
    {
        get {return _duration;}
        set {_duration = value;}
    }

    //Virtual methods that will be overriden by the other classes
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    public virtual string GetSummary()
    {
        return "";
    }
}