using System;

namespace FishingNet
{
    public class Fish
    {
        public string FishType { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }
        public Fish()
            
        {
           

        }
        public Fish(string fishType, double length, double weight)
            :this()
        {
            FishType = fishType;
            Length = length;
            Weight = weight;
        }

        public override string ToString()
        {
            return ($"There is a {FishType}, {Length:f2} cm. long, and {Weight:f2} gr. in weight.");
        }
    }
}
