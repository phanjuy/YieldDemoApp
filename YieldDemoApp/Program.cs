using System;
using System.Linq;

namespace YieldDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of the App");

            var people = DataAccess.GetPeople().Take(2);

            foreach (var p in people)
            {
                Console.WriteLine($"Read {p.FirstName} {p.LastName}");
            }

            var primeNumbers30000 = Generators.GetPrimeNumbers().Take(30000);

            foreach (var prime in primeNumbers30000)
            {
                Console.WriteLine(prime);
            }

            Console.WriteLine("End of the App");
        }
    }
}
