using System;
public class ReflectingActivity : Activity
{

    public ReflectingActivity(string name, string description) : base(name, description)
    {

    }
    private List<string> _questions = new List<string>
    {
        ">Why was this experience meaningful to you?",
        ">Have you ever done anything like this before?",
        ">How did you get started?",
        ">How did you feel when it was complete?",
        ">What made this time different than other times when you were not as successful?",
        ">What is your favorite thing about this experience?",
        ">What could you learn from this experience that applies to other situations?",
        ">What did you learn about yourself through this experience?",
        ">How can you keep this experience in mind in the future?"
    };


    private List<string> _prompts = new List<string>
    {
        "---Think of a time when you stood up for someone else.---",
        "---Think of a time when you did something really difficult.---",
        "---Think of a time when you helped someone in need.---",
        "---Think of a time when you did something truly selfless.---",
    };

    public void Run()
    {
        //Mensage inicial
        DisplayStartingMessage();
        Thread.Sleep(2);
        Console.WriteLine("Get Ready...");
        howSpinner(3);
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        //ramdon prompt
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue");
        //The loop here continues until the Enter key is pressed. 
        while (Console.ReadKey().Key != ConsoleKey.Enter)
        { }
        Console.WriteLine("Now ponder of eachof the following questions as they related to this experience");

        Console.Write("You may begin in..");
        howCountDown(5);
        Console.WriteLine();
        DisplayQuestion();
        howSpinner(15);
        Console.WriteLine();
        DisplayQuestion();
        howSpinner(15);
        Console.WriteLine();
        Console.WriteLine("Well done :)");
        DisplayEndingMessage();
        howSpinner(3);

    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int electedPrompt = random.Next(_prompts.Count);
        return _prompts[electedPrompt];
    }

    public string GetRandomQuestion()
    {


        Random random = new Random();
        int electedQuestion = random.Next(_questions.Count);
        return _questions[electedQuestion];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.Write(prompt);
    }

    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.Write(question);
    }
}