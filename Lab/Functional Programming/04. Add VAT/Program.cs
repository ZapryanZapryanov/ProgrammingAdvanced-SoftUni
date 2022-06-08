using System;
using System.Linq;

namespace _04._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(", ").Select(double.Parse).Select(sumWithVat).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]:f2}");
            }
           
        }
        static Func<double, double> sumWithVat = x => x * 1.20;
    }
}
