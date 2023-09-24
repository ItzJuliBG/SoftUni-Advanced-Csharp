using System;
using System.Linq;

namespace _01._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inpt = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = inpt[0];
            int cols = inpt[1];

            int[,] matrix = new int[rows, cols];
            int sum = 0;


            for (int i = 0; i < rows; i++)
            {
                int[] newLine = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = newLine[j];
                    sum += newLine[j];
                }
            }
            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}
