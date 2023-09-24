using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 4 8 6 3 8 7 7 9
            //16

            Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            int rackCapacity = int.Parse(Console.ReadLine());
            int currentRackCapacity = rackCapacity;
            int racksUsed = 1;

            while(stack.Any())
            {
                int clothPulled = stack.Pop();
                if(clothPulled > currentRackCapacity)
                {
                    stack.Push(clothPulled);
                    racksUsed++;
                    currentRackCapacity = rackCapacity;
                }
                else if (clothPulled == currentRackCapacity)
                {
                    currentRackCapacity = rackCapacity;
                    racksUsed++;
                }
                else
                {
                    currentRackCapacity -= clothPulled;
                }
            }
            Console.WriteLine(racksUsed); 

            // 80/100
        }
    }
}
