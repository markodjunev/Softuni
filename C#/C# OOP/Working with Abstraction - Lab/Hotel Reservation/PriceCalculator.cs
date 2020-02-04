namespace Hotel_Reservation
{
    public class PriceCalculator
    {
        private decimal pricePerDay;
        private int numberOfDays;
        private Season season;
        private DiscountType discountType;

        public PriceCalculator(decimal pricePerDay, int numberOfDays, Season season, DiscountType discountType)
        {
            this.pricePerDay = pricePerDay;
            this.numberOfDays = numberOfDays;
            this.season = season;
            this.discountType = discountType;
        }

        public decimal CalculatePrice()
        {
            decimal price = this.numberOfDays * this.pricePerDay * (decimal)this.season;
            price -= price * ((decimal)this.discountType / 100);
            return price;
        }
    }
}