using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Level_6.Dictionary___Hashset_Problems
{
    internal class Find_Missing_Number_in_an_Array
    {
        static int FindMissingNumber(int[] nums)
        {
            HashSet<int> set = new HashSet<int>(nums);
            int n = nums.Length;


            for (int i = 0; i <= n; i++)
            {
                if (!set.Contains(i))
                    return i;
            }

            return -1;
        }

        //static void Main()
        //{
        //    int[] nums = { 3,2, 0, 1, 5 };
        //    Console.WriteLine(FindMissingNumber(nums)); // Output: 4
        //    Console.ReadKey();

        //}
    }
}
