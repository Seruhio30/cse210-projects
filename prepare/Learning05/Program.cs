using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 3);
        Console.WriteLine("color:" + square.GetColor());
        Console.WriteLine("Area:" + square.GetArea());

    }
}