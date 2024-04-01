class Goal
{
    private string _name;
    private string _description;

    private int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public void RecordEvent()
    {

    }

    public void IsComplete()
    {

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