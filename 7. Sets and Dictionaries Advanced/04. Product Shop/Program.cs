using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;

namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, decimal>> dict = new SortedDictionary<string, Dictionary<string, decimal>>();

            string command = Console.ReadLine();
            while(command != "Revision") 
            {
                string[] input = command.Split(", ").ToArray();
                string shop = input[0];
                string product = input[1];
                decimal price = decimal.Parse(input[2]);
                if(!dict.ContainsKey(shop) )
                {
                    dict.Add(shop, new Dictionary<string, decimal>());
                    
                }
                dict[shop].Add(product, price);

                command = Console.ReadLine();
            }
            foreach (var shop in dict)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value:f1}");
                }
            }
        }
    }
}
