using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Level_6.Dictionary___Hashset_Problems
{
    internal class Find_All_Unique_Elements
    {
        static List<int> FindUniqueElements(int[] nums)
            {
                Dictionary<int, int> counts = new Dictionary<int, int>();
                List<int> unique = new List<int>();


                foreach (int num in nums)
                {
                    if (!counts.ContainsKey(num))
                        counts[num] = 0;


                    counts[num]++;
                }


                foreach (var kvp in counts)
                {
                    if (kvp.Value == 1)
                        unique.Add(kvp.Key);
                }


                return unique;
            }

            //static void Main()
            //{
            //    int[] nums = { 1, 2, 2, 3, 4, 5, 3 };
            //    Console.WriteLine(string.Join(", ", FindUniqueElements(nums))); // Output: 1, 4, 5
            //    Console.ReadKey();
            //}
    }
}
