using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listByNums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string comand = Console.ReadLine();
           
            Func<List<int>, List<int>> add = num => num.Select(x => x += 1).ToList();
            Func<List<int>, List<int>> multiply = num => num.Select(x => x *= 2).ToList(); 
            Func<List<int>, List<int>> subtract = num => num.Select(x => x -= 1).ToList(); 
            Action<List<int>> print = num => Console.WriteLine(string.Join(" ", num));


            while (comand != "end")
            {
                switch (comand)
                {
                    case "add":                       
                         listByNums = add(listByNums);                                            
                        break;
                    case "multiply":                       
                          listByNums = multiply(listByNums);                        
                        break;
                    case "subtract":                        
                           listByNums = subtract(listByNums);                        
                        break;
                    case "print":
                        print(listByNums);
                        break;
                }
                comand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", listByNums));
        }
    }
}
