using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SoftUniParking
{
    class Parking
    {
        private List<Car> cars;
        private int capacity;
        private int count;

        public Parking(int capacity)
        {
            count = 0;
            cars = new List<Car>();
            this.Capacity = capacity; //may be Capacity
        }

        public int Count { get => count; set => count = value; }
        public List<Car> Cars { get => cars; set => cars = value; }
        public int Capacity { get => capacity; set => capacity = value; }

        public string AddCar(Car car)
        {
            bool isExisted = cars.Any(c => c.RegistrationNumber == car.RegistrationNumber);
            if (isExisted)
            {
                return ("Car with that registration number, already exists!");
            }
            else if (cars.Count >= capacity)
            {
                return ("Parking is full!");
            }
            else
            {
                count++;
                cars.Add(car);
              return ($"Successfully added new car {car.Make} {car.RegistrationNumber}");
            }
        }
        public string RemoveCar(string registrationNumber)
        {
            if(!cars.Any(c => c.RegistrationNumber == registrationNumber))
            {
                return ("Car with that registration number, doesn't exist!");
            }
            else
            {
                Car carToRemove = cars.FirstOrDefault(c => c.RegistrationNumber == registrationNumber);
                cars.Remove(carToRemove);
                return ($"Successfully removed {registrationNumber}");
            }
        }
        public Car GetCar(string registrationNumber)
        {
            return cars.FirstOrDefault(c => c.RegistrationNumber == registrationNumber);
        }
        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            foreach(string registrationNumber in RegistrationNumbers)
            {
               Car carToRemove = cars.FirstOrDefault(c=> c.RegistrationNumber == registrationNumber);
                cars.Remove(carToRemove);
            }
        }
    }
}
