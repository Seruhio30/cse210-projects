using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade porcentage?");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";
        string sing = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        //if is + or -
        int lastDigit = percent % 10;
        if (lastDigit >= 7)
        {
            sing = "+";
        }
        else if (lastDigit < 3 && letter != "F")
        {
            sing = "-";
        }

        //only A and A- and F be just F
        if (letter == "A" && sing == "+")
        {
            sing = "";
        }

        else if (letter == "F" && (sing == "+" || sing == "-"))
        {
            sing = "";
        }




        Console.WriteLine($"Your grade is {letter}{sing}");
        //if pass over 70 print a message
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("Don't worry, keep working hard for next time!");
        }

    }
}