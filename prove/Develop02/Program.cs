using System;
using System.Collections.Generic;
using System.IO;

Journal journal = new Journal();
PromptGenerator promptGenerator = new PromptGenerator();


bool exit = false;
while (!exit)
{
    Console.WriteLine("Menu: ");
    Console.WriteLine("1. Write a new Entry");
    Console.WriteLine("2. Display the Jurnal");
    Console.WriteLine("3. Save the journal to a file");
    Console.WriteLine("4. Load the journal from a file");
    Console.WriteLine("5. Exit");
    Console.Write("Choose an option: ");
    string option = Console.ReadLine();

    if (option == "1")
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("response: ");
        string response = Console.ReadLine();
        Entry newEntry = new Entry
        {
            Date = DateTime.Now.ToString(),
            PromptText = prompt,
            EntryText = response
        };
        journal.AddEntry(newEntry);
    }

    else if (option == "2")
    {
        journal.DisplayAll();
    }

    else if (option == "3")
    {
        Console.Write("Enter the filename to save the journal: ");
        string saveFileName = Console.ReadLine();
        journal.SafeToFile(saveFileName);
    }

    else if (option == "4")
    {
        Console.Write("Enter the filename to load the journal: ");
        string loadFileName = Console.ReadLine();
        journal.LoadFromFile(loadFileName);
    }
    else if (option == "5")
    {
        exit = true;
    }
    else
    {
        Console.WriteLine("Invalid option! Please choose a valid option.");
    }
}





