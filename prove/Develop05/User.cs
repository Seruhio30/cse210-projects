class User
{
    private Dictionary<string, Goal> _goals = new Dictionary<string, Goal>();

    public void CreateGoal(string name, string description, int points, int target = 0, int bonus = 0)
    {
        // Crear la meta correspondiente según el tipo de objetivo
        Goal goal;
        if (target == 0)
        {
            goal = new SimpleGoal(name, description, points);
        }
        else if (target > 0 && bonus > 0)
        {
            goal = new CheckListGoal(name, description, points, target, bonus);
        }
        else
        {
            goal = new EternalGoal(name, description, points);
        }

        // Agregar la meta al diccionario
        _goals.Add(name, goal);
    }

    public void RecordEvent(string goalName)
    {
        if (_goals.ContainsKey(goalName))
        {
            Goal goal = _goals[goalName];
            goal.RecordEvent();
            Console.WriteLine($"Event recorded for goal: {goalName}");
        }
        else
        {
            Console.WriteLine($"Goal with name {goalName} not found.");
        }
    }
}