using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the guess game");
        Console.WriteLine("To play, you only need to enter a number from 1 to 100! Good luck :)");

        bool play = true;

        while (play)
        {
            bool response = false;
            int attempts = 0;

            while (!response)
            {
                Random magicNumber = new Random();
                int number = magicNumber.Next(1, 5);

                // Pide al usuario que ingrese su conjetura
                Console.WriteLine("What is your guess?");
                string userInput = Console.ReadLine();
                int guess = int.Parse(userInput);
                attempts++;

                if (guess == number)
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"Number of attempts: {attempts}");
                    response = true;
                }
                else if (guess > number)
                {
                    Console.WriteLine("Try a lower number");
                }
                else
                {
                    Console.WriteLine("Try a higher number");
                }
            }

            // Pregunta al usuario si desea jugar de nuevo
            Console.WriteLine("Do you want to play again? (Yes/No)");
            string respuesta = Console.ReadLine();

            if (respuesta.ToLower() != "yes")
            {
                play = false;
            }
        }
    }
}
