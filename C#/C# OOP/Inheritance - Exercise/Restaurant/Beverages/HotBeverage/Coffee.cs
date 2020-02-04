namespace Restaurant.Beverages.HotBeverage
{
    public class Coffee : HotBeverage
    {
        private const double CoffeeMilliliters = 50d;
        private const decimal CoffeePrice = 3.50m;

        public Coffee(string name, double caffeine)
            : base(name, CoffeePrice, CoffeeMilliliters)
        {
            this.Caffeine = caffeine;
        }

        public double Caffeine { get; set; }
    }
}