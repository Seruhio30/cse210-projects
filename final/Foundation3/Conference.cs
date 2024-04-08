public class Conference : Event
{
    public string SpeakerName { get; set; }
    public int Capacity { get; set; }

    // Overrides the method to generate a full marketing message
    public override string GenerateFullMarketingMessage()
    {
        return $"{base.GenerateFullMarketingMessage()} Conference conducted by {SpeakerName}!";
    }
}