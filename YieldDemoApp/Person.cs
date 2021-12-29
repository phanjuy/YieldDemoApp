using System;

namespace YieldDemoApp
{
    public class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Console.WriteLine($"Initialized user { FirstName } { LastName }");
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}