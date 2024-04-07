using System.ComponentModel;

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        base.RecordEvent();
    }



    public override bool IsComplete()
    {
        return false;
    }

    public string GetDeatailString()
    {
        return base.GetDetailString();
    }
    public string GetStringRepresentation()
    {
        return base.GetStringRepresentation();
    }
}