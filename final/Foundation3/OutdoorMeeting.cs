public class OutdoorMeeting : Event
{
    public string WeatherForecast { get; set; }

    // Overrides the method to generate a brief marketing message
    public override string GenerateBriefMarketingMessage()
    {
        return $"{base.GenerateBriefMarketingMessage()} Weather forecast: {WeatherForecast}!";
    }
}