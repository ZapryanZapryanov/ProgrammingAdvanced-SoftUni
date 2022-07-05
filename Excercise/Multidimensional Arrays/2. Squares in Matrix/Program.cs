using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowAndCol = Console.ReadLine().Split().Select(int.Parse).ToArray();
            

            string[,] matrix = new string[rowAndCol[0], rowAndCol[1]];
            FillMatrix(matrix, rowAndCol[0], rowAndCol[1]);
            int count = 0;
            for (int i = 0; i < rowAndCol[0] - 1; i++)
            {
                for (int a = 0; a < rowAndCol[1] - 1; a++)
                {
                    if (matrix[i, a] == matrix[i + 1, a] &&
                        matrix[i, a] == matrix[i + 1, a + 1] &&
                        matrix[i, a] == matrix[i, a + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
            
        }
        private static void FillMatrix(string[,] numbers, int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                string[] rowData = Console.ReadLine().Split(" ").ToArray();
                for (int col = 0; col < cols; col++)
                {
                    numbers[row, col] = rowData[col];
                }
            }
        }
    }
}
