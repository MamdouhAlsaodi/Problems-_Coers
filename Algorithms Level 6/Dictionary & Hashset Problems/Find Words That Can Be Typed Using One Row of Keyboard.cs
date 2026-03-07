using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Level_6.Dictionary___Hashset_Problems
{
    internal class Find_Words_That_Can_Be_Typed_Using_One_Row_of_Keyboard
    {
        static string[] FindWords(string[] words)
        {
            string[] rows = { "qwertyuiop", "asdfghjkl", "zxcvbnm" };
            Dictionary<char, int> charRow = new Dictionary<char, int>();


            for (int i = 0; i < rows.Length; i++)
            {
                foreach (char c in rows[i])
                {
                    charRow[c] = i;
                }
            }


            List<string> result = new List<string>();


            foreach (string word in words)
            {
                int row = charRow[char.ToLower(word[0])];
                bool isValid = true;


                foreach (char c in word)
                {
                    if (charRow[char.ToLower(c)] != row)
                    {
                        isValid = false;
                        break;
                    }
                }


                if (isValid)
                    result.Add(word);
            }


            return result.ToArray();
        }


        //static void Main()
        //{
        //    string[] words = { "Hello", "Alaska", "Dad", "Peace" };
        //    Console.WriteLine(string.Join(", ", FindWords(words))); // Output: "Alaska, Dad"
        //    Console.ReadKey();


        //}
    }
}
