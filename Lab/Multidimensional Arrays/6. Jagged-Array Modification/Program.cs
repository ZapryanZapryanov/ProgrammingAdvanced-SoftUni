using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            

            int[][] jugged = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                jugged[row] = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToArray();

            }
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] elements = input.Split();
                int row = int.Parse(elements[1]);
                int col = int.Parse(elements[2]);
                int value = int.Parse(elements[3]);
                if (row >= 0 && row < jugged.Length &&
                    col >= 0 && col < jugged[row].Length)
                {
                    if (elements[0] == "Add")
                    {

                        jugged[row][col] += value;
                    }
                    else if (elements[0] == "Subtract")
                    {

                        jugged[row][col] -= value;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
               

                input = Console.ReadLine();
            }
            for (int a = 0; a < rows; a++)
            {
                for (int i = 0; i < rows; i++)
                {
                    Console.Write($"{jugged[a][i]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
