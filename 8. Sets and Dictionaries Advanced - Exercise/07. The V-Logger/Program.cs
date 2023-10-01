using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            Dictionary<string, CustomData> dict = new Dictionary<string, CustomData>();
            while (input[0] != "Statistics")
            {
                string vlogger = input[0];
                string action = input[1];
                string secondVlogger = input[2];
                if(action == "joined" && !dict.ContainsKey(vlogger))
                {

                    dict.Add(vlogger, new CustomData
                    {
                        Followers = 0,
                        Following = 0,
                        FollowerList = new List<string>()
                    });
                }
                else if (action == "followed" && dict.ContainsKey(vlogger)&& dict.ContainsKey(secondVlogger))
                {
                    if(vlogger!= secondVlogger && !dict[secondVlogger].FollowerList.Contains(vlogger))
                    {
                        dict[secondVlogger].Followers++;
                        dict[secondVlogger].FollowerList.Add(vlogger);
                        dict[vlogger].Following++;
                    }
                }
                input = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine($"The V-Logger has a total of {dict.Count} vloggers in its logs.");
            int count = 1;
            var sortedDict = dict.OrderByDescending(kv => kv.Value.Followers)   
                        .ThenBy(kv => kv.Value.Following)
                        .ToDictionary(kv => kv.Key, kv => kv.Value);

            Console.WriteLine($"{count}. {sortedDict.Keys.First()} : {sortedDict[sortedDict.Keys.First()].Followers} followers, {sortedDict[sortedDict.Keys.First()].Following} following");
            
            
            foreach(var kv in sortedDict[sortedDict.Keys.First()].FollowerList.OrderBy(x=> x)) 
            {
                Console.WriteLine($"*  {kv}");
            }

            //TODO: simplify the code

            foreach (var vlogger in sortedDict.Skip(1))
            {
                count++;
                Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value.Followers} followers, {vlogger.Value.Following} following");
            }
        }
        public class CustomData
        {
            public int Followers;
            public int Following;
            public List<string> FollowerList;
        }
    }
}
