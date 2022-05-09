using System;

namespace CarProjectsPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = new DateTime(2015, 12, 25, 10, 30, 45);
            Car simpleCar = new Car(001, "Toyota Jeep", today, 80, 20, 50, 30, 20, "red", "gas", 4);
            

            DateTime today2 = new DateTime(2016, 12, 26, 11, 30, 45);
            Car simpleCar2 = new Car(002, "Toyota Hilux", today2, 80, 20, 50, 30, 20, "red", "gas", 4);

            Console.WriteLine("----------- Instanced Cars-----------------");
            Console.WriteLine(simpleCar.registrationNumber);
            Console.WriteLine(simpleCar2.registrationNumber);

            Console.WriteLine("-----------Updated Software---------------");
            Car.softwareVersion = "0.02";
            Console.WriteLine(Car.softwareVersion);

            Console.WriteLine("------------------Car Advance------------");
            simpleCar.advanceCar(1, 1, 1);
            simpleCar2.advanceCar(100, 1, 1);

            Console.WriteLine("----------------Add fuel, water and oil-------------------------");
            Console.WriteLine(simpleCar.addFuel(20));
            Console.WriteLine(simpleCar.addWater(100));
            Console.WriteLine(simpleCar.addOil(30));

            Console.WriteLine("----------------------Automated message-----------------");
            DateTime today3 = new DateTime(2016, 12, 26, 11, 30, 45);
            Car simpleCar3 = new Car(002, "Toyota Hilux", today2, 80, 20, 50, 30, 20, "red", "gas", 4);

            simpleCar3.advanceCar(50, 30, 20);
            simpleCar3.advanceCar(2, 1, 1);
        }
    }
}
