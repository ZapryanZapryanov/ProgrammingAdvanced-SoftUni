using System;

namespace CarManufacturer
{
  public class StartUp
    {
        static void Main(string[] args)
        {
            Car cars = new Car();
            cars.Make = "VW";
            cars.Model = "MK3";
            cars.Years = 1992;
            Console.WriteLine($"Make: {cars.Make}\nModel: {cars.Model}\nYears: {cars.Years}");

            Car carsOne = new Car();
            cars.Make = "Audi";
            cars.Model = "A3";
            cars.Years = 2000;
            Console.WriteLine($"Make: {cars.Make}\nModel: {cars.Model}\nYears: {cars.Years}");

        }
    }
}
