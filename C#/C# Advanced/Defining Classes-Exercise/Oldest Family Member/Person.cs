
namespace DefiningClasses
{
    public class Person
    {
        public string name;
        public int age;

        public string Name
        {
            get => this.name;
            set => this.name = value;

        }

        public int Age
        {
            get => this.age;
            set => this.age = value;
        }
        
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}