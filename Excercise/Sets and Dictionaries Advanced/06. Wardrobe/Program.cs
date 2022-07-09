using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
           

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                //"Blue -> dress,jeans,hat".Split(" -> ") -> ["Blue", "dress,jeans,hat"]
                string color = input.Split(" -> ")[0];

                if (!wardrobe.ContainsKey(color))
                {
                   
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
              
                Dictionary<string, int> clothes = wardrobe[color]; //дрехите от съответния цвят
                string[] inputClothes = input.Split(" -> ") //["Blue", "dress,jeans,hat"]
                                        [1]                 //"dress, jeans, hat"
                                        .Split(",");        //["dress", "jeans", "hat"]

                foreach (string cloth in inputClothes)
                {
                    if (!clothes.ContainsKey(cloth))
                    {
                        clothes.Add(cloth, 1);
                    }
                    else
                    {
                        clothes[cloth]++;
                    }
                }
            }

            string searchedItems = Console.ReadLine(); // "Blue dress"
            string searchedColor = searchedItems.Split(" ")[0];
            string searchedCloth = searchedItems.Split(" ")[1];

            foreach (var colorEntry in wardrobe)
            {
               
                Console.WriteLine($"{colorEntry.Key} clothes:");
                Dictionary<string, int> clothes = colorEntry.Value;
                
                foreach (var cloth in clothes)
                {
                   
                    if (cloth.Key == searchedCloth && colorEntry.Key == searchedColor)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }

                }
            }
        }
    }
}
