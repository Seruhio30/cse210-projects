public class Journal
{
    public List<Entry> _entries;


    public Journal()
    {
        _entries = new List<Entry>();

    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);

    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SafeToFile(string file)
    {

        using (StreamWriter outputFile = new StreamWriter(file, true))
        {
            foreach (Entry entry in _entries)
            {

                outputFile.WriteLine($"Date: {entry.Date}, Prompt: {entry.PromptText}, Entry: {entry.EntryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');

            if (parts.Length == 3)
            {
                string Date = parts[0].Trim();
                string Prompt = parts[1].Trim();
                string Entry = parts[2].Trim();

                Entry newEntry = new Entry
                {
                    Date = Date,
                    PromptText = Prompt,
                    EntryText = Entry
                };

                _entries.Add(newEntry);
            }
            else
            {
                Console.WriteLine($"Invalid line in file: {line}");
            }
        }
    }

}