using System;
using System.Threading;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {

        // Swag
        string[] colors = { "Red", "Green", "Yellow", "Blue", "Magenta", "Cyan" };
        Random random = new Random();
        string swag_color = colors[random.Next(0, colors.Length)];

        // Input
        Write("Inserisci la stringa da tradurre: ");
        string message = Console.ReadLine();

        // C++
        Console.ForegroundColor = ConsoleColor.Red;
        string cpp_translation = "cout << \"" + message.Replace("\"", "\\\"") + "\" << endl;";
        string cpp_color = colors[random.Next(0, colors.Length)];
        WriteLine(ConsoleColor.Red + "C++: " + (cpp_translation));
        Console.ResetColor();

    }
}
