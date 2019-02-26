using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace Fractions
{

    public class RoadRunner
    {
        internal static void RunTests()
        {
            Console.WriteLine("Running tests.....");
            Test_MathConcepts();
            //Test_Fractions();

            Console.WriteLine("Tests over...");
        }

        internal static void Test_LCM()
        {
            Debug.Assert(48 == MathExtensions.LCM(12, 16));
        }

        internal static void Test_MathConcepts()
        {
            //Test_LCM();
            Test_PrimeFactors(600);
            //Test_YieldConcept();
            //Test_StepPrime();
        }

        internal static void Test_StepPrime()
        {
            PrimeProvider pp = new PrimeProvider();
            foreach(int i in pp.StepPrimes())
            {
                Console.WriteLine($"i : {i}");
                if( i > 100 ) break;
            }
        }
        internal static void Test_YieldConcept()
        {
            PrimeProvider pp = new PrimeProvider();
            foreach(int i in pp.Even())
            {
                Console.WriteLine(i);
                if( i > 100 ) break;
            }
        }

        internal static void Test_PrimeFactors(int n)
        {
            List<int> li = MathExtensions.PrimeFactors(n);
            foreach(int i in li) { Console.Write(i + ","); }
            Console.WriteLine();
        }

        internal static void Test_Fractions()
        {
            Fraction f = new Fraction(-2, -3);
            Fraction g = new Fraction(-3, -4);
            Fraction m = new Fraction(6, 12);

            Test_Fraction_Mul(f, g, m);
        }

        internal static void Test_Fraction_Mul(Fraction f, Fraction g, Fraction a)
        {
            Console.WriteLine($"{f} * {g} = {f.Mul(g)}");
            Debug.Assert(a.IsEquals(f.Mul(g)));
        }

    }
}

