using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int nCarsLightGreen = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            Queue<string> cars = new Queue<string>();
            int countCarsPassed = 0;
            while (input != "end")
            {
                
                if (input == "green")
                {
                    for (int i = 0; i < nCarsLightGreen; i++)
                    {
                        if (cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            countCarsPassed++;
                        }
                        
                    }
                    input = Console.ReadLine();
                    continue;
                    
                }
                
                    cars.Enqueue(input);
                input = Console.ReadLine();


            }
            Console.WriteLine($"{countCarsPassed} cars passed the crossroads.");
        }
    }
}
