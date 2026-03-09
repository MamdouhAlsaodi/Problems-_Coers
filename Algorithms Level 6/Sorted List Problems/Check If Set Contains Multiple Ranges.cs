using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Level_6.Sorted_List_Problems
{
    internal class Check_If_Set_Contains_Multiple_Ranges
    {
        static bool ContainsAllRanges(SortedSet<int> set, List<(int, int)> ranges)
        {
            foreach (var (low, high) in ranges)
            {
                var range = set.GetViewBetween(low, high);
                if (range.Count != (high - low + 1))
                    return false;
            }
            return true;
        }

        //static void Main()
        //{
        //    SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5 };
        //    var ranges = new List<(int, int)> { (1, 2), (4, 5) };
        //    Console.WriteLine(ContainsAllRanges(set, ranges)); // Output: True
        //    Console.ReadKey();
        //}
    }
}
