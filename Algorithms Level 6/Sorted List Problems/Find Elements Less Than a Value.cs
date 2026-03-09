using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Level_6.Sorted_List_Problems
{
    internal class Find_Elements_Less_Than_a_Value
    {
        static IEnumerable<int> ElementsLessThan(SortedSet<int> set, int value)
        {
            return set.GetViewBetween(int.MinValue, value - 1);
        }

        //static void Main()
        //{
        //    SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5 };
        //    int value = 4;
        //    Console.WriteLine(string.Join(", ", ElementsLessThan(set, value))); // Output: 1, 2, 3
        //    Console.ReadKey();

        //}
    }
}
