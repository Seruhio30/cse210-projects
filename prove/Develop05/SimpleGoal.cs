class SimpleGoal : Goal
{
    private bool _IsComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _IsComplete = false;
    }

    public override void RecordEvent()
    {
        // Marcar el objetivo como completo cuando se registra un evento
        base.RecordEvent(); // Llama al método de la clase base (en este caso, no hace nada)
        _IsComplete = true; // Marca el objetivo como completo
    }


    public override bool IsComplete()
    {
        return _IsComplete;
    }

    public string GetStringRepresentation()
    {
        return base.GetStringRepresentation();
    }
}
