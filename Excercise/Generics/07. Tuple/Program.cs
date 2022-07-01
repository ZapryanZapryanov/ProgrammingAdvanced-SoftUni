using System;

namespace _07._Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elemet = Console.ReadLine().Split();
            string firstNameAndLast = $"{elemet[0]} {elemet[1]}";
            string adress = elemet[2];

            string[] newElement = Console.ReadLine().Split();
            string name = newElement[0];
            int drinkBeer = int.Parse(newElement[1]);

            string[] lastElement = Console.ReadLine().Split();
            int item = int.Parse(lastElement[0]);
            double newItem = double.Parse(lastElement[1]);

            var item1 = new Tuple<string, string>(firstNameAndLast, adress);
            Console.WriteLine(item1);

            var item2 = new Tuple<string, int>(name, drinkBeer);
            Console.WriteLine(item2);

            var item3 = new Tuple<int, double>(item, newItem);
            Console.WriteLine(item3);

        }
    }
}
