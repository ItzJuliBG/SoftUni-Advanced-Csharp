Queue<int> tools = new(Console.ReadLine().Split().Select(int.Parse));
Stack<int> substances = new(Console.ReadLine().Split().Select(int.Parse));
List<int> challenges = new(Console.ReadLine().Split().Select(int.Parse));

while (challenges.Any() && substances.Any() && tools.Any())
{
    int tool = tools.Dequeue();
    int substance = substances.Pop();
    int result = tool * substance;
    if (challenges.Contains(result))
    {
        challenges.Remove(result);
    }
    else
    {
        tool++;
        tools.Enqueue(tool);

        substance--;
        if(substance != 0)
        {
            substances.Push(substance);
        }
    }
}

if (tools.Any())
{
    if (substances.Any() && challenges.Any())
    {
        Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
        Console.WriteLine($"Tools: {string.Join(", ", tools)}");
        Console.WriteLine($"Challenges: {string.Join(", ", challenges)}");
        Console.WriteLine($"Substances: {string.Join(", ", substances)}");

    }
    else if (challenges.Any())
    {
        Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
        Console.WriteLine($"Tools: {string.Join(", ", tools)}");
        Console.WriteLine($"Challenges: {string.Join(", ", challenges)}");
    }
    else if (substances.Any())
    {
        Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
        Console.WriteLine($"Tools: {string.Join(", ", tools)}");
        Console.WriteLine($"Substances: {string.Join(", ", substances)}");
    }
}
else if (substances.Any())
{
    if (challenges.Any())
    {
        Console.WriteLine("Harry is lost in the temple. Oblivion awaits him");
        Console.WriteLine($"Substances: {string.Join(", ", substances)}");
        Console.WriteLine($"Challenges: {string.Join(", ", challenges)}");
    }
    else
    {
        Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
        Console.WriteLine($"Substances: {string.Join(", ", substances)}");
    }
}
else
{
    Console.WriteLine("Harry is lost in the temple. Oblivion awaits him");
        Console.WriteLine($"Challenges: {string.Join(", ", challenges)}");
}