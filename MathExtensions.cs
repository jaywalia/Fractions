using System;
using System.Collections.Generic;

namespace Fractions
{
    public class MathExtensions
    {
        internal static int LCM(int x, int y)
        {
            // get prime factors of x
            // get prime factors of y
            // get distinct factors ???? Are these really distinct
            return x*y;

        }

        //https://stackoverflow.com/questions/18541832/c-sharp-find-the-greatest-common-divisor
        //https://en.wikipedia.org/wiki/Euclidean_algorithm
        internal static  int GCD(int x, int y)
        {
            // get prime factor list of x
            // get prime factor list of y
            // find common factors
            return 1;
        }

        internal static  List<int> PrimeFactors(int x)
        {
            List<int> pf = new List<int>();

            //if even, loop till not even any more
            while(IsEven(x))
            {
                //Console.WriteLine(x);
                x >>= 1; // shift right is divide by zero
                pf.Add(2);
            }

            // now handle odd
            // start with the smallest odd prime 
            // and work upto half of number
            PrimeProvider pp = new PrimeProvider();
            foreach (int p in pp.StepPrimes())
            {
                //Console.WriteLine($"x : {x} :: p: {p}");
                if (p > x) break;
                while ( x % p == 0)
                {
                    x /= p;
                    pf.Add(p);
                }
            }
            return pf;
        }

        internal static bool IsEven(int n)
        {
            return n % 2 == 0;
        }

        internal static List<int> CommonElements(List<int> l, List<int> r)
        {
            List<int> ce = new List<int>();
            return ce;
        }
    }

}