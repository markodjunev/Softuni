namespace MXGP.Models.Motorcycles
{
    using System;

    public class PowerMotorcycle : Motorcycle
    {
        private const double cubicCentm = 450d;
        private int horsePower;
        public PowerMotorcycle(string model, int horsePower) 
            : base(model, horsePower, cubicCentm)
        {
        }

        public override int HorsePower
        {
            get => this.horsePower;
            protected set
            {
                if (value < 70 && value > 100)
                {
                    throw new ArgumentException($"Invalid horse power: {value}.");
                }

                this.horsePower = value;
            }
        }
    }
}