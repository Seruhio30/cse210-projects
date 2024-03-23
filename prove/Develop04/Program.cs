using System;


bool Quit = false;
while (!Quit)
{
    Console.WriteLine("Menu Options: ");
    Console.WriteLine("1. Start Breathing Activity");
    Console.WriteLine("2. Start Reflecting Activity");
    Console.WriteLine("3. Start Listing Activity");
    Console.WriteLine("4. Quit");
    Console.Write("Select a choice from the menu: ");
    string option = Console.ReadLine();

    if (option == "1")
    {
        BreathingActivity breathingActivity = new BreathingActivity("Breathing", "relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        breathingActivity.Run();
    }

    else if (option == "2")
    {

    }

    else if (option == "3")
    {

    }

    else if (option == "4")
    {

    }

    else
    {
        Console.WriteLine("Invalid option! Please choose a valid option.");
    }


}
