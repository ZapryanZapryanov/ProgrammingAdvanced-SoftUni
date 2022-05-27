using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(num);

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] elements = input.Split();
                string cmdArg = elements[0].ToLower();
                if (cmdArg == "add")
                {
                    int firstNum = int.Parse(elements[1]);
                    int secondNum = int.Parse(elements[2]);
                    stack.Push(firstNum);
                    stack.Push(secondNum);
                }
                else if (cmdArg == "remove")
                {
                    int count = int.Parse(elements[1]);
                    if (count <= stack.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                }

                input = Console.ReadLine();
            }
            int sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
