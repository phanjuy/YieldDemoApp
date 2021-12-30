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

            var primeNumbers = Generators.GetPrimeNumbers();

            using var iterator = primeNumbers.GetEnumerator();

            for (int i = 0; i < 10; i++)
            {
                if (iterator.MoveNext())
                {
                    Console.WriteLine(iterator.Current);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Waiting for user input");
            Console.ReadLine();

            for (int i = 0; i < 15; i++)
            {
                if (iterator.MoveNext())
                {
                    Console.WriteLine(iterator.Current);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("End of the App");
        }
    }
}
