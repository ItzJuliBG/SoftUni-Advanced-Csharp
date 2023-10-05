List<int> list = Console.ReadLine().Split(", ").Select(int.Parse).ToList();


Func<List<int>, int> SumList = (list) =>
{
    int sum = list.Sum();
    return sum;
};

Console.WriteLine(list.Count);
Console.WriteLine(SumList(list));
