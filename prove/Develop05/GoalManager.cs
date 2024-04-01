using System.Collections;
using System.Diagnostics;
using System.Runtime;
using System.IO;

class GoalMananger
{
    private List<Goal> _Goal = new List<Goal>();

    private int _Score;

    public GoalMananger()
    {
        _Score = 0;
    }

    public void Start()
    {

    }

    public void DisplayPlayerInfo()
    {

    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _Goal.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_Goal[i].GetDetailString()}");
        }
    }

    public void ListGoalDetails()
    {
        // verify if the list have elements
        if (_Goal.Count == 0)
        {
            Console.WriteLine("No hay metas registradas.");
            return;
        }

        // if the list have elements show it
        Console.WriteLine("List of Goals:");
        for (int i = 0; i < _Goal.Count; i++)
        {
            Console.WriteLine($"Goal {i + 1}: {_Goal[i].GetDetailString()}");
        }
    }

    public void CreateGoal()
    {

        // Declaración de variables
        string name, description;
        int points;
        int target;
        int bonus;

        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. SimpleGoal");
        Console.WriteLine("2. EternalGoal");
        Console.WriteLine("3. CheckListGoal");
        Console.Write("Which type of goal do you want to create? Enter the number: ");
        string option = Console.ReadLine();

        switch (option)
        {
            case "1":
                // Agregar un SimpleGoal a la lista _Goal
                Console.Write("What is the name of the simple goal?  ");
                name = Console.ReadLine();

                Console.Write("What is a short description of it:  ");
                description = Console.ReadLine();

                Console.Write("What is amount of point associated with this goal?  ");
                points = int.Parse(Console.ReadLine());

                _Goal.Add(new SimpleGoal(name, description, points));

                Console.WriteLine("SimpleGoal created.");
                break;
            case "2":
                // Agregar un EternalGoal a la lista _Goal
                Console.Write("What is the name of the simple goal?  ");
                name = Console.ReadLine();

                Console.Write("What is a short description of it:  ");
                description = Console.ReadLine();

                Console.Write("What is amount of point associated with this goal?  ");
                points = int.Parse(Console.ReadLine());

                _Goal.Add(new EternalGoal(name, description, points));
                Console.WriteLine("Eternal Goal created.");
                break;

            case "3":
                // Agregar un CheckListGoal a la lista _Goal
                Console.Write("What is the name of the simple goal?  ");
                name = Console.ReadLine();

                Console.Write("What is a short description of it:  ");
                description = Console.ReadLine();

                Console.Write("What is amount of point associated with this goal?  ");
                points = int.Parse(Console.ReadLine());

                Console.Write("How many times does this goalneed to be accomplished for a bonus?  ");
                target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times?  ");
                bonus = int.Parse(Console.ReadLine());

                _Goal.Add(new CheckListGoal(name, description, points, target, bonus));
                Console.WriteLine("Check List goal created.");
                break;
            default:
                Console.WriteLine("Invalid option! Please enter a valid number.");
                break;
        }
    }


    public void RecordEvent()
    {

    }

    public void SafeGoals()
    {
        Console.Write("Enter file path to save goals: ");
        string filePath = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Goal goal in _Goal)
                {
                    // Escribir todos los detalles de la meta en una línea del archivo
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }

            Console.WriteLine("Goals saved to file successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    public void LoadGoals()
    {
        Console.Write("Enter file path to load goals: ");
        string filePath = Console.ReadLine();

        try
        {
            _Goal.Clear(); // Limpiar la lista de metas antes de cargar desde el archivo

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Analizar la línea para obtener los detalles de la meta
                    string[] parts = line.Split(':');
                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    // Crear la instancia adecuada de la meta según el tipo
                    switch (type)
                    {
                        case "SimpleGoal":
                            _Goal.Add(new SimpleGoal(name, description, points));
                            break;
                        case "EternalGoal":
                            _Goal.Add(new EternalGoal(name, description, points));
                            break;
                        case "CheckListGoal":
                            int target = int.Parse(parts[4]);
                            int bonus = int.Parse(parts[5]);
                            _Goal.Add(new CheckListGoal(name, description, points, target, bonus));
                            break;
                        default:
                            Console.WriteLine($"Invalid goal type: {type}");
                            break;
                    }
                }
            }

            Console.WriteLine("Goals loaded successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }



}