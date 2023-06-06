using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Calculator
    {
        
        public double A { get; set; }
        public double B { get; set; }

        public Calculator(double a, double b)
        {
            A = a;
            B = b;
        }
        public override string? ToString()
        {
            if (B > 0)
                return A + "+" + B;
            else if (B < 0)
                return A + "-" + Math.Abs(B);
            return A.ToString();
        }
        public static Calculator operator +(Calculator c1, Calculator c2)
        {
            return new Calculator(c1.A + c2.A, c2.B + c2.B);
        }
        public static Calculator operator -(Calculator c1, Calculator c2)
        {
            return new Calculator(c1.A - c2.A, c2.B - c2.B);
        }
        public static Calculator operator *(Calculator c1, Calculator c2)
        {
            return new Calculator(c1.A * c2.A - c1.B * c2.B,
                c1.A * c2.B - c2.A * c1.B);
        }
        public static Calculator operator /(Calculator c1, Calculator c2)
        {
            return new Calculator((c1.A * c2.A - c1.B * c2.B) / (c2.B * c2.B + c2.A * c2.A),
                            (c1.A * c2.B - c2.A * c1.B) / (c2.B * c2.B + c2.A * c2.A));
        }
        public static bool operator ==(Calculator c1, Calculator c2)
        {
            return (c1.A == c2.A) && (c1.B == c2.B);
        }
        public static bool operator !=(Calculator c1, Calculator c2)
        {
            return (c1.A != c2.A) || (c1.B != c2.B);
        }
    }
}