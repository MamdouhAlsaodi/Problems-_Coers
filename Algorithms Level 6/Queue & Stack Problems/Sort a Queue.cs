using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Level_6.Queue___Stack_Problems
{
    internal class Sort_a_Queue
    {
        static Queue<int> SortQueue(Queue<int> queue)
        {
            //this will generate a list from a queue
            List<int> list = new List<int>(queue);
            list.Sort();


            // this will generate a queue from list
            return new Queue<int>(list);
        }


        //static void Main()
        //{
        //    Queue<int> queue = new Queue<int>(new[] { 5, 1, 3, 2, 4 });
        //    Queue<int> sortedQueue = SortQueue(queue);
        //    Console.WriteLine(string.Join(", ", sortedQueue)); // Output: 1, 2, 3, 4, 5


        //    Console.ReadKey();
        //}
    }
}
