namespace Generic_Box_of_Integer
{
    public class Box<T>
    {
        private T item;

        public Box(T number)
        {
            this.item = number;
        }

        public override string ToString()
        {
            return $"{this.item.GetType().FullName}: {this.item}";
        }
    }
}