namespace Class_Box_Data.Models
{
    using System;
    using System.Text;
    using Class_Box_Data.Exceptions;

    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get => this.length;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessage.LengthZeroOrNegativeNumber);
                }
                this.length = value;
            }
        }

        public double Width
        {
            get => this.width;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessage.WidthZeroOrNegativeNumber);
                }

                this.width = value;
            }
        }

        public double Height
        {
            get => this.height;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessage.HeightZeroOrNegativeNumber);
                }

                this.height = value;
            }
        }


        public double SurfaceArea()
        {
            double surfaceArea = 2 * (this.Length * this.Width) + this.LateralSurfaceArea();
            return surfaceArea;
        }

        public double LateralSurfaceArea()
        {
            double lateralSurfaceArea = 2 * (this.Length * this.Height) + 2 * (this.Width * this.Height);
            return lateralSurfaceArea;
        }

        public double Volume()
        {
            double volume = this.Length * this.Width * this.Height;
            return volume;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {this.SurfaceArea():f2}");
            sb.AppendLine($"Lateral Surface Area - {this.LateralSurfaceArea():f2}");
            sb.AppendLine($"Volume - {this.Volume():f2}");

            return sb.ToString();
        }
    }
}