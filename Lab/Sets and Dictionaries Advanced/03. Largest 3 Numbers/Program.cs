using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var num = Console.ReadLine().Split(' ').Select(int.Parse)
            .OrderByDescending(x => x).ToList().Take(3);
            Console.WriteLine(string.Join(" ", num));

        }
    }
}
