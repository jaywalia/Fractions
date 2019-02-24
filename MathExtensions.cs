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
            return pf;
        }

        internal static List<int> CommonElements(List<int> l, List<int> r)
        {
            List<int> ce = new List<int>();
            return ce;
        }
    }

}