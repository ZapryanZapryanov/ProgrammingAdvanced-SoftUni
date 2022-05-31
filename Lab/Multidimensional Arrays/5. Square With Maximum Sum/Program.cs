using System;
using System.Linq;
using System.Text;

namespace _5._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();


            int[,] matrix = new int[arr[0], arr[1]];
         
            for (int row = 0; row < arr[0]; row++)
            {
                int[] elements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < arr[1]; col++)
                {

                    matrix[row, col] = elements[col];
                   
                }
            }

            int max = int.MinValue;
            int finallySUm = 0;

            string print = "";
            string printNewLine = "";
            for (int row = 0; row < arr[0] - 1; row++)
            {
               
                for (int col = 0; col < arr[1] - 1; col++)
                {
                    
                   
                    int sum = 0;
                    sum += matrix[row, col] + matrix[row + 1, col + 1] + matrix[row, col + 1] + matrix[row + 1, col];
                    if (max < sum)
                    {
                        print = "";
                        printNewLine = "";
                        print = $"{matrix[row, col]} {matrix[row, col + 1]}";
                        printNewLine = $"{matrix[row + 1, col]} {matrix[row + 1, col + 1]}";
                        max = sum;
                        finallySUm = sum;
                    }

                }
            }
            Console.WriteLine(print);
            Console.WriteLine(printNewLine);
            Console.WriteLine(finallySUm);
        }
    }
}
