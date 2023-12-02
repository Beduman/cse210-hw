public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string newColor, double newLength, double newWidth) : base (newColor)
    {
        _length = newLength;
        _width = newWidth;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}