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

    }

    public void GetRandomPrompt()
    {

    }

    static List<string> GetListFromUser()
    {
        List<string> list = new List<string>();
        return list;
    }

}