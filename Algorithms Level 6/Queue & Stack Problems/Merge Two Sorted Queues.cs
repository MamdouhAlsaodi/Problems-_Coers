using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Level_6.Queue___Stack_Problems
{
    internal class Merge_Two_Sorted_Queues
    {
        static Queue<int> MergeQueues(Queue<int> q1, Queue<int> q2)
        {
            Queue<int> merged = new Queue<int>();


            while (q1.Count > 0 && q2.Count > 0)
            {
                if (q1.Peek() <= q2.Peek())
                    merged.Enqueue(q1.Dequeue());
                else
                    merged.Enqueue(q2.Dequeue());
            }


            while (q1.Count > 0)
            {
                merged.Enqueue(q1.Dequeue());
            }


            while (q2.Count > 0)
            {
                merged.Enqueue(q2.Dequeue());
            }


            return merged;
        }


        //static void Main()
        //{
        //    Queue<int> q1 = new Queue<int>(new[] { 1, 3, 5 });
        //    Queue<int> q2 = new Queue<int>(new[] { 2, 4, 6 });
        //    Queue<int> mergedQueue = MergeQueues(q1, q2);
        //    Console.WriteLine(string.Join(", ", mergedQueue)); // Output: 1, 2, 3, 4, 5, 6

        //    Console.ReadKey();

        //}
    }
}
