using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Level_6.Queue___Stack_Problems
{
    internal class First_Non_Repeating_Character_in_a_Stream
    {
        static void FindFirstNonRepeating(string stream)
        {
            Dictionary<char, int> countMap = new Dictionary<char, int>();
            Queue<char> queue = new Queue<char>();


            foreach (char ch in stream)
            {
                if (!countMap.ContainsKey(ch))
                    countMap[ch] = 0;


                countMap[ch]++;
                queue.Enqueue(ch);


                while (queue.Count > 0 && countMap[queue.Peek()] > 1)
                {
                    queue.Dequeue();
                }


                Console.WriteLine(queue.Count > 0 ? queue.Peek() : '-');
            }
        }

        //static void Main()
        //{
        //    FindFirstNonRepeating("aabc");
        //    // Output: a, -, b, c
        //    Console.ReadKey();
        //}
    }
}
