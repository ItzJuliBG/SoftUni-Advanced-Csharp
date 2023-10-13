List<decimal> nums = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToList(); ;

Func<List<decimal>, List<decimal>> addVat =(nums) =>
{
    List<decimal> vattedNums = new List<decimal>();
    decimal vat = 1.2m;
    foreach (decimal num in nums)
    {
        vattedNums.Add(Math.Round(num * vat, 2));
    }
    return vattedNums;
};
Console.WriteLine(string.Join(Environment.NewLine, addVat(nums).ToList()));
