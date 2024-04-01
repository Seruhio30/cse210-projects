using System.ComponentModel;

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public bool IsComplete()
    {
        return false;
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