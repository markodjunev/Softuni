namespace VehiclesExtension
{
    public class Bus : Vehicle
    {
        private double additionalConsumptionPerKm;
        public Bus(double fuelQuantity, double fuelConsumption, int tankCapacity) 
            : base (fuelQuantity,fuelConsumption, tankCapacity)
        {            
        }

        protected override double AdditionalConsumption => additionalConsumptionPerKm;

        public override void IsEmpty(string busInfo)
        {
            if (busInfo == "DriveEmpty")
                this.additionalConsumptionPerKm = 0;
            else if (busInfo == "Drive")
                this.additionalConsumptionPerKm = 1.4;
        }
    }
}