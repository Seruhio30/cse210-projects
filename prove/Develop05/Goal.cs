class Goal
{
    protected string _name;
    protected string _description;

    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public virtual void RecordEvent()
    {

    }




    public virtual bool IsComplete()
    {
        return false;
    }

    public string GetDetailString()
    {
        return $"{_name} - {_description}";
    }

    public string GetStringRepresentation()
    {
        return $"{GetType().Name}:{_name}:{_description}:{_points}";

    }
}