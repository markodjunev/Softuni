namespace PersonsInfo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var firstName = input[0];
                var lastName = input[1];
                var age = int.Parse(input[2]);

                var person = new Person(firstName, lastName, age);
                people.Add(person);
            }

            people.OrderBy(p => p.FirstName)
                .ThenBy(p => p.Age)
                .ToList()
                .ForEach(p => Console.WriteLine(p.ToString()));

        }
    }
}