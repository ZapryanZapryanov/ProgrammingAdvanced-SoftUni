using System;

namespace _01._Generic_Box_of_String
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string elements = Console.ReadLine();
                var currBox = new Box<string>(elements);
                Console.WriteLine(currBox);
            }
        }
    }
}
