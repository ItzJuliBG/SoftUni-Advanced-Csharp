using System;
using System.Linq;

namespace _01._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowsCols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rowsCols, rowsCols];

            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;

            for (int i = 0; i < rowsCols; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < rowsCols; j++)
                {
                    matrix[i,j] = input[j];
                }
            }


            for (int i = 0; i < rowsCols; i++)
            {
                for (int j = 0; j < rowsCols; j++)
                {
                    if(i-1 == j - 1)
                    {
                        primaryDiagonal += matrix[i, j];
                    }
                }
            }
//input :
//3
//11 2 4
//4 5 6
//10 8 - 12
            int col = rowsCols-1;
            int row = 0;
            for (int i = 0; i < rowsCols; i++)
            {
                for(int j = 0;j < rowsCols; j++)
                {
                   if(col == j && row == i)
                    {
                        col--;
                        row++;
                        secondaryDiagonal += matrix[i, j]; //index out of binds why?
                    }
                        
                    
                }
            }
            int sum = Math.Abs(primaryDiagonal - secondaryDiagonal);
            //Console.WriteLine(Math.Abs(sum));
            Console.WriteLine(sum);
        }
    }
}
