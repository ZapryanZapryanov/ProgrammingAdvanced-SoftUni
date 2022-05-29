using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();


            int[,] matrix = new int[arr[0], arr[1]];
            int sum = 0;
            for (int row = 0; row < arr[0]; row++)
            {
                int[] elements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < arr[1]; col++)
                {
                    
                    matrix[row, col] = elements[col];
                    sum += elements[col];
                }
            }
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine(sum);
        }
    }
}
