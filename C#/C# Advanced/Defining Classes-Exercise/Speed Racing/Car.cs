
namespace Speed_Racing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;

        public string Model
        {
            get => this.model;
            set => this.model = value;
        }

        public double FuelAmount
        {
            get => this.fuelAmount;
            set => this.fuelAmount = value;
        }

        public double FuelConsumptionPerKilometer
        {
            get => this.fuelConsumptionPerKilometer;
            set => this.fuelConsumptionPerKilometer = value;
        }

        public double TravelledDistance
        {
            get => this.travelledDistance;
            set => this.travelledDistance = value;
        }


        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.TravelledDistance = 0;
        }


        public bool Drive(double amountOfKm)
        {
            if (amountOfKm * fuelConsumptionPerKilometer <= fuelAmount)
            {
                fuelAmount -= amountOfKm * fuelConsumptionPerKilometer;
                travelledDistance += amountOfKm;
                return true;
            }

            return false;
        }

    }
}