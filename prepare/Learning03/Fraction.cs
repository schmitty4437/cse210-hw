using System;

//Class: Fraction
// Attributes:
// * _top : int
// * _bottom : int

// Behaviors:
// * Fraction()
// * Fraction(wholeNumber : int)
// * Fraction(top : int, bottom : int)

// * GetTop()
// * SetTop(top : int)
// * GetBottom()
// * SetBottom(bottom : int)

// * GetFractionString() : string
// * GetDecimalValue() : double

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int topNumber)
    {
        _top = topNumber;
        _bottom = 1;
    }

    public Fraction(int topNumber, int bottomNumber)
    {
        _top = topNumber;
        _bottom = bottomNumber;
    }

    public string GetFractionString()
    {
        string textNumber = $"{_top}/{_bottom}";
        return textNumber;
    }

    public double GetDecimalValue()
    {  
        return (double) _top / _bottom;;
    }
}