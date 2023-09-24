using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
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
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < stackLength; i++)
            {
                queue.Enqueue(numberList[i]);
            }

            for (int i = toRemove - 1; i >= 0; i--)
            {
                queue.Dequeue();
            }
            //foreach (var t in stack)
            //{
            //    Console.WriteLine(t);
            //}

            if (queue.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if (queue.Contains(numberToSearch))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
