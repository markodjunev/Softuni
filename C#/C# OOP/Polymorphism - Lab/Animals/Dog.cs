namespace Animals
{
    public class Dog : Animal
    {
        public Dog(string name, string favoriteFood)
        {
            this.Name = name;
            this.FavoriteFood = favoriteFood;
        }

        public override string ExplainSelf()
        {
            return base.ExplainSelf() + " DJAAF";
        }
    }
}