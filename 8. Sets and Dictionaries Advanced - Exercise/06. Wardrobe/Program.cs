using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ").ToArray(); 
                string color = input[0];
                string[] cloths = input[1].Split(",").ToArray();
                if(!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                foreach (var cloth in cloths)
                {
                    if (!wardrobe[color].ContainsKey(cloth))
                    {
                        wardrobe[color].Add(cloth, 1);
                    }
                    else
                    {
                        wardrobe[color][cloth]++;
                    }
                }               
            }

            string[] inpt = Console.ReadLine().Split().ToArray();
            string colorNeeded = inpt[0];
            string clothNeeded = inpt[1];

            foreach (var color in wardrobe) 
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var cloth in color.Value)
                {
                    if(colorNeeded == color.Key &&  clothNeeded == cloth.Key)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                    
                }
            }
        }
    }
}
