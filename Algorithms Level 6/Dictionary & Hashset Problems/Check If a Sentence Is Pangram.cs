using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Level_6.Dictionary___Hashset_Problems
{
    internal class Check_If_a_Sentence_Is_Pangram
    {
        static bool IsPangram(string sentence)
        {
            HashSet<char> letters = new HashSet<char>();


            foreach (char c in sentence.ToLower())
            {
                if (char.IsLetter(c))
                    letters.Add(c);
            }

            return letters.Count == 26;
        }

        //static void Main()
        //{
        //    string sentence = "The quick brown fox jumps over the lazy dog";
        //    Console.WriteLine(IsPangram(sentence)); // Output: True
        //    Console.ReadKey();
        //}
    }
}
