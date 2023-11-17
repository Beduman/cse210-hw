using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        // Default to 1/1
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public Fraction(int number)
    {
        _top = number;
        _bottom = 1;
    }
    public string GetFraction()
    {
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }
    public double GetDecimal()
    {
        return (double)_top / (double)_bottom;
    }
}