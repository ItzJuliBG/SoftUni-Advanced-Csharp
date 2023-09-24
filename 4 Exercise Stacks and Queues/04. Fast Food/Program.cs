using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int currentQuantity = int.Parse(Console.ReadLine());
            bool isCompleted = true;
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            Console.WriteLine(queue.Max());

            while (queue.Count > 0)
            {
                int order = queue.Dequeue();
                if(currentQuantity-order < 0)
                {
                    queue.Enqueue(order);
                    isCompleted = false;
                    break;
                }
                currentQuantity -= order;   
            }
            if(isCompleted)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            } // 80/100
        }
    }
}
