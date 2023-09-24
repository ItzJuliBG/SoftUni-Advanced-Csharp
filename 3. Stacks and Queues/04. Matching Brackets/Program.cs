using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Matching_Brackets
{
    internal class Program
    {
        //1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5 
        static void Main(string[] args)
        {
            string coll = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();

            foreach (char c in coll)
            {
                if(c == '(')
                {
                    indexes.Push(coll.IndexOf(c));
                }
                else if(c == ')')
                {
                    var t = coll.Substring(indexes.Pop(), coll.IndexOf(c));
                    Console.WriteLine(t);
                }
            }

        }
    }
}
