Queue<int> armors = new(Console.ReadLine().Split(",").Select(int.Parse));
Stack<int> strikes = new(Console.ReadLine().Split(",").Select(int.Parse));
int monstersKilled = 0;
while (true)
{
    if(armors.Any() && strikes.Any())
    {
        int armor = armors.Dequeue();
        int strike = strikes.Pop();

        if(armor-strike > 0) 
        {
            armors.Enqueue(armor-strike);
        }
        else
        {
            if(strike-armor> 0)
            {
                strikes.Push(strike-armor);
                monstersKilled++;
            }
            else
            {
                monstersKilled++;
            }
        }
    }
    else if (!armors.Any())
    {
        Console.WriteLine("All monsters have been killed!");


        break;
    }else if (!strikes.Any())
    {
        Console.WriteLine("The soldier has been defeated.");


        break;
    }

}
Console.WriteLine($"Total monsters killed: {monstersKilled}"); //50/100