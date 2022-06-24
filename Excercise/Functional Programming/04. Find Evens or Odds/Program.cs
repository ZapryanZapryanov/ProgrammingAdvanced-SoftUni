using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] element = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int startIndex = element[0];
            int endIndex = element[1];

            List<int> nums = new List<int>();
            for (int i = startIndex; i <= endIndex; i++)
            {
                nums.Add(i);
            }
            string comand = Console.ReadLine();
      
            if (comand == "even")
            {
                Console.WriteLine(string.Join(" ", nums.FindAll(x => x % 2 == 0)));
            }
            else if (comand == "odd")
            {
                Console.WriteLine(string.Join(" ", nums.FindAll(x => x % 2 != 0)));


            }
        }
    }
}
