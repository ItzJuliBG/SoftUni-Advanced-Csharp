using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Stack<string> stack = new Stack<string>(Console.ReadLine().Split());
            Stack<string> stack2 = new Stack<string>();
            while(stack.Count > 0)
            {
                stack2.Push(stack.Pop());
            }
          
            int sum = 0;

            while(stack.Count > 0)
            {
                var firstNum = int.Parse(stack2.Pop());
                Console.WriteLine(firstNum);
                string action = stack.Pop();
                if (action == "+")
                {
                 sum += firstNum;
                }
                else if (action == "-")
                {
                  sum -= firstNum;
                }

            }
            Console.WriteLine(sum);
        }
    }
}
