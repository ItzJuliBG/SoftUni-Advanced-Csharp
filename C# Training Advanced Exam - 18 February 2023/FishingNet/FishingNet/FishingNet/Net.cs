using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FishingNet
{
    public class Net
    {
        public List<Fish> Fish { get; set; }
        public string Material { get; set; }
        public int Capacity { get; set; }
        public int Count { get; set; }

        public Net(string material, int capacity)
        {
            Material = material;
            Capacity = capacity;
            Fish = new List<Fish>();
        }

        public string GetFish(Fish fish)
        {
            return ($"There is a trout, {fish.Length:f2} cm. long, and {fish.Weight:f2} gr. in weight.");
        }

        public string AddFish(Fish fish)
        {
            string space = " ";
            if (fish.FishType == null || fish.FishType == space)
            {
                return "Invalid fish.";
            }
            else if (fish.Weight <= 0 || fish.Length <= 0)
            {
                return "Invalid fish.";
            }
            else if (Capacity <= Count)
            {
                return "Fishing net is full.";
            }
            else
            {
                Fish.Add(fish);
                Count++;
                return $"Successfully added {fish.FishType} to the fishing net.";
            }
        }
        public bool ReleaseFish(double weight)
        {
            bool isExisting = false;
            Fish fishToRemove = null;
            foreach (Fish f in Fish)
            {
                if (f.Weight == weight)
                {
                    fishToRemove = f;
                    isExisting = true;
                }
            }
            if (isExisting)
            {
                Fish.Remove(fishToRemove);
                Count--;
                return true;
            }
            return false;
        }

        public Fish GetFish(string fishType)
        {
            Fish fishToReturn = Fish.FirstOrDefault(f => f.FishType == fishType);
            return fishToReturn;
        }

        public Fish GetBiggestFish()
        {
            var t = Fish.Max(f => f.Weight);
            return Fish.FirstOrDefault(cf => cf.Weight == t);
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Into the {Material}:");
            List<Fish> sortedFish = Fish.OrderByDescending(f=> f.Weight).ToList();
            foreach (Fish f in sortedFish)
            {
                sb.AppendLine($"There is a {f.FishType}, {f.Length:f2} cm. long, and {f.Weight:f2} gr. in weight.");
            }
            return sb.ToString();
        }
    }
}
