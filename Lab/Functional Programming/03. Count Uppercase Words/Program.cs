﻿using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split().Where(firstLetterIsUpeer).ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, text));
        }
        static Func<string, bool> firstLetterIsUpeer = x => x.Length > 0 && char.IsUpper(x[0]);
    }
}
