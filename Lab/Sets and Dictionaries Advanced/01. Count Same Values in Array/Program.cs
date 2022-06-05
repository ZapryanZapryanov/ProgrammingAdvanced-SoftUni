using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> nums = new Dictionary<double, int>();

            foreach (var item in numbers)
            {
                if (nums.ContainsKey(item))
                {
                    nums[item]++;
                }
                else
                {
                    nums.Add(item, 1);
                }
            }
            foreach (var item in nums)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }

        }
    }
}
