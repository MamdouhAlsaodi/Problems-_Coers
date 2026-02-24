using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Level_6.Queue___Stack_Problems
{
    internal class Evaluate_a_Postfix_Expression
    {
        static int EvaluatePostfix(string expression)
        {
            Stack<int> stack = new Stack<int>();


            foreach (char c in expression)
            {
                if (char.IsDigit(c))
                {
                    stack.Push(c - '0');
                }
                else
                {
                    int b = stack.Pop();
                    int a = stack.Pop();
                    switch (c)
                    {
                        case '+': stack.Push(a + b); break;
                        case '-': stack.Push(a - b); break;
                        case '*': stack.Push(a * b); break;
                        case '/': stack.Push(a / b); break;
                    }
                }
            }

            return stack.Pop();
        }

        //static void Main()
        //{
        //    Console.WriteLine(EvaluatePostfix("231*+9-")); // Output: -4
        //    Console.ReadKey();


        //}
    }
}
