using System;
using System.Linq;

namespace _04._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int colsRows = int.Parse(Console.ReadLine());
            char[,] matrix = new char[colsRows, colsRows];

            for (int i = 0; i < colsRows; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < colsRows; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            char searchingFor = char.Parse(Console.ReadLine());
            bool Isfound = false;
            for (int i = 0;i < colsRows; i++)
            {
                for (int j = 0;j < colsRows; j++)
                {
                    if(searchingFor == matrix[i, j])
                    {
                        Console.WriteLine($"({i}, {j})");
                        Isfound = true;
                    }
                }
            }
            if (!Isfound)
            {
                Console.WriteLine($"{searchingFor} does not occur in the matrix");
            }
        } // 80/100
    }
}
