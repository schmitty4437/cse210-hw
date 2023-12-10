using System;

public class Cycling : Activity
{
    private double _speed;

    //Constructor that initializes the attribures for cycling and inherits base class attributes
    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    //Getters and Setters
    public double Speed
    {
        get {return _speed;}
        set {_speed = value;}
    }

    //Override the base class methods with the calculations for the cycling activity
    public override double GetDistance()
    {
        return Speed * (Duration / 60.0);
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return Duration / GetDistance();
    }

    //Method to get the summary of all the values and puts them in a string for cycling activity
    public override string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} Cycling ({Duration} min) - Speed: {Speed} mph, Distance: {GetDistance()} miles, Pace: {GetPace()} min per mile";
    }
}