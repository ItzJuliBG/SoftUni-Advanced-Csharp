using System.Text;

namespace AutomotiveRepairShop
{
    public class RepairShop
    {
        public List<Vehicle> Vehicles { get; set; }
        public int Capacity { get; set; }

        public RepairShop(int capacity)
        {
            Capacity = capacity;
            Vehicles = new List<Vehicle>();
        }

       public void AddVehicle(Vehicle vehicle)
        {
            if(Capacity>= Vehicles.Count + 1) //?
            {
                Vehicles.Add(vehicle);
            }
        }

        public bool RemoveVehicle(string vin)
        {
            if(Vehicles.Any(v => v.VIN == vin)) 
            {
                Vehicle vehicleToRemove = Vehicles.FirstOrDefault(v => v.VIN == vin);
                Vehicles.Remove(vehicleToRemove);
                return true;
            }
            return false;
        }
        public int GetCount()
        {
            return Vehicles.Count;
        }
        public string GetLowestMileage()
        {
            int lowestMileage = Vehicles.Min(v => v.Mileage);
            Vehicle vehicleWithLowestMiles = Vehicles.FirstOrDefault(v => v.Mileage == lowestMileage);
         return ($"Damage: {vehicleWithLowestMiles.Damage}, Vehicle: {vehicleWithLowestMiles.VIN} ({vehicleWithLowestMiles.Mileage} km)");
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Vehicles in the preparatory:");
            foreach (var car in Vehicles)
            {
                sb.AppendLine($"Damage: {car.Damage}, Vehicle: {car.VIN} ({car.Mileage} km)");
            }
            return sb.ToString();
        }

    }
}
