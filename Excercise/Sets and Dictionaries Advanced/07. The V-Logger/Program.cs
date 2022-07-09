using System;
using System.Collections.Generic;

namespace _07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            int hp = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            char[][] matrix = new char[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
            }
            for (int i = 0; i < n; i++)
            {
                string[] cmdArg = Console.ReadLine().Split();
                string position = cmdArg[0];

            }
        }
    }
}
