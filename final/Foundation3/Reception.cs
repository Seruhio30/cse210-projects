public class Reception : Event
{
    public string ConfirmationEmail { get; set; }

    // Overrides the method to generate a standard marketing message
    public override string GenerateStandardMarketingMessage()
    {
        return $"Join us at our {Title} reception on {Date.ToShortDateString()} at {Time}! Confirm your attendance at {ConfirmationEmail}";
    }
}