List<string> names = Console.ReadLine().Split().ToList();

Action<List<string>> printOnNewLine = (names) =>
{
   foreach (string name in names)
    {
        Console.WriteLine("Sir "+name);
    }
};

printOnNewLine(names);