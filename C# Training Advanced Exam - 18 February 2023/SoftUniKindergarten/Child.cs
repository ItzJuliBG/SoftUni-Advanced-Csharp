using System.Collections.Generic;
using System.Text;
using System;

namespace SoftUniKindergarten
{
    public class Child
    {


        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }
        public string ParentName { get; }
        public string ContactNumber { get; }

        public Child(string firstName, string lastName, int age, string parentName, string contactNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            ParentName = parentName;
            ContactNumber = contactNumber;
        }

        public override string ToString()
        {
            return $"Child: {FirstName} {LastName}, Age: {Age}, Contact info: {ParentName} - {ContactNumber}";
        }
    }

    public class Kindergarten
    {
        private List<Child> registry;

        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            registry = new List<Child>();
        }

        public string Name { get; }
        public int Capacity { get; }

        public int ChildrenCount => registry.Count;

        public bool AddChild(Child child)
        {
            if (ChildrenCount < Capacity)
            {
                registry.Add(child);
                return true;
            }

            return false;
        }

        public bool RemoveChild(string childFullName)
        {
            Child childToRemove = registry.FirstOrDefault(c => $"{c.FirstName} {c.LastName}" == childFullName);

            if (childToRemove != null)
            {
                registry.Remove(childToRemove);
                return true;
            }

            return false;
        }

        public Child GetChild(string childFullName)
        {
            return registry.FirstOrDefault(c => $"{c.FirstName} {c.LastName}" == childFullName);
        }

        public string RegistryReport()
        {
            var sortedChildren = registry
                .OrderByDescending(c => c.Age)
                .ThenBy(c => c.LastName)
                .ThenBy(c => c.FirstName)
                .Select(c => c.ToString());

            var report = new StringBuilder();
            report.AppendLine($"Registered children in {Name}:");
            report.Append(string.Join(Environment.NewLine, sortedChildren));

            return report.ToString();
        }
    }
}
