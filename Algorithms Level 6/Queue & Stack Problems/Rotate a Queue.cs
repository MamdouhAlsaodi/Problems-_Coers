using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Level_6.Queue___Stack_Problems
{
    internal class Rotate_a_Queue
    {
        static Queue<int> RotateQueue(Queue<int> queue, int k)
        {
            for (int i = 0; i < k; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }
            return queue;
        }


        //static void Main()
        //{
        //    Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5 });
        //    Queue<int> rotatedQueue = RotateQueue(queue, 3);
        //    Console.WriteLine(string.Join(", ", rotatedQueue)); 
        //    Console.ReadKey();
        //}
    }
}
