using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction() //Constructor that has no parameters
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber) //Constructor that has one parameter
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom) //Constructor that has two parameters
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString() //method
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue() //method
    {
        return (double)_top / (double)_bottom;
    }
}