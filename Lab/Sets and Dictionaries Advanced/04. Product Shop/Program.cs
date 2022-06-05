using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();

            while (input != "Revision")
            {
                string[] cmdArg = input.Split(", ");
                string shopName = cmdArg[0];
                string productName = cmdArg[1];
                double price = double.Parse(cmdArg[2]);
                if (shops.ContainsKey(shopName))
                {
                    shops[shopName].Add(productName, price);
                }
                else
                {
                    
                    shops.Add(shopName, new Dictionary<string, double>() { { productName, price } });
                }

                input = Console.ReadLine();
            }
            foreach (var item in shops.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}->");
                foreach (var currItem in item.Value)
                {
                    Console.WriteLine($"Product: {currItem.Key}, Price: {currItem.Value}");
                }
            }
        }
    }
}
