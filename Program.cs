using System;
using System.Collections.Generic;
using System.Text;

namespace Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to world of fractions!");
            Fraction f = new Fraction(-2, -3);
            Fraction g = new Fraction(-3, -4);

            Fraction fg = f.Mul(g);

            Console.WriteLine($"{f} * {g} = {fg}");
        }


        
    }

    class Fraction
    {
        public Fraction(int n, int d) 
        {
            N = n;
            D = d;
        }
 
        public int N {get;}
        public int D {get;}

        public int AbsN => Math.Abs(N);
        public int AbsD => Math.Abs(D);
        public bool IsImproper => N > D;
        public bool IsInSimpleForm()
        {
            throw new NotImplementedException();
        }

        Fraction Add(Fraction f)
        {
            // 2 add
            // get gcd of denominators lcm = lcm (D, f.D)
            // find multiples for numerators N = lcm *N 
            // set common denomiator and sum of 
            return f;
        }

        Fraction Simplify()
        {
            // f;
            // 
            return this;
        }

        Fraction Sub(Fraction f) => Add(Neg(f));
        Fraction Inv(Fraction f) => new Fraction(D,N);
        Fraction Neg(Fraction f) => new Fraction(-f.N, f.D);

        public Fraction Mul(Fraction f) => new Fraction(N*f.N, D*f.D);

        public Fraction Div(Fraction f) => Mul(Inv(f));

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if( Sign == Sign.Negative ) sb.Append("-");
            sb.Append( AbsN + "/" + AbsD);
            return sb.ToString();
        }

        public Sign Sign
        {
            get
            {
                Sign s = Sign.Negative;
                // either both N&D are +, OR both are -
                if( N >= 0 && D >= 0 || N < 0 && D < 0 ) s = Sign.Positive;
                return s;  
            }
        }

    }

    internal enum Sign
    {
        Positive = 0,
        Negative = 1
    }

    internal class MathHelper
    {
        public int LCM(int x, int y)
        {
            // get prime factors of x
            // get prime factors of y
            // get distinct factors ???? Are these really distinct
            return x*y;

        }
        public int GCD(int x, int y)
        {
            // get prime factor list of x
            // get prime factor list of y
            // find common factors
            return 1;
        }

        public List<int> PrimeFactors(int x)
        {
            List<int> pf = new List<int>();
            return pf;
        }

        public List<int> CommonElements(List<int> l, List<int> r)
        {
            List<int> ce = new List<int>();
            return ce;
        }
    }
}
