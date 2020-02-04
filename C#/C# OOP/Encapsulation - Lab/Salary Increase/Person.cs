namespace PersonsInfo
{
    public class Person
    {
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public decimal Salary { get; set; }

        public void IncreaseSalary(decimal parcentage)
        {
            this.Salary += this.Salary * parcentage / 100;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary:f2} leva.";
        }
    }
}