class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {

        base.RecordEvent();
    }


    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public int GetCompletedCount()
    {
        return _amountCompleted;
    }

    public string GetDetailString()
    {
        return $"{_name} - {_description} [Completed {_amountCompleted}/{_target} times]";
    }

    public string GetStringRepresentation()
    {
        return $"{GetType().Name}:{_name}:{_description}:{_points}:{_target}:{_bonus}";
    }
}
