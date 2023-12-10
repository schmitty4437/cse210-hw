using System;

public class Swimming : Activity
{
    private int _laps;

    //Constructor that initializes the attribures for swimming and inherits base class attributes
    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    //Getters and Setters
    public int Laps
    {
        get {return _laps;}
        set {_laps = value;}
    }

    //Override the base class methods with the calculations for the swimming activity
    public override double GetDistance()
    {
        return Laps * 50.0 / 1000.0 * .62;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (Duration / 60.0);
    }

    public override double GetPace()
    {
        return Duration / GetDistance();
    }

    //Method to get the summary of all the values and puts them in a string for swimming activity
    public override string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} Swimming ({Duration} min) - Laps: {Laps}, Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}