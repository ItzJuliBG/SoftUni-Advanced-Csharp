using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            Name = name;
            this.Age = age;
        }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

    }
}
