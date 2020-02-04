namespace MXGP.Models.Motorcycles
{
    using System;

    public class SpeedMotorcycle : Motorcycle
    {
        private const double cubicCentm = 125d;
        private int horsePower;
        public SpeedMotorcycle(string model, int horsePower)
            : base(model, horsePower, cubicCentm)
        {
        }

        public override int HorsePower
        {
            get => this.horsePower;
            protected set
            {
                if (value < 50 && value > 69)
                {
                    throw new ArgumentException($"Invalid horse power: {value}.");
                }

                this.horsePower = value;
            }
        }
    }
}
