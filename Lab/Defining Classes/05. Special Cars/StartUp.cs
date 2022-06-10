using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            List<Tire[]> tireList = new List<Tire[]>();
            List<Engine> engineList = new List<Engine>();
            List<Car> cars = new List<Car>();
            while (comand != "No more tires")
            {
                string[] elements = Console.ReadLine().Split();
                var tempListOfTires = new List<Tire>();
                for (int i = 0; i < 8; i += 2)
                {
                    int year = int.Parse(elements[i]);
                    double pressure = double.Parse(elements[i + 1]);
                    var currentTire = new Tire(year, pressure);
                    tempListOfTires.Add(currentTire);
                }

                var currentArrayOfTires = tempListOfTires.ToArray();
                tireList.Add(currentArrayOfTires);
                comand = Console.ReadLine();
            }
            string input = Console.ReadLine();

            while (input != "Engines done")
            {
                string[] elements = Console.ReadLine().Split();
                int horsePower = int.Parse(elements[0]);
                double cubicCapacity = double.Parse(elements[1]);
                Engine engine = new Engine(horsePower, cubicCapacity);
                engineList.Add(engine);

                input = Console.ReadLine();
            }
            string cmdArg = Console.ReadLine();

            while (cmdArg != "Show special")
            {
                string[] elements = Console.ReadLine().Split();
                string make = elements[0];
                string model = elements[1];
                int year = int.Parse(elements[2]);
                double fuelQuantity = double.Parse(elements[3]);
                double fuelConsumption = double.Parse(elements[4]);
                int engineIndex = int.Parse(elements[5]);
                int tiresIndex = int.Parse(elements[6]);
                Car newCar = new Car(make, model, year, fuelQuantity, fuelConsumption, engineList[engineIndex], tireList[tiresIndex]);
                cars.Add(newCar);


                cmdArg = Console.ReadLine();
            }
            var filterCars = cars.Where(car => car.Year >= 2017 && car.Engine.HorsePower > 330).ToList();
            foreach (var car in filterCars)
            {
                double sumOfPressure = 0;
                foreach (var tire in car.Tires)
                {
                    sumOfPressure += tire.Pressure;
                }

                if (sumOfPressure >= 9 && sumOfPressure <= 10)
                {
                    car.Drive(20);
                    Console.WriteLine(car.WhoAmI());
                }
            }
        }
    }
}
