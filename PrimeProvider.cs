using System;
using System.Collections.Generic;
using System.Linq;

namespace Fractions
{
    // https://handcraftsman.wordpress.com/2010/09/02/ienumerable-of-prime-numbers-in-csharp/
    public class PrimeProvider
    {
        public IEnumerable<int> Primes()
        {
            var memoized = new List<int>();
            var primes = PotentialPrimes().Where(x =>
                {
                    // https://math.stackexchange.com/questions/1343171/why-only-square-root-approach-to-check-number-is-prime
                    double sqrt = Math.Sqrt(x);
                    return !memoized
                                .TakeWhile(y => y <= sqrt)
                                .Any(y => x % y == 0);
                });

            foreach (var prime in primes)
            {
                Console.WriteLine(prime);
                yield return prime;
                memoized.Add(prime);
            }
        }

        public IEnumerable<int> StepPrimes()
        {
            bool isPrime = true;
            var memoized = new List<int>();
            foreach (int x in PotentialPrimes())
            {
                double sqrt = Math.Sqrt(x);
                isPrime =  !memoized
                                .TakeWhile(y => y <= sqrt)
                                .Any(y => x % y == 0);
                if( isPrime )
                {
                    yield return x;
                    memoized.Add(x);
                }
            }
        }

        public IEnumerable<int> Naturals()
        {
            int i = 1;
            while (i > 0)
            {
                yield return i;
                i++;
            }
        }

        public IEnumerable<int> Even()
        {
            foreach (int n in Naturals())
            {
                if (n % 2 == 0)
                    yield return n;
            }
        }

        public IEnumerable<int> PotentialPrimes()
        {
            yield return 2;
            yield return 3;
            int k = 1;
            while (k > 0 && k < 15)
            {
                yield return 6 * k - 1;
                yield return 6 * k + 1;
                k++;
            }
        }
    }

}