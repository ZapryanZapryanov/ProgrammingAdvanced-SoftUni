﻿using System;
using System.Collections.Generic;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> elements = new SortedSet<string>();
            int n = int.Parse(Console.ReadLine()); 

            for (int row = 1; row <= n; row++)
            {
                string input = Console.ReadLine(); //"Mo O Ce"
                string[] chElements = input.Split(" "); //["Mo", "O", "Ce"]
                foreach (string chElement in chElements)
                {
                    elements.Add(chElement);
                }
            }

            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
