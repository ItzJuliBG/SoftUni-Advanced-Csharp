Queue<decimal> water = new Queue<decimal>();
Stack<decimal> flour = new Stack<decimal>();
List<decimal> input = Console.ReadLine().Split().Select(decimal.Parse).ToList();
foreach (var item in input)
{
    water.Enqueue(item);
}
input = Console.ReadLine().Split().Select(decimal.Parse).ToList();
foreach (var item in input)
{
    flour.Push(item);
}
int croissant = 0;
int muffin = 0;
int baugette = 0;
int bagel = 0;

while (water.Any() && flour.Any()) //?
{
    decimal currFlour = flour.Pop();
    decimal currWater = water.Dequeue();
    decimal waterPerc = currWater / (currFlour + currWater) * 100;
    decimal flourPerc = currFlour / (currFlour + currWater) * 100;

    if (waterPerc == 50 && flourPerc == 50)
    {
        croissant++;
    }
    else if (waterPerc == 40 && flourPerc == 60)
    {
        muffin++;
    }
    else if (waterPerc == 30 && flourPerc == 70)
    {
        baugette++;
    }
    else if (waterPerc == 20 && flourPerc == 80)
    {
        bagel++;
    }
    else
    {
        currFlour = currFlour / 2;
        flour.Push(currFlour);
    }


}
Console.WriteLine($"muffin {muffin}");
Console.WriteLine($"baguette {baugette}");
Console.WriteLine($"crossain {croissant}");

if (water.Any())
{
Console.WriteLine($"Water left: {string.Join(", ", water)}");
}
else
{
    Console.WriteLine("Water left: None");
}
if (flour.Any())
{
    Console.WriteLine($"Flour left: {string.Join(", ", flour)}");
}
else
{
    Console.WriteLine("Flour left: None");
}
//16.8 32.4 19.5 25
//15 30 45.5 48.6 25.2