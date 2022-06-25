using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int[]> reverse = i =>
            {
                for (int j = 0; j < i.Length / 2; j++)
                {
                    int temp = i[j];
                    i[j] = i[i.Length - 1 - j];
                    i[i.Length - 1 - j] = temp;
                }
            };
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            Predicate<int> filter = i => i % n != 0;
            reverse(numbers);
            Console.WriteLine(string.Join(" ", numbers.ToList().FindAll(filter)));
        }
    }
}
