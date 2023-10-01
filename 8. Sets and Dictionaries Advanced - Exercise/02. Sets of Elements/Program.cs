using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();
            int n = nM[0];
            int m = nM[1];

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                first.Add(input);
            }
            for (int i = 0;i < m; i++)
            {
                int input = int.Parse(Console.ReadLine());
                second.Add(input);
            }
            List<int> list = first.Where( x => second.Contains(x)).ToList();
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
