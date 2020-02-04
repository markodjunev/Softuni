using System;
using System.Collections.Generic;
using System.Linq;

namespace Opinion_Poll
{
    public class StartUp
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            var people = new Family();
            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split();
                var name = input[0];
                var age = int.Parse(input[1]);
                var person = new Person(name, age);
                people.AddMember(person);
            }

            var filteredMembers = people.GetFilteredMembers();

            foreach (var member in filteredMembers)
            {
                Console.WriteLine($"{member.Name} - {member.Age}");
            }

        }
    }
}