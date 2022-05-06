using System;
using System.Collections.Generic;
using System.Text;

namespace CarProjectsPractice1
{
    class Car
    {
        public int registrationNumber;
        private string model;
        private DateTime year;
        private int maxSpeed;
        private int minSpeed;
        private int fuelLevel;
        private int waterLevel;
        private int oilLevel;
        private string color;
        private string type;
        private int numberDoors { get; set; }

        public static string softwareVersion { get; set; } = "sddsad01";

        public Car(int registrationNumber, string model, DateTime year, int maxSpeed, int minSpeed,
                   int fuelLevel, int waterLevel, int oilLevel, string color, string type, int numberDoors)
        {
            this.registrationNumber = registrationNumber;
            this.model = model;
            this.year = year;
            this.maxSpeed = maxSpeed;
            this.minSpeed = minSpeed;
            this.fuelLevel = fuelLevel;
            this.waterLevel = waterLevel;
            this.oilLevel = oilLevel;
            this.color = color;
            this.type = type;
            this.numberDoors = numberDoors;
        }

        public void advanceCar(int fuelwasted, int waterwasted, int oilwasted)
        {
            int totalFuelreminder = this.fuelLevel - fuelwasted;
            int totalwaterreminder = this.waterLevel - waterwasted;
            int totaloilreminder = this.oilLevel - oilwasted;


            if (totalFuelreminder < 0 || totalwaterreminder < 0 || totaloilreminder < 0)
            {
                Console.WriteLine("you can't advance you don't have enough fuel, waiter or oil. This is a message from ABS system  ");
            }
            else if (totalFuelreminder == 0 || totalwaterreminder == 0 || totaloilreminder == 0) {
                this.fuelLevel = totalFuelreminder;
                this.waterLevel = totalwaterreminder;
                this.oilLevel = totaloilreminder;

                this.noFuel();
                this.noWater();
                this.noOil();
            }
            else {
                this.fuelLevel = totalFuelreminder;
                this.waterLevel = totalwaterreminder;
                this.oilLevel = totaloilreminder;
                Console.WriteLine( "you can advance it remnids " + totalFuelreminder + " of fuel" + totalwaterreminder + " of water and "
                    + totaloilreminder + " of oil");
            }
        }

        public string addFuel(int moreFuel) {
            this.fuelLevel = this.fuelLevel + moreFuel;
            return "fuel added success";
        }

        public string addWater(int moreWater)
        {
            this.waterLevel = this.waterLevel + moreWater;
            return "Water added success";
        }

        public string addOil(int moreOil)
        {
            this.oilLevel = this.oilLevel + moreOil;
            return "Oil added success";
        }

        private void noFuel() {
            if (this.fuelLevel == 0) {
                Console.WriteLine( "fuel level 0 this is a warning message");
            }
        }

        private void noWater() {
            if (this.waterLevel == 0)
                Console.WriteLine("Watter level is 0 this is a warning message");
        }

        private void noOil() {
            if (this.oilLevel == 0)
                Console.WriteLine("Oil level is 0 this is a warning message");
        }
        public static string getNothing() {
            return softwareVersion;
        }
    }
}
