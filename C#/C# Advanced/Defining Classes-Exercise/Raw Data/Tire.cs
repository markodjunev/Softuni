﻿
namespace DefiningClasses
{
    public class Tire
    {
        public double TirePressure { get; set; }

        public int TireAge { get; set; }


        public Tire(double tirePressure, int tireAge)
        {
            this.TirePressure = tirePressure;
            this.TireAge = tireAge;
        }

    }
}