namespace BirthdayCelebrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var all = new List<IBirthdate>();
            while (input != "End")
            {
                var tokens = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                switch (tokens[0])
                {
                    case "Citizen":
                        all.Add(new Citizen(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]));
                        break;
                    case "Pet":
                        all.Add(new Pet(tokens[1], tokens[2]));
                        break;
                }
                input = Console.ReadLine();
            }

            var year = int.Parse(Console.ReadLine());

            
            all.Where(c => c.Birthdate.Year == year)
                .Select(c => c.Birthdate)
                .ToList()
                .ForEach(dt => Console.WriteLine($"{dt:dd/MM/yyyy}"));
        }
    }
}