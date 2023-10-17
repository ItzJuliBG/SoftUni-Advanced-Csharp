int n = int.Parse(Console.ReadLine());

char[,] table = new char[n, n];

int holes = 0;

int startingI = 0;
int startingJ = 0;
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();

    for (int j = 0; j < n; j++)
    {
        table[i, j] = (char)input[j];
        if (table[i, j] == 'V')
        {
            startingI = i;
            startingJ = j;
            //table[i, j] = ; ;
        }
    }
}
string cmd;
bool breake = false;
while ((cmd = Console.ReadLine()) != "End")
{
    if(breake == true)
    {
        break;
    }


    switch (cmd)
    {
        case "up":
            if ((startingI - 1) < 0)
            {
                continue;
            }
            else if (table[startingI-1, startingJ] == 'C')
            {
                startingI--;
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {holes} hole(s).");
                table[startingI, startingJ] = 'E';  
                breake = true;

            }
            else if (table[startingI-1, startingJ] == 'R')
            {
                holes++;
                Console.WriteLine("Vanko hit a rod!");
            }
            else if(table[startingI - 1, startingJ] == '*')
            {
                Console.WriteLine($"The wall is already destroyed at position[{startingJ}, {startingI-1}]!");

            }
            else
            {
                holes++;
                startingI--;
                table[startingI, startingJ] = '*';
               
            }

                break;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(table[i, j]);
            //    }
            //    Console.WriteLine();
            //}
        case "down":
            if ((startingI + 1) > n-1)
            {
                continue;
            }
            else if (table[startingI + 1, startingJ] == 'C')
            {
                table[startingI, startingJ] = 'E';
                break;
            }
            else if (table[startingI + 1, startingJ] == 'R')
            {
                holes++;
                Console.WriteLine("Vanko hit a rod!");
            }
            else if (table[startingI + 1, startingJ] == '*')
            {
                Console.WriteLine($"The wall is already destroyed at position[{startingJ}, {startingI + 1}]!");

            }
            else
            {
                holes++;
                startingI++;
                table[startingI, startingJ] = '*';
            }
            break;
        case "left":
            if ((startingJ - 1) < 0)
            {
                continue;
            }
            else if (table[startingI, startingJ -1] == 'C')
            {
                table[startingI, startingJ] = 'E';
                break;
            }
            else if (table[startingI, startingJ-1] == 'R')
            {
                holes++;
                Console.WriteLine("Vanko hit a rod!");
            }
            else if (table[startingI, startingJ-1] == '*')
            {
                Console.WriteLine($"The wall is already destroyed at position[{startingJ -1}, {startingI}]!");

            }
            else
            {
                holes++;
                startingJ--;
                table[startingI, startingJ] = '*';
            }
            break;
        case "right":
            if ((startingJ + 1) > n-1)
            {
                continue;
            }
            else if (table[startingI, startingJ + 1] == 'C')
            {
                table[startingI, startingJ] = 'E';
                break;
            }
            else if (table[startingI, startingJ + 1] == 'R')
            {
                holes++;
                Console.WriteLine("Vanko hit a rod!");
            }
            else if (table[startingI, startingJ + 1] == '*')
            {
                Console.WriteLine($"The wall is already destroyed at position[{startingJ + 1}, {startingI}]!");

            }
            else
            {
                holes++;
                startingJ++;
                table[startingI, startingJ] = '*';
            }
            break;

    }
}
if (breake == false)
{
    table[startingI, startingJ] = 'V';
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(table[i, j]);
    }
    Console.WriteLine();
}