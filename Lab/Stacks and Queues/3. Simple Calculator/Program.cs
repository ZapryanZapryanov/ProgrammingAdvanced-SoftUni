using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cmd = Console.ReadLine().Split();

            List<int> list = new List<int>();
            List<string> symbol = new List<string>();
            int firstElements = 0;
            int secondElements = 0;
            
            foreach (string item in cmd)
            {
                if (item != "-" && item != "+")
                {
                    list.Add(int.Parse(item));
                }
                else
                {
                    symbol.Add(item);
                }
              
               
            }
            foreach (var item in symbol)
            {
                if (item == "-")
                {

                }
                else
                {

                }
            }
          
            Console.WriteLine(sum);
        }
    }
}
