namespace Animals
{
    public class Cat : Animal
    {
        public Cat(string name, string favoriteFood)
        {
            this.Name = name;
            this.FavoriteFood = favoriteFood;
        }

        public override string ExplainSelf()
        {
            return base.ExplainSelf() + " MEEOW";
        }
    }
}