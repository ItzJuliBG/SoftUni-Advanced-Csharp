using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> first = new Stack<char>();
            Stack<char> last = new Stack<char>();

            bool isCorrect = true;

            for (int i = 0; i < input.Length/2; i++)
            {
                first.Push(input[input.Length-i]);
                last.Push(input[i]);
            }


            while (last.Count >= input.Length/2)
            {
                char left = first.Pop();
                char right = last.Pop();
                if (left != right)
                {
                    isCorrect = false;
                }
            }
           if(isCorrect )
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
           
        }
    }
}
