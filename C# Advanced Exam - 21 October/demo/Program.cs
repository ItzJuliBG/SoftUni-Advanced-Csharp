internal class Program
{
    private static void Main(string[] args)
    {
        Stack<int> fuel = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
        Queue<int> consumption = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
        Queue<int> fuelNeeded = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
        int currentAltitude = 0;
        bool IsGoalReached = true;
        Dictionary<int, string> altitudeReached = new();

        while (fuel.Any() && consumption.Any())
        {
            int currentConsumption = consumption.Dequeue();
            int currentFuel = fuel.Pop();
            int needOfFuel = fuelNeeded.Dequeue();
            if (currentFuel-currentConsumption >= needOfFuel)
            {
                currentAltitude++;
                altitudeReached.Add(currentAltitude, "Altitude");
                Console.WriteLine($"John has reached: Altitude {currentAltitude}");
            }
            else
            {
                IsGoalReached = false;
                break;
            }
        }
        if (!IsGoalReached)
        {
            if (currentAltitude > 0)
            {
                Console.WriteLine($"John did not reach: Altitude {currentAltitude + 1}");
                Console.WriteLine("John failed to reach the top.");
                Console.WriteLine($"Reached altitudes: {string.Join(", ", altitudeReached.Select(x => x.Value + " " + x.Key).ToArray())}");
            }
            else
            {
                Console.WriteLine($"John did not reach: Altitude 1");
                Console.WriteLine("John failed to reach the top.");
                Console.WriteLine("John didn't reach any altitude.");
            }
        }
        else
        {
            Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
        }
    }
}