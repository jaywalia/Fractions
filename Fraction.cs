using System;
using System.Text;

namespace Fractions
{
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

        public bool IsEquals(Fraction f)
        {
            return ( this.Sign == f.Sign 
                    && this.AbsN == f.AbsN 
                    && this.AbsD == f.AbsD );
        }

    }

}