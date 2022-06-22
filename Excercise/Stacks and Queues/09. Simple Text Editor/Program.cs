using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] cmdArg = Console.ReadLine().Split();

                if (cmdArg[0] == "1")
                {
                    stack.Push(sb.ToString());
                    sb.Append(cmdArg[1]);
                    
                }
                else if (cmdArg[0] == "2")
                {
                    stack.Push(sb.ToString());
                    int count = int.Parse(cmdArg[1]);
                    sb.Remove(sb.Length - count, count);
                    
                }
                else if (cmdArg[0] == "3")
                {
                    int index = int.Parse(cmdArg[1]);
                    Console.WriteLine(sb[index - 1]);
                }
                else if (cmdArg[0] == "4")
                {
                    sb.Clear();
                    sb.Append(stack.Pop().ToString());
                }
            }
        }
    }
}
