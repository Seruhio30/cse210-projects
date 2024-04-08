public class Event
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan Time { get; set; }
    public Address Address { get; set; }

    // Method to generate a standard marketing message
    public virtual string GenerateStandardMarketingMessage()
    {
        return $"Don't miss {Title} on {Date.ToShortDateString()} at {Time}!";
    }

    // Method to generate a full marketing message
    public virtual string GenerateFullMarketingMessage()
    {
        return $"We invite you to {Title} on {Date.ToShortDateString()} at {Time}. {Description}";
    }

    // Method to generate a brief marketing message
    public virtual string GenerateBriefMarketingMessage()
    {
        return $"Coming soon: {Title}!";
    }
}