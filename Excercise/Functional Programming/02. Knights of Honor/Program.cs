using System;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split();

            Action<string> collection = names => Console.WriteLine($"Sir {names}");
            foreach (var item in elements)
            {
                collection(item);
            }
        }
    }
}
