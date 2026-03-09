using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Level_6.Sorted_List_Problems
{
    internal class Find_All_Elements_Not_in_a_Range
    {
        static IEnumerable<int> ElementsNotInRange(SortedSet<int> set, int low, int high)
        {
            var range = set.GetViewBetween(low, high);
            SortedSet<int> result = new SortedSet<int>(set);
            result.ExceptWith(range);
            return result;
        }

        //static void Main()
        //{
        //    SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5 };
        //    var result = ElementsNotInRange(set, 2, 4);
        //    Console.WriteLine(string.Join(", ", result)); // Output: 1, 5
        //    Console.ReadKey();

        //}
    }
}
