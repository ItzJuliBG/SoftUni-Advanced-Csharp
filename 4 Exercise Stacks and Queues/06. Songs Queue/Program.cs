using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A song cannot be added, if it is currently in the queue.
            // There might be commands even after there are no songs in the queue (ignore them).
            Queue<string> queue = new Queue<string>(Console.ReadLine().Split(", "));

            //current input: All Over Again, Watch Me
            //            Play
            //            Add Watch Me
            //Add Love Me Harder
            //Add Promises
            //Show
            //Play
            //Play
            //Play
            //Play

            //needed output: Watch Me is already contained!
//            Watch Me, Love Me Harder, Promises
//No more songs!

            while (queue.Any())
            {
                string[] input = Console.ReadLine().Split();
                string cmd = input[0];
                if(cmd == "Play")
                {
                    queue.Dequeue();
                }
                else if (cmd == "Add")
                {
                    string songToAdd = string.Join(" ", input.Skip(1));
                    if (queue.Contains(songToAdd))
                    {
                        // input[1] is only the first word of the song
                        Console.WriteLine($"{songToAdd} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(songToAdd);
                    }
                }
                else if (cmd == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
