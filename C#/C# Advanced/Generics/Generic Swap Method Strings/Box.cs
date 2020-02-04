﻿using System.Collections.Generic;
using System.Text;

namespace Generic_Swap_Method_Strings
{
    public class Box<T>
    {
        private IList<T> data;
        private T element;

        public Box()
        {
            this.data = new List<T>();
        }      

        public void Add(T element)
        {
            this.element = element;
            this.data.Add(element);
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            var firstElement = this.data[firstIndex];
            data[firstIndex] = data[secondIndex];
            data[secondIndex] = firstElement;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var element in this.data)
            {
                sb.AppendLine($"{element.GetType().FullName}: {element}");
            }
            return sb.ToString().Trim();
        }
    }
}