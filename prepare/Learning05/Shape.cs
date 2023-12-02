public abstract class Shape
{
    private string _color;

    public Shape(string newColor)
    {
        _color = newColor;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string newColor)
    {
        _color = newColor;
    }

    public abstract double GetArea();
}