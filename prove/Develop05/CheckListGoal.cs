using System.ComponentModel;

class CheckListGoal : Goal
{
    private int amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }


    public void RecordEvent()
    {

    }

    public bool IsComplete()
    {
        // Check if checklist goal is complete
        return false;
    }

    public string GetDetailString()
    {
        return "";
    }

    //public override string GetStringRepresentation()

}