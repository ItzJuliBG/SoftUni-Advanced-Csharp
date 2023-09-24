using System;
using System.Collections;
using System.Collections.Generic;

namespace _01._Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> stack = new Stack<int>();
            foreach (char c in input)
            {
                stack.Push(c);
            }
            foreach (var c in stack)
            {
                Console.Write(c);
            }
        }
    }
}
