using System;

namespace Elevator
{
    class Elevator
    {
        static void Main()
        {
            var numOfPeople = double.Parse(Console.ReadLine());
            var capacity = double.Parse(Console.ReadLine());
            if (numOfPeople % capacity == 0) Console.WriteLine(numOfPeople / capacity);

            else
            {
                var fullCourses = Math.Floor(numOfPeople / capacity);
                var rest = 1;
                Console.WriteLine(fullCourses+rest);
                //var fullCourses = numOfPeople / capacity;
                //var rest = numOfPeople - (capacity * fullCourses);
                //Console.WriteLine(Math.Ceiling(fullCourses + rest));
            }
        }
    }
}