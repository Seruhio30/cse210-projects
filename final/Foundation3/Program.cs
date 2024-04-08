using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a conference
        var conference = new Conference
        {
            Title = "Digital Marketing Conference",
            Description = "Join us to learn about the latest trends in digital marketing.",
            Date = new DateTime(2024, 4, 15),
            Time = new TimeSpan(10, 0, 0),
            SpeakerName = "John Doe",
            Capacity = 100
        };

        // Create a reception
        var reception = new Reception
        {
            Title = "Welcome Reception",
            Description = "Come and join us for an evening of music and fun.",
            Date = new DateTime(2024, 4, 20),
            Time = new TimeSpan(19, 0, 0),
            ConfirmationEmail = "confirmation@company.com"
        };

        // Create an outdoor meeting
        var outdoorMeeting = new OutdoorMeeting
        {
            Title = "Company Picnic",
            Description = "We'll spend the day outdoors enjoying games and food.",
            Date = new DateTime(2024, 5, 1),
            Time = new TimeSpan(12, 0, 0),
            WeatherForecast = "sunny"
        };

        // Display marketing messages for each event
        Console.WriteLine("Marketing message for the conference:");
        Console.WriteLine(conference.GenerateFullMarketingMessage());
        Console.WriteLine();

        Console.WriteLine("Marketing message for the reception:");
        Console.WriteLine(reception.GenerateStandardMarketingMessage());
        Console.WriteLine();

        Console.WriteLine("Marketing message for the outdoor meeting:");
        Console.WriteLine(outdoorMeeting.GenerateBriefMarketingMessage());

    }
}