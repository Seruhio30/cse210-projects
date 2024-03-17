using System;

class Program
{
    static void Main(string[] args)
    {
        //call to scriptureLibrary
        var scriptureLibrary = new ScriptureLibrary();

        //Call an additional class where I create a library with 4 scriptures that change every time it initializes to learn a scripture.
        var scripture = scriptureLibrary.GetRandomScripture();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("Press Enter to continue or type 'exit' to quit.");
            var input = Console.ReadLine();


            if (input.ToLower() == "exit")
                break;

            //Hide a random word in each iteration
            scripture.HideRandomWords(1);

            if (scripture.IsCompletelyHidden())
            {

                Console.WriteLine("GOOD JOB, YOU LEARN ALL THE SCRIPTURE");
                break;
            }
        }
    }
}
