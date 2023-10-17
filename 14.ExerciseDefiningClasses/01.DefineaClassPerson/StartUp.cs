using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>() 
            {
                new Person("Peter", 20),
                new Person("George", 18),
                new Person("Jose", 43),
            };
           

        }
    }
}
