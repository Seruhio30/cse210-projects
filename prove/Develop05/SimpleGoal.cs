class SimpleGoal : Goal
{
    private bool _IsComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _IsComplete = false;
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
        _IsComplete = true;
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
