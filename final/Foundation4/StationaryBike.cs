public class StationaryBike : Activity
{
    public double Speed { get; set; }

    // Sobrescribe el método para calcular la velocidad
    public override double GetSpeed()
    {
        return Speed;
    }

    // Sobrescribe el método para calcular el ritmo
    public override double GetPace()
    {
        return 60.0 / Speed;
    }
}