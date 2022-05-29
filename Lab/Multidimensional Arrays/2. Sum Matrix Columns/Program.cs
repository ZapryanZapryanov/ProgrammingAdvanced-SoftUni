using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();


            int[,] matrix = new int[arr[0], arr[1]];
            
            for (int row = 0; row < arr[0]; row++)
            {
                int[] elements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < arr[1]; col++)
                {

                    matrix[row, col] = elements[col];
                    
                }
                
            }
            for (int col = 0; col < arr[0]; col++)
            {
                long sum = 0;
                for (int row = 0; row < arr[1]; row++)
                {
                    sum += matrix[row, col];
                  
                }
                Console.WriteLine(sum);
            }


        }
    }
}
