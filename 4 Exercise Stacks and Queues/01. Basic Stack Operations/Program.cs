using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int stackLength = input[0];
            int toRemove = input[1];
            int numberToSearch = input[2];

            int[] numberList = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < stackLength; i++)
            {
                stack.Push(numberList[i]);
            }

            for (int i = toRemove - 1; i >= 0; i--)
            {
                stack.Pop();
            }
            //foreach (var t in stack)
            //{
            //    Console.WriteLine(t);
            //}

            if(stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if(stack.Contains(numberToSearch))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
