using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                int[] value = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int cmd = value[0];
                //switch (value[0])
                //{
                //    case '1':
                //        stack.Push(value[1]);
                //        break;
                //    case '2':
                //        stack.Pop();
                //        break;
                //    case '3':
                //        Console.WriteLine(stack.Max());
                //        break;
                //    case '4':
                //        Console.WriteLine(stack.Min());
                //        break;
                //}
                if (cmd == 1)
                {
                    stack.Push(value[1]);
                }
                else if (cmd == 2)
                {
                    stack.Pop();
                }
                else if (cmd == 3 && stack.Any())
                {
                    Console.WriteLine(stack.Max());
                }
                else if (cmd == 4 && stack.Any())
                {
                    Console.WriteLine(stack.Min());
                }
            }
          
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
