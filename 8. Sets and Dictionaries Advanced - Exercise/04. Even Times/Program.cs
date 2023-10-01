using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<double, int> dict = new Dictionary<double, int>();
            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                if (!dict.ContainsKey(input))
                {
                    dict.Add(input, 1);
                }
                else
                {
                    dict[input] ++;
                }

            }
            foreach (var item in dict)
            {
                if(item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Value);
                    break;
                }
                // 20/100
            }
        }
    }
}
