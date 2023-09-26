using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).ToList();
            

            Console.WriteLine(string.Join(" ", list.Take(3)));
        }
    }
}
