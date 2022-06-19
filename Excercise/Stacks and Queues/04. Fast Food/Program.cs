using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quality = int.Parse(Console.ReadLine());

            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            Queue<int> food = new Queue<int>(list);
            Console.WriteLine(food.Max());
            for (int i = 0; i < list.Count; i++)
            {
                if (quality >= food.Peek())
                {
                    int perFood = food.Dequeue();
                    quality -= perFood;
                }
            }
            if (food.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", food)}");
            }
        }
    }
}
