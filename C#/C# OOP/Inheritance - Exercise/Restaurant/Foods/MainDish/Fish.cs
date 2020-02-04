namespace Restaurant.Foods.MainDish
{
    public class Fish : MainDish
    {
        private const double FishGrams = 22d;

        public Fish(string name, decimal price)
            : base(name, price, FishGrams)
        {

        }
    }
}