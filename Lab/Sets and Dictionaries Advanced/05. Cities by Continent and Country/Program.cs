using System;
using System.Collections.Generic;

namespace _05._Cities_by_Continent_and_Country
{
    class Program
    {
       

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> dct = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();
                string countinents = info[0];
                string country = info[1];
                string city = info[2];
                if (dct.ContainsKey(countinents))
                {
                    if (dct[countinents].ContainsKey(country))
                    {
                        dct[countinents][country].Add(city);
                    }
                    else
                    {
                        dct[countinents].Add(country, new List<string> { city });
                    }
                    
                }
                else
                {
                    dct.Add(countinents, new Dictionary<string, List<string>> { { country, new List<string> { city } } });
                }

            }
            foreach (var item in dct)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var currItem in item.Value)
                {
                    Console.WriteLine($"  {currItem.Key} -> {string.Join(", ", currItem.Value)}");
                }
            }
        }
    }
}
