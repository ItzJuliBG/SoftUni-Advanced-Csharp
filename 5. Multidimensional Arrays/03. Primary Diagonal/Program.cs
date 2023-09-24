using System;
using System.Linq;

namespace _03._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int colsRows = int.Parse(Console.ReadLine());

            int[,] matrix = new int[colsRows, colsRows];

            for (int i = 0; i < colsRows; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < colsRows; j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            
            int sum = 0;
            for (int i = 0; i < colsRows; i++)
            {
                for (int j = 0; j < colsRows; j++)
                {
                    if(i-1 == j - 1)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
