using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine().Split();
            int count = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(children);


            while (queue.Count > 1)
            {
                for (int i = 1; i <= count; i++)
                {
                     
                    string name = queue.Dequeue();
                    if (i == count)
                    {
                        Console.WriteLine($"Removed {name}");
                        break;
                    }
                    queue.Enqueue(name);
                }
            }
           
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
