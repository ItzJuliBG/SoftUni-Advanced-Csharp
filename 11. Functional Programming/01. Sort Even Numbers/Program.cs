//List<int> list = Console.ReadLine().Split(", ").Select(int.Parse).Where(x => x % 2 == 0).OrderBy(x=> x).ToList();

//Console.WriteLine(string.Join(", ", list));

List<int> list = Console.ReadLine().Split(", ").Select(int.Parse).ToList();



Func<List<int>, Queue<int>> sortEvenNums = (list) =>
{
    Queue<int> sort = new Queue<int>();

    foreach (var num in list)
    {
        if (num % 2 == 0)
        {
            sort.Enqueue(num);
        }
        
    }
    return sort;
};
Queue<int> queue = new Queue<int>(sortEvenNums(list));
List<int> sortedQueue = queue.OrderBy(x=>x).ToList();

Console.WriteLine(string.Join(", ", sortedQueue));