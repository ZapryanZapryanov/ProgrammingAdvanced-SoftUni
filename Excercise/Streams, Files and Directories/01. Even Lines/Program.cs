using System;
using System.IO;
using System.Linq;

namespace _01._Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"C:\Users\ZAPRYAN\Desktop\text.txt";
            using (StreamReader reader = new StreamReader(pattern))
            {
               string line = reader.ReadLine();
                int evenOrOdd = -1;
                while (line != null)
                {
                    evenOrOdd++;
                    if (evenOrOdd % 2 == 0)
                    {
                        line = GetReplaceStr(line);
                        line = GetReverseStr(line);
                        Console.WriteLine(line);

                    }
                    line = reader.ReadLine();
                    
                   
                }
            }
        }
        static string GetReplaceStr(string line)
        {
            return line.Replace("-", "@")
                .Replace(",", "@")
                .Replace(".", "@")
                .Replace(".", "@")
                .Replace("!", "@")
                .Replace("?", "@");
        }
        static string GetReverseStr(string line)
        {
            return string.Join(" ", line.Split(" ").Reverse());
        }
    }

}
