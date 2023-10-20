using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Registry = new();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Child> Registry { get; set; }
        public int ChildrenCount => Registry.Count;

        public bool AddChild(Child child)
        {
            if(Capacity >= Registry.Count+1)
            {
                Registry.Add(child);
                return true;
            }
            return false;
        }
        public bool RemoveChild(string childFullName) 
        {
            Child childToRemove = Registry.FirstOrDefault(c=> c.FirstName+" "+c.LastName==childFullName); //?
            if(childToRemove != null)
            {
                Registry.Remove(childToRemove);
                return true;
            }
            return false;
        }
        public Child GetChild(string childFullName)
        {
            Child childToReturn = Registry.FirstOrDefault(x=> x.FirstName+" "+x.LastName==childFullName);
            if(childToReturn != null)
            {
                return childToReturn;
            }
            return null;
        }
        public string RegistryReport()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Registered children in {Name}:");
            List<Child> children = Registry.OrderByDescending(x=> x.Age).ThenBy(x=>x.LastName).ThenBy(x=>x.FirstName).ToList();
            foreach (var child in children)
            {
                sb.AppendLine(child.ToString());
            }
            return sb.ToString();
        }
    }
}
