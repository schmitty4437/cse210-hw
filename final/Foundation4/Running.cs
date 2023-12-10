using System;

public class Running : Activity
{
    private double _distance;

    //Constructor that initializes the attribures for running and inherits base class attributes
    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    //Getters and Setters
    public double Distance
    {
        get {return _distance;}
        set {_distance = value;}
    }

    //Override the base class methods with the calculations for the running activity
    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return (Distance / Duration) * 60;
    }

    public override double GetPace()
    {
        return Duration / Distance;
    }

    //Method to get the summary of all the values and puts them in a string for running activity
    public override string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} Running ({Duration} min) - Distance: {Distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}