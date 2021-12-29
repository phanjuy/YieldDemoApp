using System.Collections.Generic;

namespace YieldDemoApp
{
    public class Generators
    {
        public static IEnumerable<int> GetPrimeNumbers()
        {
            int number = 1;

            while (true)
            {
                if (IsPrimeNumber(number))
                {
                    yield return number;
                }
                number++;
            }
        }

        private static bool IsPrimeNumber(int value)
        {
            var output = true;

            for (int i = 2; i < value / 2; i++)
            {
                if (value % i == 0)
                {
                    output = false;
                    break;
                }
            }

            return output;
        }
    }
}