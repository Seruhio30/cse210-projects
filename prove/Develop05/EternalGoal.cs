using System.ComponentModel;

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        // No hacer nada, ya que los objetivos eternos nunca se completan
        base.RecordEvent(); // Llama al método de la clase base (en este caso, no hace nada)
    }



    public override bool IsComplete()
    {
        // Método para verificar si el objetivo eterno está completo
        return false; // Dado que los objetivos eternos nunca se completan
    }

    public string GetDeatailString()
    {
        // Get detail string for eternal goal
        return base.GetDetailString();
    }
    public string GetStringRepresentation()
    {
        // Get string representation for eternal goal
        return base.GetStringRepresentation();
    }
}