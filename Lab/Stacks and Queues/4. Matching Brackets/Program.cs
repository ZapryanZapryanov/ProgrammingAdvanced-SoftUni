using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split();
            
            Stack<string> stack = new Stack<string>(elements.Reverse());

            while (stack.Count > 1)
            {
                int leftNum = int.Parse(stack.Pop());
                string symbol = stack.Pop();
                int rightNum = int.Parse(stack.Pop());

                if (symbol == "+")
                {
                    stack.Push((leftNum + rightNum).ToString());
                }
                else if (symbol == "-")
                {
                    stack.Push((leftNum - rightNum).ToString());
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
