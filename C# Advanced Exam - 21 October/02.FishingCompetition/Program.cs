int colsRows = int.Parse(Console.ReadLine());
char[,] matrix = new char[colsRows, colsRows];
int fishCatched = 0;
int startingCol = 0;
int startingRow = 0;
bool isSink = false;
for (int i = 0; i < colsRows; i++)
{
    string inpt = Console.ReadLine();
    for (int j = 0; j < colsRows; j++)
    {
        matrix[i, j] = inpt[j];
        if (inpt[j] == 'S')
        {
            startingCol = i;
            startingRow = j;
        }
    }
}

string cmd;
while ((cmd = Console.ReadLine()) != "collect the nets")
{
    if (cmd == "up")
    {
        if (startingCol - 1 < 0)
        {
            matrix[startingCol, startingRow] = '-';
            startingCol = colsRows;
            if (matrix[startingCol - 1, startingRow] == '-')
            {
                matrix[startingCol - 1, startingRow] = 'S';
                startingCol--;
            }
            else if (matrix[startingCol - 1, startingRow] == 'W')
            {
                Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{startingCol-1},{startingRow}]");
                isSink = true;
                break;
            }

            else
            {
                string currentCatch = matrix[startingCol - 1, startingRow].ToString();
                fishCatched += int.Parse(currentCatch);
                matrix[startingCol - 1, startingRow] = 'S';
                startingCol--;
            }

        }
        else
        {
            if (matrix[startingCol - 1, startingRow] == '-')
            {
                matrix[startingCol, startingRow] = '-';
                matrix[startingCol - 1, startingRow] = 'S';
                startingCol--;
            }
            else if (matrix[startingCol - 1, startingRow] == 'W')
            {
                Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{startingCol-1},{startingRow}]");
                isSink = true;
                break;
            }

            else
            {
                string currentCatch = matrix[startingCol - 1, startingRow].ToString();
                fishCatched += int.Parse(currentCatch);
                matrix[startingCol, startingRow] = '-';
                matrix[startingCol - 1, startingRow] = 'S';
                startingCol--;
            }

        }
    }
    else if (cmd == "down")
    {
        if (startingCol + 1 >= colsRows)
        {
            matrix[startingCol, startingRow] = '-';
            startingCol = -1;
            if (matrix[startingCol + 1, startingRow] == '-')
            {
                matrix[startingCol + 1, startingRow] = 'S';
                startingCol++;
            }
            else if (matrix[startingCol + 1, startingRow] == 'W')
            {
                Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{startingCol+1},{startingRow}]");
                isSink = true;
                break;
            }

            else
            {
                string currentCatch = matrix[startingCol + 1, startingRow].ToString();
                fishCatched += int.Parse(currentCatch);
                matrix[startingCol + 1, startingRow] = 'S';
                startingCol++;
            }

        }
        else
        {
            if (matrix[startingCol + 1, startingRow] == '-')
            {
                matrix[startingCol, startingRow] = '-';
                matrix[startingCol + 1, startingRow] = 'S';
                startingCol++;
            }
            else if (matrix[startingCol + 1, startingRow] == 'W')
            {
                Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{startingCol+1},{startingRow}]");
                isSink = true;
                break;
            }
            else
            {
                string currentCatch = matrix[startingCol + 1, startingRow].ToString();
                fishCatched += int.Parse(currentCatch);
                matrix[startingCol, startingRow] = '-';
                matrix[startingCol + 1, startingRow] = 'S';
                startingCol++;
            }
        }
    }
    else if (cmd == "left")
    {
        if (startingRow - 1 < 0)
        {
            matrix[startingCol, startingRow] = '-';
            startingCol = colsRows;
            if (matrix[startingCol, startingRow - 1] == '-')
            {
                matrix[startingCol, startingRow - 1] = 'S';
                startingRow--;
            }
            else if (matrix[startingCol, startingRow - 1] == 'W')
            {
                Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{startingCol},{startingRow-1}]");
                isSink = true;
                break;
            }

            else
            {
                string currentCatch = matrix[startingCol, startingRow - 1].ToString();
                fishCatched += int.Parse(currentCatch);
                matrix[startingCol, startingRow - 1] = 'S';
                startingRow--;
            }
        }
        else
        {
            if (matrix[startingCol, startingRow - 1] == '-')
            {
                matrix[startingCol, startingRow] = '-';
                matrix[startingCol, startingRow - 1] = 'S';
                startingRow--;
            }
            else if (matrix[startingCol, startingRow - 1] == 'W')
            {
                Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{startingCol},{startingRow-1}]");
                isSink = true;
                break;
            }

            else
            {
                string currentCatch = matrix[startingCol, startingRow - 1].ToString();
                fishCatched += int.Parse(currentCatch);
                matrix[startingCol, startingRow] = '-';
                matrix[startingCol, startingRow - 1] = 'S';
                startingRow--;
            }
        }
    }

    else if (cmd == "right")
    {
        if (startingRow + 1 >= colsRows)
        {
            matrix[startingCol, startingRow] = '-';
            startingRow = -1;
            if (matrix[startingCol, startingRow + 1] == '-')
            {
                matrix[startingCol, startingRow + 1] = 'S';
                startingRow++;
            }
            else if (matrix[startingCol, startingRow + 1] == 'W')
            {
                Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{startingCol},{startingRow+1}]");
                isSink = true;
                break;
            }

            else
            {
                string currentCatch = matrix[startingCol, startingRow + 1].ToString();
                fishCatched += int.Parse(currentCatch);
                matrix[startingCol, startingRow + 1] = 'S';
                startingRow++;
            }
        }
        else
        {


            //if (matrix[startingCol, startingRow + 1] == '-')
            //{
            //    matrix[startingCol, startingRow] = '-';
            //    matrix[startingCol, startingRow + 1] = 'S';
            //    startingRow--;
            //}
            if (matrix[startingCol, startingRow + 1] == '-')
            {
                matrix[startingCol, startingRow] = '-';
                matrix[startingCol, startingRow + 1] = 'S';
                startingRow++;
            }
            else if (matrix[startingCol, startingRow + 1] == 'W')
            {
                Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{startingCol},{startingRow+1}]");
                isSink = true;
                break;
            }

            else
            {
                string currentCatch = matrix[startingCol, startingRow + 1].ToString();
                fishCatched += int.Parse(currentCatch);
                matrix[startingCol, startingRow] = '-';
                matrix[startingCol, startingRow + 1] = 'S';
                startingRow++;
            }
        }

    }
}
    if (!isSink)
    {
        if (fishCatched >= 20)
        {
            Console.WriteLine("Success! You managed to reach the quota!");
        }
        else
        {
            Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {20 - fishCatched} tons of fish more.");
        }
        if (fishCatched > 0)
        {
            Console.WriteLine($"Amount of fish caught: {fishCatched} tons.");
        }
        for (int i = 0; i < colsRows; i++)
        {
            for (int j = 0; j < colsRows; j++)
            {
                Console.Write(matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
