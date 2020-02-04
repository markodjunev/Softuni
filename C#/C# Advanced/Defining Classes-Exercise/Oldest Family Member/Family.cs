using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> familyMembers;


        public Family()
        {
            this.familyMembers = new List<Person>();
        }


        public void AddMember(Person member)
        {
            this.familyMembers.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.familyMembers.OrderByDescending(p => p.age).FirstOrDefault();
        }
    }
}