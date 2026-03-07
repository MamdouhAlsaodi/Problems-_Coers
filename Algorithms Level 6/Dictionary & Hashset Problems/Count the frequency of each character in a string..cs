using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Level_6.Dictionary___Hashset_Problems
{
    internal class Count_the_frequency_of_each_character_in_a_string
    {
        static Dictionary<char, int> CharacterFrequency(string input)
        {
            Dictionary<char, int> frequency = new Dictionary<char, int>();


            foreach (char c in input)
            {
                if (frequency.ContainsKey(c))
                    frequency[c]++;
                else
                    frequency[c] = 1;
            }


            return frequency;
        }

        //static void Main()
        //{
        //    string input = "hello";
        //    var result = CharacterFrequency(input);
        //    foreach (var kvp in result)
        //    {
        //        Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        //    }
        //    Console.ReadKey();

        //}
    }
}
