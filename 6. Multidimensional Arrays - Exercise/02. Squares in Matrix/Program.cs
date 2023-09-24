using System;
using System.Linq;

namespace _02._Squares_in_Matrix
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
                char[] input = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int j = 0; j < col; j++)
                {
                    matrix[i,j] = input[j];
                }
            }
            int equalSquares = 0;
            for (int i = 0;i < row-1; i++)
            {
                for (int j = 0;j < col-1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1] && matrix[i, j] == matrix[i + 1, j] && matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        equalSquares++;
                    }
                }
            }
            Console.WriteLine(equalSquares);
        }
    }
}
