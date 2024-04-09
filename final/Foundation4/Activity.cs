public class Activity
{
    public DateTime Date { get; set; }
    public int DurationMinutes { get; set; }

    // Método virtual para calcular la distancia
    public virtual double GetDistance()
    {
        return 0;
    }

    // Método virtual para calcular la velocidad
    public virtual double GetSpeed()
    {
        return 0;
    }

    // Método virtual para calcular el ritmo (pace)
    public virtual double GetPace()
    {
        return 0;
    }

    // Método para obtener un resumen de la actividad
    public virtual string GetSummary()
    {
        return $"{Date.ToShortDateString()} {GetType().Name} ({DurationMinutes} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} km/h, Pace: {GetPace()} min/km";
    }
}