using System;
using System.Collections.Generic;
using System.Text;

namespace CarProjectsPractice1
{
    class Car
    {
        public int registrationNumber;
        private string model ;
        private DateTime year;
        private int maxSpeed;
        private int minSpeed;
        private string color;
        private string type;
        private int numberDoors;
        private int fuelLevel { get; set; }
        private int waterLevel { get; set; }
        private int oilLevel { get; set; }
        internal static string softwareVersion { get; set; } = "001";

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

        public void advanceCar(int fuelWasted, int waterWasted, int oilWasted)
        {
            int totalFuelRemaining = this.fuelLevel - fuelWasted;
            int totalWaterRemaining = this.waterLevel - waterWasted;
            int totalOilRemaining = this.oilLevel - oilWasted;


            if (totalFuelRemaining < 0 || totalWaterRemaining < 0 || totalOilRemaining < 0)
            {
                Console.WriteLine("You can't advance and you don't have enough fuel, waiter or oil. This is a message from ABS system  ");
            }
            else if (totalFuelRemaining == 0 || totalWaterRemaining == 0 || totalOilRemaining == 0) {
                this.fuelLevel = totalFuelRemaining;
                this.waterLevel = totalWaterRemaining;
                this.oilLevel = totalOilRemaining;

                this.noFuel();
                this.noWater();
                this.noOil();
            }
            else {
                this.fuelLevel = totalFuelRemaining;
                this.waterLevel = totalWaterRemaining;
                this.oilLevel = totalOilRemaining;
                Console.WriteLine("you can advance! It is remaining " + totalFuelRemaining + " of fuel, " + totalWaterRemaining + " of water and "
                    + totalOilRemaining + " of oil");
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
    }
}
