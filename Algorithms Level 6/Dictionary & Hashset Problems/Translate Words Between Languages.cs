using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Level_6.Dictionary___Hashset_Problems
{
    internal class Translate_Words_Between_Languages
    {
        static void Main()
        {
            Dictionary<string, string> translations = new Dictionary<string, string>
        {
            { "Hello", "Hola" },
            { "World", "Mundo" },
            { "Goodbye", "Adios" }
        };

            Console.WriteLine($"Hello in Spanish: {translations["Hello"]}");
            Console.WriteLine($"Goodbye in Spanish: {translations["Goodbye"]}");
            Console.ReadKey();
            // Output:
            // Hello in Spanish: Hola
            // Goodbye in Spanish: Adiós
        }
    }
}
