using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Count_Method_Strings
{
    public class Box<T>
      where T: IComparable<T>
    {
        private IList<T> data;

        public IList<T> Data => this.data;

        public Box()
        {
            this.data = new List<T>();
        }

        public void Add(T element)
        {
            this.data.Add(element);
        }

        public int Compare(IList<T> elements, string wordComparison)
        {
            int count = 0;

            foreach (var item in elements)
            {
                if (wordComparison.CompareTo(item) < 0)
                {
                    count++;
                }
            }

            return count;
        }

    }
}