using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-2.5 4 3 -2.5 -5.5 4 3 3 -2.5 3
            Dictionary<double, int> dict = new Dictionary<double, int>();
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();

            foreach (int i in input)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i]++;
                }
                else
                {
                    dict.Add(i, 1);
                }
            }
            foreach (var t in dict)
            {
                Console.WriteLine($"{t.Key} - {t.Value} times");
            }
        }
    }
}
