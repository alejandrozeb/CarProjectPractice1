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

        public static string getNothing() {
            return softwareVersion;
        }
    }
}
