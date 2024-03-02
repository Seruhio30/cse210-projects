using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userN = -1;

        while (userN != 0)
        {
            Console.WriteLine("Enter a number or (enter '0' to stop)");
            string userIn = Console.ReadLine();
            userN = int.Parse(userIn);

            if (userN != 0)
            {
                numbers.Add(userN);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        //average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //max number

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {

                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}
