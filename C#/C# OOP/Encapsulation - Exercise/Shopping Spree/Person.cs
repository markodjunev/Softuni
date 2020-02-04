namespace Shopping_Spree
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bagOfProducts;

        private Person()
        {
            this.bagOfProducts = new List<Product>();
        }

        public Person(string name, decimal money) 
            : this()
        {
            this.Name = name;
            this.Money = money;
        }

        public string Name
        {
            get => this.name;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get => this.money;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.money = value;
            }
        }


        public string BuyProduct(Product product)
        {
            decimal moneyLeft = this.Money - product.Cost;

            if (moneyLeft < 0)
            {
                return string.Format($"{this.Name} can't afford {product.Name}");
            }

            this.Money -= product.Cost;
            this.bagOfProducts.Add(product);
            return $"{this.name} bought {product.Name}";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            if (this.bagOfProducts.Count == 0)
            {
                sb.AppendLine($"{this.Name} - Nothing bought");
            }
            else
            {
                var productsNames = new List<string>();

                this.bagOfProducts.ForEach(p => productsNames.Add(p.Name));

                sb.Append($"{this.Name} - {string.Join(", ", productsNames)}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}