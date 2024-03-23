public class Activity
{

    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;

    }



    public void DisplayStartingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Welcome to the {_name} activity");
        Console.WriteLine();
        Console.WriteLine($"This activity will help you {_description}");
        Console.Write("How long, in seconds, would you like for your session: ");
        _duration = Convert.ToInt32(Console.ReadLine());



    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have completed another {_duration} seconds of {_name} activity");
    }

    public void howSpinner(int seconds)
    {
        List<string> spining = new List<string>();
        spining.Add("|");
        spining.Add("/");
        spining.Add("-");
        spining.Add("\\");
        spining.Add("|");
        spining.Add("/");
        spining.Add("-");
        spining.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        int i = 0;
        while (DateTime.Now < endTime)

        //foreach (string s in spining)
        {
            string s = spining[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
        }
    }

    public void howCountDown(int second)
    {
        for (int i = second; i > 0; i--)
        {
            Console.Write("\b");
            Console.Write(i);
            Thread.Sleep(1000);
        }
    }
}