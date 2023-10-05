using System.Text;

string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

Func<string[], List<string>> countUppercaseWords = (input) =>
{
    List<string> output = new();
    foreach (string word in input)
    {
        char firstChar = word[0];
        if (Char.IsUpper(firstChar))
        {
            output.Add(word);
        }
    }
    return output;
};
Console.WriteLine(string.Join(Environment.NewLine, countUppercaseWords(input)));