// Clase para la actividad de ciclismo
public class Cycling : Activity
{
    public decimal Speed { get; set; }

    // Sobrescribe el método para calcular la velocidad
    public override double GetSpeed()
    {
        return (double)Speed;
    }

    // Sobrescribe el método para obtener un resumen de la actividad
    public override string GetSummary()
    {
        return $"Cycling - Speed: {Speed} km/h, {base.GetSummary()}";
    }
}
