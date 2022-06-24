using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrByNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int> min = x => x.Min();
            int numb = min(arrByNumbers);
            Console.WriteLine(numb);
        }
    }
}
