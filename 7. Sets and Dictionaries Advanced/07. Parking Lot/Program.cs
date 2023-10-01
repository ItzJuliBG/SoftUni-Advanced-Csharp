using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string cmd = Console.ReadLine();
            HashSet<string> set = new HashSet<string>();
            while(cmd!= "END")
            {
                string[] input = cmd.Split(", ").ToArray();

                if (input[0] == "IN")
                {
                    set.Add(input[1]);
                }
                else
                {
                    set.Remove(input[1]);
                }


                cmd = Console.ReadLine();
            }
            if(set.Any())
            {
                foreach(string s in set)
                {
                    Console.WriteLine(s);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
