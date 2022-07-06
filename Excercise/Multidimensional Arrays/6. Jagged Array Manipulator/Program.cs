using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jagged = new int[n][];

            for (int i = 0; i < n; i++)
            {
                jagged[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            for (int i = 0; i < n - 1; i++)
            {
              
                    if (jagged[i].Length == jagged[i + 1].Length)
                    {
                    jagged[i] = jagged[i].Select(x => x * 2).ToArray();
                    jagged[i + 1] = jagged[i + 1].Select(x => x * 2).ToArray();

                }
                    else
                    {
                    jagged[i] = jagged[i].Select(x => x / 2).ToArray();
                    jagged[i + 1] = jagged[i + 1].Select(x => x / 2).ToArray();
                }
                
            }
            string comand = Console.ReadLine();
            while (comand != "End")
            {
                string[] elements = comand.Split();
                int row = int.Parse(elements[1]);
                int col = int.Parse(elements[2]);
                int value = int.Parse(elements[3]);
                if (row >= 0 && row < n && 
                     col >= 0 && col < jagged[row].Length)
                {
                    if (elements[0] == "Add")
                    {
                        jagged[row][col] += value;
                    }
                    else if (elements[0] == "Subtract")
                    {
                        jagged[row][col] -= value;
                    }
                }
               
                comand = Console.ReadLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int a = 0; a < jagged[i].Length; a++)
                {
                    Console.Write($"{jagged[i][a]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
