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
            Car simpleCar2 = new Car(002, "Toyota linux", today2, 80, 20, 50, 30, 20, "red", "gas", 4);
            
            Console.WriteLine(simpleCar.registrationNumber);
            Console.WriteLine("---------------------asASasASas-------------------");
            Console.WriteLine(simpleCar2.registrationNumber);

            Car.softwareVersion = "asdas0.2";
            Console.WriteLine(Car.softwareVersion);
           
        }
    }
}
