using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            SortedDictionary<char, int> dct = new SortedDictionary<char, int>();
            foreach (var item in text)
            {
               
                    if (dct.ContainsKey(item))
                    {
                        dct[item]++;
                    }
                    else
                    {
                        dct.Add(item, 1);
                    }
                
            }
            foreach (var item in dct)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
