using System;
using System.Linq;

namespace _01._Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] element = Console.ReadLine().Split().ToArray();
            Action<string> names = x => Console.WriteLine(x);
            foreach (var item in element)
            {
                names(item);
            }
        }
    }
}
