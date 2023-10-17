using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
             List<Person> people = new List<Person>();

             Family family = new Family(people);

             for (int i = 0; i < n; i++)
             {
                 List<string> input = Console.ReadLine().Split().ToList();
                 string name = input[0];
                 int age = int.Parse(input[1]);
                 Person prsn = new Person(name, age);
                 family.AddMember(prsn);
             }

            family.GetOldestMember(family);
        }
    }
}
