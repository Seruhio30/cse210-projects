// Clase para la actividad de correr
public class Running : Activity
{
    public decimal Distance { get; set; }

    // Sobrescribe el método para calcular la velocidad
    public override double GetSpeed()
    {
        if (DurationMinutes == 0)
        {
            throw new InvalidOperationException("Duration cannot be zero.");
        }
        return (double)Distance / ((double)DurationMinutes / 60);
    }

    // Sobrescribe el método para calcular el ritmo
    public override double GetPace()
    {
        if (Distance == 0)
        {
            throw new InvalidOperationException("Distance cannot be zero.");
        }
        return ((double)DurationMinutes / 60) / (double)Distance;
    }

    // Sobrescribe el método para obtener un resumen de la actividad
    public override string GetSummary()
    {
        return $"Running - Distance: {Distance} km, {base.GetSummary()}";
    }
}
