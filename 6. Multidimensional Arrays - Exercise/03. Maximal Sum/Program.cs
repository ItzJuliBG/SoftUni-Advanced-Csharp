using System;
using System.Linq;

namespace _03._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inpt = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int row = inpt[0];
            int col = inpt[1];
            int[,] matrix = new int[row, col];


            for (int i = 0; i < row; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            int sum = 0;
            int[,] maxMatrix = new int[3, 3];
            for (int i = 0; i < row - 2; i++)
            {
                for (int j = 0; j < col - 2; j++)
                {
                    int currentSum = 0;
                    currentSum += matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] +
                        matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]
                        + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                    if(currentSum >sum )
                    {
                        sum = currentSum;
                        maxMatrix[0,0] = matrix[i, j];
                        maxMatrix[0, 1] = matrix[i, j + 1];
                        maxMatrix[0, 2] = matrix[i, j + 2];
                        maxMatrix[1, 0] = matrix[i + 1, j];
                        maxMatrix[1, 1] = matrix[i + 1, j + 1];
                        maxMatrix[1, 2] = matrix[i + 1, j + 2];
                        maxMatrix[2, 0] = matrix[i + 2, j];
                        maxMatrix[2, 1] = matrix[i + 2, j + 1];
                        maxMatrix[2, 2] = matrix[i + 2, j + 2];
                    }

                }
            }
            Console.WriteLine($"Sum = {sum}");
            for(int i = 0; i < 3; i++ ) 
            {
                Console.WriteLine($"{maxMatrix[i, 0]} {maxMatrix[i,1]} {maxMatrix[i,2]}");
            }
        }
    }
}
