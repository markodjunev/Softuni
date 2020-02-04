using System;

namespace VehiclesExtension
{
    public abstract class Vehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumption, int tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        protected double FuelQuantity { get; set; }

        protected double FuelConsumption { get; set; }

        protected abstract double AdditionalConsumption { get; }

        protected int TankCapacity { get; set; }

        public string Drive(double distance)
        {
            double requiredFuel = (this.FuelConsumption + this.AdditionalConsumption) * distance;

            if (requiredFuel <= this.FuelQuantity)
            {
                this.FuelQuantity -= requiredFuel;
                return $"{this.GetType().Name} travelled {distance} km";
            }

            return $"{this.GetType().Name} needs refueling";
        }

        public virtual void Refuel(double fuel)
        {
            if (fuel <= 0)
                Console.WriteLine("Fuel must be a positive number");  
            else if (this.FuelQuantity + fuel > this.TankCapacity)
                Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
            else
                this.FuelQuantity += fuel;           
        }

        public virtual void IsEmpty(string info)
        {
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
    }
}