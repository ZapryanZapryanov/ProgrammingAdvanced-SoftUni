using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowAndCol = Console.ReadLine().Split().Select(int.Parse).ToArray();


            string[,] matrix = new string[rowAndCol[0], rowAndCol[1]];
            FillMatrix(matrix);

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] elements = input.Split();
                if (elements[0] == "swap" && elements.Length == 5)
                {
                    int firstRow = int.Parse(elements[1]);
                    int firstCol = int.Parse(elements[2]);
                    int secondRow = int.Parse(elements[3]);
                    int secondCol = int.Parse(elements[4]);
                    if (firstRow >= 0 && firstRow < rowAndCol[0] &&
                         secondRow >= 0 && secondRow < rowAndCol[0] &&
                         firstCol >= 0 && firstCol < rowAndCol[1] &&
                         secondCol >= 0 && secondCol < rowAndCol[1] 
                         )
                    {
                        string arg = matrix[firstRow, firstCol];
                        matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
                        matrix[secondRow, secondCol] = arg;
                     
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int a = 0; a < matrix.GetLength(1); a++)
                            {
                                Console.Write(matrix[i,a] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                input = Console.ReadLine();
            }
        }
        private static void FillMatrix(string[,] numbers)
        {
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine().Split(" ").ToArray();
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    numbers[row, col] = rowData[col];
                }
            }
        }
    }
}
