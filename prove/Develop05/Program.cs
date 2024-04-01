using System;

class Program
{
    static void Main(string[] args)



    {

        GoalMananger goalMananger = new GoalMananger();

        //Console.WriteLine($"You have {point} points");
        bool Quit = false;
        while (!Quit)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Safe goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string option = Console.ReadLine();


            if (option == "1")
            {
                goalMananger.CreateGoal();
            }

            else if (option == "2")
            {
                goalMananger.ListGoalDetails();

            }

            else if (option == "3")
            {
                goalMananger.SafeGoals();
            }


            else if (option == "4")
            {
                goalMananger.LoadGoals();
            }

            else if (option == "5")
            {
                goalMananger.RecordEvent();
            }

            else if (option == "6")
            {

            }

            else
            {
                Console.WriteLine("Invalid option! Please choose a valid option.");
            }
        }
    }
}