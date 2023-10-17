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

while (water.Any() || flour.Any()) //?
{
    decimal currFlour = flour.Pop();
    decimal currWater = water.Dequeue();
    decimal waterPerc = currWater / (currFlour + currWater) * 100;
    decimal flourPerc = currFlour / (currFlour + currWater) * 100;

    if (currWater == 50 && currFlour == 50)
    {
        croissant++;
    }
    else if (currWater == 40 && currFlour == 60)
    {
        muffin++;
    }
    else if (currWater == 30 && currFlour == 70)
    {
        baugette++;
    }
    else if (currWater == 20 && currFlour == 80)
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