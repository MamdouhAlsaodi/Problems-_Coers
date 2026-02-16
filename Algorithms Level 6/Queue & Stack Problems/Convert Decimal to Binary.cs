using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Level_6.Queue___Stack_Problems
{
    internal class Convert_Decimal_to_Binary
    {

        static string DecimalToBinary(int number)
        {
            Stack<int> stack = new Stack<int>();

            while (number > 0)
            {
                stack.Push(number % 2);
                number /= 2;
            }

            return string.Join("", stack);
        }
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine(DecimalToBinary(10)); 
        //}
    }
}
