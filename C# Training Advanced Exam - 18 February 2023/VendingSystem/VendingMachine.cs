using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingSystem
{
    public class VendingMachine
    {
        public int ButtonCapacity { get; set; }
        public List<Drink> Drinks { get; set; }
        public VendingMachine(int buttonCapacity)
        {
            Drinks = new List<Drink>();
            ButtonCapacity = buttonCapacity;
        }
        public int GetCount()
        {
            return Drinks.Count; // Fixed the method call
        }
        public void AddDrink(Drink drink)
        {
            if (ButtonCapacity >= Drinks.Count + 1)
            {
                Drinks.Add(drink);
            }
        }
        public bool RemoveDrink(string name)
        {
            if (Drinks.Any(d => d.Name == name))
            {
                Drink drinkToRemove = Drinks.FirstOrDefault(d => d.Name == name);
                Drinks.Remove(drinkToRemove);
                return true;
            }
            return false;
        }
        public Drink GetLongest()
        {
            int maxLength = Drinks.Max(d => d.Volume);
            Drink longestDrink = Drinks.FirstOrDefault(d => d.Volume == maxLength);
            return longestDrink;
        }
        public Drink GetCheapest()
        {
            decimal cheapest = Drinks.Min(d => d.Price);
            Drink cheapestDrink = Drinks.FirstOrDefault(d => d.Price == cheapest);
            return cheapestDrink;
        }
        public string BuyDrink(string name)
        {
            Drink drinkToFind = Drinks.FirstOrDefault(x => x.Name == name);
            return drinkToFind.ToString();
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Drinks available:");
            {
                foreach (Drink drink in Drinks)
                    sb.AppendLine(drink.ToString());
            }
            return sb.ToString();
        }
    }
}
