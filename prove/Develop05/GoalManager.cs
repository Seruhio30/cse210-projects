using System.Collections;
using System.Diagnostics;
using System.Runtime;
using System.IO;
using System.Collections.Generic;

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
        if (_Goal.Count == 0)
        {
            Console.WriteLine("No hay metas registradas.");
            return;
        }

        Console.WriteLine("------------------------------------------------------------------------------");
        Console.WriteLine("List of Goals:");
        Console.WriteLine();
        for (int i = 0; i < _Goal.Count; i++)
        {
            string detail = "";

            if (_Goal[i].IsComplete())
            {
                detail += "[X]";
            }
            else
            {
                detail += "[ ]";
            }

            detail += " ";

            detail += $"{i + 1}. {_Goal[i].GetDetailString()}";

            Console.WriteLine(detail);
        }
    }


    public void CreateGoal()
    {

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
        Console.WriteLine();
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine();

        switch (option)
        {
            case "1":
                Console.Write("What is the name of the simple goal?  ");
                name = Console.ReadLine();
                Console.WriteLine();

                Console.Write("What is a short description of it:  ");
                description = Console.ReadLine();
                Console.WriteLine();

                Console.Write("What is amount of point associated with this goal?  ");
                points = int.Parse(Console.ReadLine());
                Console.WriteLine();

                _Goal.Add(new SimpleGoal(name, description, points));
                Console.WriteLine("SimpleGoal created.");

                break;
            case "2":
                Console.Write("What is the name of the Eternal goal?  ");
                name = Console.ReadLine();
                Console.WriteLine();

                Console.Write("What is a short description of it:  ");
                description = Console.ReadLine();
                Console.WriteLine();

                Console.Write("What is amount of point associated with this goal?  ");
                points = int.Parse(Console.ReadLine());
                Console.WriteLine();

                _Goal.Add(new EternalGoal(name, description, points));
                Console.WriteLine("Eternal Goal created.");
                break;

            case "3":
                Console.Write("What is the name of the CheckList goal?  ");
                name = Console.ReadLine();
                Console.WriteLine();

                Console.Write("What is a short description of it:  ");
                description = Console.ReadLine();
                Console.WriteLine();

                Console.Write("What is amount of point associated with this goal?  ");

                string pointsInput = Console.ReadLine();
                if (int.TryParse(pointsInput, out points))
                {
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }

                Console.WriteLine();

                Console.Write("How many times does this goalneed to be accomplished for a bonus?  ");
                target = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("What is the bonus for accomplishing it that many times?  ");
                bonus = int.Parse(Console.ReadLine());
                Console.WriteLine();

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
        ListGoalNames();

        Console.Write("Enter the goal number you want to record event for: ");
        int goalNumber = int.Parse(Console.ReadLine()) - 1;

        if (goalNumber >= 0 && goalNumber < _Goal.Count)
        {
            _Goal[goalNumber].RecordEvent();
            Console.WriteLine("Event recorded successfully.");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
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
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }

            Console.WriteLine("Goals saved to file successfully.");
            Console.WriteLine("-------------------------------------------------------");
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
            _Goal.Clear();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');
                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

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
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }



}