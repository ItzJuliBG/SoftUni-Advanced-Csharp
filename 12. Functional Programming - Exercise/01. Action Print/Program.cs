List<string> names = Console.ReadLine().Split().ToList();

Action<List<string>> printOnNewLine = (names) =>
{
    Console.WriteLine(string.Join(Environment.NewLine, names));
};

printOnNewLine(names);