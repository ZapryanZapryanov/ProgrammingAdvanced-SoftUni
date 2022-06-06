using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            HashSet<string> cars = new HashSet<string>();
            while (input != "END")
            {
                string[] cmdArg = input.Split(", ");
                string firstElement = cmdArg[0];
                string secondElement = cmdArg[1];
                if (firstElement == "IN")
                {
                    cars.Add(secondElement);
                }
                else if (firstElement == "OUT")
                {
                    cars.Remove(secondElement);
                }

                input = Console.ReadLine();
            }
            if (cars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                Console.WriteLine(string.Join(Environment.NewLine, cars));
            }
            
        }
    }
}
