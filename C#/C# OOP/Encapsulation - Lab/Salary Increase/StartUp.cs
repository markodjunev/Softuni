namespace PersonsInfo
{
    using System;
    using System.Collections.Generic;

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
                var salary = decimal.Parse(input[3]);
                var person = new Person(firstName, lastName, age, salary);
                people.Add(person);
            }

            var parcentage = decimal.Parse(Console.ReadLine());
            people.ForEach(p => p.IncreaseSalary(parcentage));
            people.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}