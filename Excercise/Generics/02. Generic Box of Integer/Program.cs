using System;

namespace _02._Generic_Box_of_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int elements = int.Parse(Console.ReadLine());
                var currBox = new Box<int>(elements);
                Console.WriteLine(currBox);
            }
        }
    }
}
