class SimpleGoal : Goal
{
    private bool _IsComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }


    public void RecordEvent()
    {

    }

    public void IsComplete()
    {

    }
    public string GetStringRepresentation()
    {
        return "";
    }
}