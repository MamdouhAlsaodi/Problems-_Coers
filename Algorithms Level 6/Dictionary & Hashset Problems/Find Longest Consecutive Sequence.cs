using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Level_6.Dictionary___Hashset_Problems
{
    internal class Find_Longest_Consecutive_Sequence
    {
        static int LongestConsecutive(int[] nums)
        {
            HashSet<int> set = new HashSet<int>(nums);
            int longestStreak = 0;


            foreach (int num in set)
            {
                if (!set.Contains(num - 1))
                {
                    int currentNum = num;
                    int currentStreak = 1;


                    while (set.Contains(currentNum + 1))
                    {
                        currentNum++;
                        currentStreak++;
                    }


                    longestStreak = Math.Max(longestStreak, currentStreak);
                }
            }


            return longestStreak;
        }

        //static void Main()
        //{
        //    int[] nums = { 100, 4, 200, 1, 3, 2,101, 102,103,104, 105 };
        //    Console.WriteLine(LongestConsecutive(nums)); // Output: 6
        //    Console.ReadKey();
        //}
    }
}
