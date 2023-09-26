using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {

//7
//John 5.20
//Maria 5.50
//John 3.20
//Maria 2.50 Sam 2.00
//Maria 3.46
//Sam 3.00

            Dictionary<string, List<decimal>> collection = new Dictionary<string, List<decimal>>();
            int studentsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentsCount; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                if (collection.ContainsKey(input[0]))
                {
                    collection[input[0]].Add(decimal.Parse(input[1]));
                  
                }
                else
                {
                    collection[input[0]] = new List<decimal> { decimal.Parse(input[1]) };
                }
            }

            foreach (var item in collection)
            {
                decimal averageGrade = item.Value.Average();
                Console.WriteLine($"{item.Key} -> {string.Join(" ", item.Value)} (avg: {averageGrade:f2})");
            }
            // 50/100
        }
    }
}
