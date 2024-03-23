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
        ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting", "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        reflectingActivity.Run();
    }

    else if (option == "3")
    {
        ListingActivity listingActivity = new ListingActivity("Listen", "reflect on the good things in your life by having you list as many things as you can in a certain area.");
        listingActivity.Run();
    }

    else if (option == "4")
    {
        break;
    }

    else
    {
        Console.WriteLine("Invalid option! Please choose a valid option.");
    }


}
