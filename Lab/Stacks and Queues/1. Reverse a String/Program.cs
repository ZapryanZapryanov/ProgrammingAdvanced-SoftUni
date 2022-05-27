using System;
using System.Collections;
using System.Collections.Generic;

namespace _1._Reverse_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            foreach (char item in input)
            {
                stack.Push(item);
            }
            Console.WriteLine(string.Join("", stack));
        }
    }
}
