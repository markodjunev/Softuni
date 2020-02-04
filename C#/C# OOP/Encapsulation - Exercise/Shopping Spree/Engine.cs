namespace Shopping_Spree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine
    {
        private List<Person> people;
        private List<Product> products;
        public Engine()
        {
            this.people = new List<Person>();
            this.products = new List<Product>();
        }

        public void Run()
        {
            try
            {
                ReadPersonInfo();
                ReadProductInfo();
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine(exception.Message);
            }

            var command = Console.ReadLine();

            while (command != "END")
            {
                var tokens = command.Split();
                var personName = tokens[0];
                var productName = tokens[1];

                var member = people.FirstOrDefault(p => p.Name == personName);
                var product = products.FirstOrDefault(p => p.Name == productName);

                Console.WriteLine(member.BuyProduct(product));


                command = Console.ReadLine();
            }
            foreach (var man in people)
            {
                Console.WriteLine(man);
            }
        }
     
        private void ReadPersonInfo()
        {
            var personTokens = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var info in personTokens)
            {
                var split = info.Split('=');
                var name = split[0];
                var money = decimal.Parse(split[1]);
                var person = new Person(name, money);

                people.Add(person);
            }
        }

        private void ReadProductInfo()
        {
            var productsTokens = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries).ToArray();

               foreach (var info in productsTokens)
               {
                   var split = info.Split('=');
                   var name = split[0];
                   var cost = decimal.Parse(split[1]);
                   var product = new Product(name, cost);

                   products.Add(product);
               }
        }
    }
}