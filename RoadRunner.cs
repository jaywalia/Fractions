using System;
using System.Diagnostics;

namespace Fractions
{

    public class RoadRunner
    {
        internal static void RunTests()
        {
            Console.WriteLine("Running tests.....");
            //Test_MathConcepts();
            Test_Fractions();

            Console.WriteLine("Tests over...");
        }

        internal static void Test_LCM()
        {
            Debug.Assert(48 == MathExtensions.LCM(12, 16));
        }

        internal static void Test_MathConcepts()
        {
            Test_LCM();
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

