List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
int playersTouched = 0;
int movesCount = 0;
int countCol = input[0];
int countRow = input[1];
int col = 0;
int row = 0;
char[,] matrix = new char[countCol, countRow];

for (int i = 0; i < countCol; i++)
{
    List<char> currentCol = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToList();
    for (int j = 0; j < countRow; j++)
    {
        if (currentCol[j] == 'B')
        {
            col = i;
            row = j;
        }
        matrix[i, j] = currentCol[j];
    }
}

string command;
while ((command = Console.ReadLine()) != "Finish" && playersTouched != 3)
{
    switch (command)
    {
        case "up":
            if (col - 1 >= 0)
            {
                switch (matrix[col - 1, row])
                {
                    case '-':
                        movesCount++;
                        matrix[col, row] = '-';
                        matrix[col - 1, row] = 'B';
                        col--;
                        break;
                    case 'O':
                        break;
                    case 'P':
                        movesCount++;
                        playersTouched++;
                        matrix[col, row] = '-';
                        matrix[col - 1, row] = 'B';
                        col--;
                        break;
                }
            }

            break;
        case "down":
            if (col + 1 <= countCol - 1)
            {

                switch (matrix[col + 1, row])
                {
                    case '-':
                        movesCount++;
                        matrix[col, row] = '-';
                        matrix[col + 1, row] = 'B';
                        col++;
                        break;
                    case 'O':
                        break;
                    case 'P':
                        movesCount++;
                        playersTouched++;
                        matrix[col, row] = '-';
                        matrix[col + 1, row] = 'B';
                        col++;
                        break;
                }
            }
            break;
        case "left":
            if (row - 1 >= 0)
            {
                switch (matrix[col, row - 1])
                {
                    case '-':
                        movesCount++;
                        matrix[col, row] = '-';
                        matrix[col, row - 1] = 'B';
                        row--;
                        break;
                    case 'O':
                        break;
                    case 'P':
                        movesCount++;
                        playersTouched++;
                        matrix[col, row] = '-';
                        matrix[col, row - 1] = 'B';
                        row--;
                        break;
                }
            }
            break;
        case "right":
            if (row + 1 <= countRow - 1)
            {
                switch (matrix[col, row + 1])
                {
                    case '-':
                        movesCount++;
                        matrix[col, row] = '-';
                        matrix[col, row + 1] = 'B';
                        row++;
                        break;
                    case 'O':
                        break;
                    case 'P':
                        movesCount++;
                        playersTouched++;
                        matrix[col, row] = '-';
                        matrix[col, row + 1] = 'B';
                        row++;
                        break;
                }
            }
            break;
    }
}
Console.WriteLine("Game over!");
Console.WriteLine($"Touched opponents: {playersTouched} Moves made: {movesCount}");
