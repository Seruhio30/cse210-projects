public class ListingActivity : Activity
{

    private int _count;
    private List<string> _prompts = new List<string>
    {
       " Who are people that you appreciate?",
       " What are personal strengths of yours?",
       " Who are people that you have helped this week?",
       " When have you felt the Holy Ghost this month?",
       " Who are some of your personal heroes?",
    };


    public ListingActivity(string name, string description) : base(name, description)
    {

    }


    public void Run()
    {

        DisplayStartingMessage();
        Thread.Sleep(2);
        Console.WriteLine("Get Ready...");
        howSpinner(3);
        Console.WriteLine("List as many responses you can to the following prompt");
        howSpinner(4);//cambiar el tiempo a 60 segunos
        Console.WriteLine();
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine(randomPrompt);

        Console.WriteLine();
        Console.Write("You may begin in: ");
        howCountDown(5);
        GetListFromUser();
        Console.WriteLine("Well done :)");
        howSpinner(5);
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

    public static List<string> GetListFromUser()
    {
        List<string> list = new List<string>();
        int count = 0;

        Console.WriteLine("Enter your responses (press Enter after each response, leave empty to finish):");

        string response;
        do
        {
            Console.Write("> "); // Imprime el símbolo ">" antes de cada entrada del usuario
            response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                list.Add(response);
                count++; // Incrementar el contador por cada respuesta válida
            }
        } while (!string.IsNullOrWhiteSpace(response));

        Console.WriteLine($"You made {count} responses."); // Mostrar el mensaje con el contador
        return list;
    }


}