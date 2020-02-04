using System.Collections.Generic;
using System.Text;

namespace Generic_Swap_Method_Integers
{
    public class Box<T>
    {
        private List<T> numbers;

        public Box()
        {
            this.numbers = new List<T>();
        }

        public void Add(T num)
        {
            this.numbers.Add(num);
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            var temp = this.numbers[firstIndex];
            numbers[firstIndex] = this.numbers[secondIndex];
            numbers[secondIndex] = temp;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var element in this.numbers)
            {
                sb.AppendLine($"{element.GetType().FullName}: {element}");
            }
            return sb.ToString().Trim();
        }
    }
}