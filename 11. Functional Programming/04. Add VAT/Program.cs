List<decimal> nums = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToList(); ;
decimal vat = 1.2m;
Func<decimal, decimal, decimal> vattAdder = (decimal x, decimal vat) => x = x*vat;


foreach (decimal x in nums)
{
    Console.WriteLine($"{vattAdder(x, vat):f2}"); 
}

