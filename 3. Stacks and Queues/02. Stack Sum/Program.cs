using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace _02._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray(); 
            foreach (int i in arr)
            {
                stack.Push(i);
            }


            while (true)
            {
                string inpt = Console.ReadLine();
                inpt = inpt.ToLower();
                if (inpt == "end")
                {
                    break;
                }
                string[] array = inpt.Split();
                string cmd = array[0];

                switch (cmd)
                {
                    case "add":
                        stack.Push(int.Parse(array[1]));
                        stack.Push(int.Parse(array[2]));
                        break;
                    case "remove":
                        if (stack.Count >= int.Parse(array[1]))
                        {
                            for (int i = 0; i < int.Parse(array[1]); i++)
                            {

                                stack.Pop();

                            }
                        }
                       
                        break;
                }
            }
            
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
