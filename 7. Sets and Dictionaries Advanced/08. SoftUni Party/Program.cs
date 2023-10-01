
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> regular = new HashSet<string>();
            HashSet<string> vip = new HashSet<string>();
            string input = Console.ReadLine();
            while (input!= "PARTY")
            {
                if (Char.IsDigit(input[0]))
                {
                    vip.Add(input);
                }
                else
                {
                    regular.Add(input);
                }

                input = Console.ReadLine();
            }
            
            while((input =  Console.ReadLine())!= "END")
            {
                if (Char.IsDigit(input[0]))
                {
                    vip.Remove(input);
                }
                else
                {
                    regular.Remove(input);
                }
            }
            Console.WriteLine(vip.Count+regular.Count);
            if(vip.Any() )
            {
                foreach (var item in vip)
                {
                    Console.WriteLine(item);
                }
            }
            if(regular.Any() )
            {
                foreach (var item in regular)
                {
                    Console.WriteLine(item);
                }
            }
            
        }
    }
}
