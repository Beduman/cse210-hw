public class Circle : Shape
{
    private double _radius;

    public Circle(string newColor, double newRadius) : base (newColor)
    {
        _radius = newRadius;
    }

    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}