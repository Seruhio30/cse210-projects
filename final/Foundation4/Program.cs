using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Crear instancias de diferentes actividades
        List<Activity> activities = new List<Activity>
        {
            new Running { Date = DateTime.Now, DurationMinutes = 30, Distance = 3.0M },
            new StationaryBike { Date = DateTime.Now.AddDays(-1), DurationMinutes = 45, Speed = 20 },
            new Swimming { Date = DateTime.Now.AddDays(-2), DurationMinutes = 60, Laps = 20 }
        };

        // Mostrar resúmenes de las actividades
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
