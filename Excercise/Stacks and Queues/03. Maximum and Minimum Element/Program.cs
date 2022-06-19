using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int elements = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < elements; i++)
            {
                int[] cmdArg = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int firstCmd = cmdArg[0];

                if (firstCmd == 1)
                {
                    stack.Push(cmdArg[1]);
                }
                else if (firstCmd == 2)
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                    
                }
                else if (firstCmd == 3)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                    
                }
                else if (firstCmd == 4)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                    
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
