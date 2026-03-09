using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Level_6.Sorted_List_Problems
{
    internal class Count_Elements_Greater_Than_a_Value
    {
        static int CountGreaterThan(SortedSet<int> set, int value)
        {
            return set.GetViewBetween(value + 1, int.MaxValue).Count;
        }

        //static void Main()
        //{
        //    SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5 ,6};
        //    int value = 3;
        //    Console.WriteLine(CountGreaterThan(set, value)); // Output: 3
        //    Console.ReadKey();
        //}
    }
}
