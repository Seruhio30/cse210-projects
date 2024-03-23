public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }


    public void Run()
    {

        DisplayStartingMessage();

        //howSpinner(5); // Simular el spinner durante 5 segundos
        Console.WriteLine("Get Ready...");
        //Thread.Sleep(3000); // Pausa de 3 segundos antes de respirar
        howSpinner(5);
        Console.WriteLine();
        int totalTime = 0; // Variable para rastrear el tiempo total de actividad

        // Bucle para repetir hasta que se alcance la duración total
        while (totalTime < _duration)
        {

            Console.Write($"Breathe in...");
            howCountDown(5); // Cuenta regresiva para inhalar durante 5 segundos
            totalTime += 5; // Añadir 5 segundos al tiempo total
            Console.WriteLine();
            Console.Write($"Breathe out...");
            howCountDown(4); // Cuenta regresiva para exhalar durante 4 segundos
            totalTime += 4; // Añadir 4 segundos al tiempo total
            Console.WriteLine();


        }
        howSpinner(5);
        Console.WriteLine();
        // Al finalizar la actividad, mostrar el mensaje de finalización
        DisplayEndingMessage();
        Console.WriteLine();

        howSpinner(5);

    }
}
