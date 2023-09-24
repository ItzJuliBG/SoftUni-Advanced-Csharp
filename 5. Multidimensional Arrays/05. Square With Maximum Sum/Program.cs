using System;
using System.Linq;

namespace _05._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inpt = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = inpt[0];
            int cols = inpt[1];
            int[,] matrix = new int[rows, cols];    

            for (int i = 0; i < rows; i++)
            {
                int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i,j] = input[j];
                }
            }

            int[] biggestSum = new int[4];
            int sum = 0;
            for (int i = 0; i < rows-1; i++)
            {
                for (int j = 0; j < cols-1; j++)
                {
                    int currentSum = matrix[i,j]+matrix[i,j+1]+matrix[i+1,j]+matrix[i+1,j+1];
                    if(currentSum > sum)
                    {
                        sum = currentSum;
                        Array.Clear(biggestSum, 0, 4);
                        biggestSum[0] = matrix[i, j];
                        biggestSum[1] = matrix[i, j+1];
                        biggestSum[2] = matrix[i+1, j];
                        biggestSum[3] = matrix[i+1, j+1];
                    }
                }
            }
            Console.WriteLine(biggestSum[0]+" " + biggestSum[1]);
            Console.WriteLine(biggestSum[2] + " " + biggestSum[3]);
            Console.WriteLine(sum);
        }
    }
}
