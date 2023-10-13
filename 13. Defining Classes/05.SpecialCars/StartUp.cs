using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManifacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire> tire = new List<Tire>();
            List<Engine> engine = new List<Engine>();
            List<Car> car = new List<Car>();
            string command = Console.ReadLine();
            while(true)
            {
                command = Console.ReadLine();
                if(command != "No more tires")
                {
                    int t = 0;
                    List<string> list =command.Split().ToList();

                    for(int i = 0; i <= 3; i++)
                    {
                        int year = int.Parse(list[t]);
                        t++;
                        double pressure = double.Parse(list[t]);
                        //2 2.6 3 1.6 2 3.6 3 1.6
                        tire.Add(new Tire(year, pressure));
                        t++;
                    }
                }
                else
                {
                    break;
                }
            }

            while (true)
            {
                command = Console.ReadLine();
                if (command != "Engines done")
                {
                    List<string> list = command.Split().ToList();
                    int horsePower = int.Parse(list[0]);
                    double cubicCapacity = double.Parse(list[1]);

                    engine.Add(new Engine(horsePower, cubicCapacity));

                }
                else
                {
                    break;
                }
            }


            while (true)
            {
                command = Console.ReadLine();
                if (command != "Show special")
                {
                    List<string> list = command.Split().ToList();
                    string make = list[0];
                    string model = list[1];
                    int year = int.Parse(list[2]);
                    double fuelQuantity = double.Parse(list[3]);
                    double fuelConsumption = double.Parse(list[4]);
                    int engineIndex = int.Parse(list[5]);
                    int tiresIndex = int.Parse(list[6]);
                        
                    car.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, engine[engineIndex], tire[tiresIndex] ));
                }
                else
                {
                    break;
                }
            }

List<Car> sortedCar = car.Where(c => c.Year >= 2017).ToList();

            foreach (var cared in sortedCar)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Make: {cared.Make}");
                sb.AppendLine($"Model: {cared.Model}");
                sb.AppendLine($"Year: {cared.Year}");
                sb.AppendLine($"HorsePowers: {cared.Engine.HorsePower}");
                sb.AppendLine($"Fuel: {cared.FuelQuantity:f2}");
            }
        }
    }
}
