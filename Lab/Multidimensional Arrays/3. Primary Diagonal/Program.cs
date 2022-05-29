using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());


            int[,] matrix = new int[num, num];
            int sum = 0;
            for (int row = 0; row < num; row++)
            {
                int[] elements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < num; col++)
                {

                    matrix[row, col] = elements[col];

                }

            }
            int count = 0;
            for (int row = 0; row < num; row++)
            {

                for (int i = 0; i < num; i++)
                {
                    if (num <= count)
                    {
                        count -= 1;
                    }
                    sum += matrix[row, i + count];
                    break;
                    
                }
                count++;

            }
            Console.WriteLine(sum);


        }
    }
}
