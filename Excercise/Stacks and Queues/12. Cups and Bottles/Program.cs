using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> capacityCup = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bottleWithWater = Console.ReadLine().Split().Select(int.Parse).ToList();

            Stack<int> stackBottle = new Stack<int>(bottleWithWater);
            Queue<int> queueCup = new Queue<int>(capacityCup);
            int water = 0;
            int count = -1;
            int cupWater = 0;


            while (stackBottle.Any() && queueCup.Any())
            {
                int bottleWater = stackBottle.Peek();
                
                if (count == -1)
                {
                     cupWater = queueCup.Peek();
                   
                }
               
                if (cupWater >= bottleWater)
                {
                 
                    cupWater -= bottleWater;
                    
                    stackBottle.Pop();
                }
                else
                {
                    water += bottleWater - cupWater;
                    cupWater -= bottleWater;
                   
                    stackBottle.Pop();
                }
                
                if (cupWater <= 0)
                {
                    count = -1;
                    queueCup.Dequeue();
                    continue;
                }
                count = 0;


            }
            if (stackBottle.Count == 0)
            {
               
                    Console.WriteLine($"Cups: {string.Join(" ",queueCup)}");
              
                Console.WriteLine($"Wasted litters of water: {water}");
            }
            else
            {
                
                    Console.WriteLine($"Bottles: {string.Join(" ",stackBottle)}");
                
                Console.WriteLine($"Wasted litters of water: {water}");
            }
        }
    }
}
