using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> dict = new SortedDictionary<char, int>();

            foreach (char c in input) 
            {
                if (!dict.ContainsKey(c))
                {
                    dict.Add(c, 1);
                }
                else
                {
                    dict[c]++;
                }
            }

            foreach (var c in dict)
            {
                Console.WriteLine($"{c.Key}: {c.Value} time/s");
            }
        }
    }
}
