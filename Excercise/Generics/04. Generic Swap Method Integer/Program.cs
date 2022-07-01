using System;
using System.Linq;

namespace _04._Generic_Swap_Method_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var currBox = new Box<int>();

            for (int i = 0; i < n; i++)
            {
                int elements = int.Parse(Console.ReadLine());


                currBox.Name.Add(elements);
            }
            int[] swap = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstIndex = swap[0];
            int secondIndex = swap[1];
            currBox.SwapElements(firstIndex, secondIndex);
            Console.WriteLine(currBox);
        }
    }
}
