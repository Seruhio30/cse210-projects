using System;

class Program
{
    static void Main(string[] args)
    {

        string name = UserName();
        int number = UserNumber();
        int square = UserSquare(number);
        LastCall(name, square);

    }

    static void WelcomeProgram()
    {
        Console.WriteLine("Wlcome to the program");
    }

    static string UserName()
    {
        Console.WriteLine("Please enter your name");
        return Console.ReadLine();
    }

    static int UserNumber()
    {
        Console.WriteLine("Please enter your favorite number");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int UserSquare(int number)
    {
        int square = number * number;
        return square;
    }

    static void LastCall(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }



}