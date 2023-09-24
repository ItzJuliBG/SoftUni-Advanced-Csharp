using System;
using System.Linq;

namespace _02._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inpt = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = inpt[0];
            int cols = inpt[1];

            int[,] matrix = new int[rows, cols];

            int sumCol = 0;
            for (int i = 0; i < rows; i++)
            {
                int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = ints[j];
                }
            }

            for (int c = 0; c < cols; c++)
            {
                int sumCols = 0;
                for (int r = 0; r < rows; r++)
                {
                    sumCols += matrix[r, c];
                }
                Console.WriteLine(sumCols);
            }
           
        }
    }
}
