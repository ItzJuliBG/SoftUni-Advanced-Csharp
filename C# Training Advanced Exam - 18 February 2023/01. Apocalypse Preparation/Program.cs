List<int> textiles = Console.ReadLine().Split().Select(int.Parse).ToList();

List<int> medicaments = Console.ReadLine().Split().Select(int.Parse).ToList();

int medkitCount = 0;
int bandageCount = 0;
int patchCount = 0;
bool exeption = false;
while (textiles.Any() && medicaments.Any())
{
    int lastIndex = medicaments.Count - 1;
    bool t = IsCraftingPossible(textiles[0], medicaments[lastIndex],lastIndex);
    if(t== true)
    {
        textiles.RemoveAt(0);
        medicaments.RemoveAt(lastIndex);
    }
    else
    {
        if (exeption == true)
        {
            break;
            
        }
        else
        {
            medicaments[lastIndex] += 10;
        }  
    } 
}
if (medicaments.Any())
{
    Console.WriteLine("Textiles are empty");
    Print(medkitCount, bandageCount, patchCount);
    Console.WriteLine($"Medicaments left: {string.Join(", ", medicaments)}");
}
else if (textiles.Any())
{
    Console.WriteLine("Medicaments are empty.");
    Print(medkitCount, bandageCount, patchCount);
    Console.WriteLine($"Textiles left: {string.Join(", ", textiles)}");
}
else
{
    Console.WriteLine("Textiles and medicaments are both empty.");
    Print(medkitCount, bandageCount, patchCount);
}
void Print(int medkit, int  bandage, int patch)
{
    if(medkit > 0)
    {
        Console.WriteLine($"MedKit - {medkit}");
    }
    if(bandage > 0)
    {
        Console.WriteLine($"Bandage - {bandage}");
    }
    if(patch > 0)
    {
        Console.WriteLine($"Patch - {patch}");
    }
} 
bool IsCraftingPossible(int textile, int medicament,int jIndex)
{
    int sum = textile+medicament;
        bool t = true;

    switch (sum)
    {
        case 30:
            patchCount++;
            t= true;
            break;
        case 40:
            bandageCount++;
            t= true;
            break;
        case >=100:
            medkitCount++;
            sum -= 100;

            try
            {
                if (!textiles.Any())
                {
                    
                    break;

                }
                medicaments[jIndex - 1] += sum;
            }
            catch (Exception e)
            {
                t = false;
                exeption = true;
            }
            
            return t;
        default:
            textiles.RemoveAt(0);
            return false;
    }


    return t;
}
