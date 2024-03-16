using System;

class Program
{
    static void Main(string[] args)
    {
        var reference = new Reference("Juan", 3, 16);
        var scripture = new Scripture(reference, "Porque de tal manera amó Dios al mundo, que ha dado a su Hijo unigénito, para que todo aquel que en él cree no se pierda, mas tenga vida eterna.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Presione Enter para continuar o escriba 'salir' para salir.");
            var input = Console.ReadLine();
            if (input.ToLower() == "salir")
                break;
            scripture.HideNextWord();
            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("Todas las palabras están ocultas. Juego terminado.");
                break;
            }
        }
    }
}
