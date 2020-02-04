using System;

namespace VehiclesExtension
{
    public class Truck : Vehicle
    {
        private const double additionalConsumptionPerKm = 1.6;
        private const double refuelingCoefficient = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption, int tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        protected override double AdditionalConsumption => additionalConsumptionPerKm;

        public override void Refuel(double fuel)
        {
            if (fuel <= 0)
                Console.WriteLine("Fuel must be a positive number");
            else if (this.FuelQuantity + fuel > this.TankCapacity)
                Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
            else
                this.FuelQuantity += fuel * refuelingCoefficient;
        }
    }
}