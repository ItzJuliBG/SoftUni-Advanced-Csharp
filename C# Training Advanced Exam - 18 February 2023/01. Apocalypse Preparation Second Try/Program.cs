Queue<int> textiles = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
Stack<int> medicaments = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
string t = "patch";
Dictionary<int, string> items = new Dictionary<int, string>()
{
    {30, "Patch"},
    {40, "Bandage" },
    {100, "MedKit" }
};
int medKit = 0;
int bandage = 0;
int patch = 0;

while(textiles.Any() && medicaments.Any())
{
    int textile = textiles.Dequeue();
    int medicament = medicaments.Pop();
    int sum = textile + medicament;
    if (items.ContainsKey(sum))
    {
        if (items[sum] == "MedKit")
        {
            medKit++;
        }
        else if (items[sum] == "Bandage")
        {
            bandage++;
        }
        else
        {
            patch++;
        }
    }
    else if(sum > 100)
    {
        medKit++;
        sum -= 100;
        int temp = medicaments.Pop() + sum;
        medicaments.Push(temp);
    }
    else
    {
        medicament += 10;
        medicaments.Push(medicament);
    }
}
if (textiles.Any())
{
    Console.WriteLine("Medicaments are empty.");
    Print(medKit, bandage, patch);
    Console.WriteLine($"Textiles left: {string.Join(", ", textiles)}");

}
else if (medicaments.Any())
{
    Console.WriteLine("Textiles are empty.");
    Print(medKit, bandage, patch);
    Console.WriteLine($"Medicaments left: {string.Join(", ", medicaments)}");

}
else
{
    Console.WriteLine("Textiles and medicaments are both empty.");
    Print(medKit, bandage, patch);
}
void Print(int medkit, int bandage, int patch)
{
    if (medkit > 0)
    {
        Console.WriteLine($"MedKit - {medkit}");
    }
    if (bandage > 0)
    {
        Console.WriteLine($"Bandage - {bandage}");
    }
    if (patch > 0)
    {
        Console.WriteLine($"Patch - {patch}");
    }
}