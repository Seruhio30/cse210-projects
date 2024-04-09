public class Swimming : Activity
{
    public int Laps { get; set; }

    // Sobrescribe el método para calcular la distancia
    public override double GetDistance()
    {
        return Laps * 50 / 1000.0; // 50 metros por vuelta
    }

    // Sobrescribe el método para calcular el ritmo
    public override double GetPace()
    {
        return DurationMinutes / (Laps * 50 / 1000.0); // Pace en minutos por kilómetro
    }
}