using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkN9
{
    public class Fraction
    {
        private int _numerator;
        private int _denominator;

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be 0.");
            }
            _numerator = numerator;
            _denominator = denominator;
        }

        public override string ToString()
        {
            return $"{_numerator}/{_denominator}";
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            int commonDenominator = f1._denominator * f2._denominator;
            int numeratorSum = f1._numerator * f2._denominator + f2._numerator * f1._denominator;
            return new Fraction(numeratorSum, commonDenominator);
        }

        public static bool operator ==(Fraction f1, Fraction f2)
        {
            return f1._numerator * f2._denominator == f2._numerator * f1._denominator;
        }

        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return !(f1 == f2);
        }
    }
}
