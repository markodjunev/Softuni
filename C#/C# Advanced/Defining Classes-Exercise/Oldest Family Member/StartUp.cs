using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            Family familyMembers = new Family();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                string name = tokens[0];
                int age = int.Parse(tokens[1]);

                familyMembers.AddMember(new Person(name, age));
            }

            Person oldestMember = familyMembers.GetOldestMember();
            Console.WriteLine("{0} {1}", oldestMember.name, oldestMember.age);
        }
    }
}