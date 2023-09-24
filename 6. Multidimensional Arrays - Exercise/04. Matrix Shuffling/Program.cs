using System;
using System.Linq;

namespace _04._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inpt = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int row = inpt[0];
            int col = inpt[1];
            string[,] matrix = new string[row, col];

            for (int i = 0; i < row; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = input[j];
                }
            }


            while (true)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                if (cmd[0] == "END")
                {
                    break;
                }
                if (cmd[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    int row1 = int.Parse(cmd[1]);
                    int col1 = int.Parse(cmd[2]);

                    int row2 = int.Parse(cmd[3]);
                    int col2 = int.Parse(cmd[4]);
                    if (row1 > row || row2 > row || col1 > col || col2 > col)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        string tempVar = matrix[row2, col2];
                        matrix[row2, col2] = matrix[row1, col1];
                        matrix[row1, col1] = tempVar;
                        for (int i = 0; i < row; i++)
                        {
                            for (int j = 0;j < col; j++)
                            {
                                Console.Write(matrix[i,j] +" ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
                
            } // 80/100

        }

    }
}
