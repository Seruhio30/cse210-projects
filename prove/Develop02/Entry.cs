public class Entry
{
    public Entry()
    {
    }

    public string Date { get; set; }
    public string PromptText { get; set; }
    public string EntryText { get; set; }


    public void Display()
    {
        Console.WriteLine($"Date: {Date}, Prompt: {PromptText}, Entry: {EntryText}");
    }

}