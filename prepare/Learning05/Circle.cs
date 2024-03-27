public class Circle : Shape
{
    private double _radio;


    public Circle(string color, double radio) : base(color)
    {
        _radio = radio;

    }

    public override double GetArea()
    {
        return _radio * _radio / Math.PI;
    }
}