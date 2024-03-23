using System;

public class ReflectingActivity : Activity
{
    private List<string> _originalQuestions;

    public ReflectingActivity(string name, string description) : base(name, description)
    {
        _originalQuestions = new List<string>(_questions);
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
        // Initial message
        DisplayStartingMessage();
        Thread.Sleep(2);
        Console.WriteLine("Get Ready...");
        howSpinner(3);
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        // Random prompt
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue");
        Console.WriteLine();
        // The loop here continues until the Enter key is pressed.
        while (Console.ReadKey().Key != ConsoleKey.Enter)
        { }
        Console.WriteLine("Now ponder each of the following questions as they relate to this experience");

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
        howSpinner(3);
        Console.WriteLine();
        DisplayEndingMessage();
        howSpinner(3);
        Console.WriteLine();
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
        string selectedQuestion = _questions[electedQuestion];
        _questions.RemoveAt(electedQuestion); // Remove the selected question from the list
        if (_questions.Count == 0)
        {
            // If the list is empty, reset it so that questions can be selected again
            _questions.AddRange(_originalQuestions);
        }
        return selectedQuestion;
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
