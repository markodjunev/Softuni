namespace Animals
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public string FavoriteFood { get; set; }

        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my fovourite food is {this.FavoriteFood}";
        }
    }
}