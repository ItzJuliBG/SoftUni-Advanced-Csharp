using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Person
    {
        public Person()
        {
            Name = "No name";
            Age = 1;
        }
        public Person(int age)
            : this()
        {
            Age = age;
        }
        public Person(int age, string name)
            : this(age)
        {
            Person person = new Person()
            {
                Name = name,
                Age = age,
            };
        }
        private string Name;
        private int Age;

    }
}
