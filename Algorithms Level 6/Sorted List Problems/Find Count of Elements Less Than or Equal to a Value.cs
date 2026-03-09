using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Level_6.Sorted_List_Problems
{
    internal class Find_Count_of_Elements_Less_Than_or_Equal_to_a_Value
    {
        static int CountLessThanOrEqual(SortedSet<int> set, int value)
        {
            return set.GetViewBetween(int.MinValue, value).Count;
        }

        //static void Main()
        //{
        //    SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5 };
        //    Console.WriteLine(CountLessThanOrEqual(set, 3)); // Output: 3
        //    Console.ReadKey();
        //}
    }
}
