using System;

namespace _08._Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elemet = Console.ReadLine().Split();
            string firstNameAndLast = $"{elemet[0]} {elemet[1]}";
            string adress = elemet[2];
            string town = elemet[3];

            string[] newElement = Console.ReadLine().Split();
            string name = newElement[0];
            int drinkBeer = int.Parse(newElement[1]);
            bool drunkOrNo = newElement[2] == "drunk" ? true : false;

            string[] lastElement = Console.ReadLine().Split();
            string item = lastElement[0];
            double newItem = double.Parse(lastElement[1]);
            string bankName = lastElement[2];

            var item1 = new Tuple<string, string, string>(firstNameAndLast, adress, town);
            Console.WriteLine(item1);

            var item2 = new Tuple<string, int, bool>(name, drinkBeer, drunkOrNo);
            Console.WriteLine(item2);

            var item3 = new Tuple<string, double, string>(item, newItem, bankName);
            Console.WriteLine(item3);
        }
    }
}
