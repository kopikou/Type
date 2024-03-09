using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type
{
    public class Fraction
    {
        private int numerator;
        private int denominator;
        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        
        public string FractionValue(){
            return String.Format("{0} / {1}", this.numerator, this.denominator);
        }
        public static Fraction operator+(Fraction frac1,Fraction frac2)
        {
            int newNumerator;
            int newDenominator;
            if (frac1.denominator == frac2.denominator)
            {
                newNumerator = frac1.numerator + frac2.numerator;
                newDenominator = frac1.denominator;
            }
            else
            {
                newNumerator = frac1.numerator*frac2.denominator + frac2.numerator*frac1.denominator;
                newDenominator = frac1.denominator * frac2.denominator;
            }
            var frac = new Fraction(newNumerator, newDenominator);
            return frac;
        }
        public static Fraction operator -(Fraction frac1, Fraction frac2)
        {
            int newNumerator;
            int newDenominator;
            if (frac1.denominator == frac2.denominator)
            {
                newNumerator = frac1.numerator - frac2.numerator;
                newDenominator = frac1.denominator;
            }
            else
            {
                newNumerator = frac1.numerator * frac2.denominator - frac2.numerator * frac1.denominator;
                newDenominator = frac1.denominator * frac2.denominator;
            }
            var frac = new Fraction(newNumerator, newDenominator);
            return frac;
        }
        public static Fraction operator *(Fraction frac1, Fraction frac2)
        {
            int newNumerator;
            int newDenominator;
            newNumerator = frac1.numerator * frac2.numerator;
            newDenominator = frac1.denominator * frac2.denominator;

            var frac = new Fraction(newNumerator, newDenominator);
            return frac;
        }
        public static Fraction operator /(Fraction frac1, Fraction frac2)
        {
            int newNumerator;
            int newDenominator;
            newNumerator = frac1.numerator * frac2.denominator;
            newDenominator = frac1.denominator * frac2.numerator;

            var frac = new Fraction(newNumerator, newDenominator);
            return frac;
        }
        public Fraction Reduction(Fraction frac)
        {
            var gcd = GCD(frac.numerator,frac.denominator);
            var newNumerator = frac.numerator / gcd;
            var newDenominator = frac.denominator / gcd;
            var newFrac = new Fraction(newNumerator, newDenominator);
            return newFrac;
        }
        private static int GCD(int numb1, int numb2)
        {
            while(numb2 != 0)
            {
                var dop = numb2;
                numb2 = numb1 % numb2;
                numb1 = dop;
            }
            return numb1;
        }
        public string Compare(Fraction frac1, Fraction frac2)
        {
            string message;
            int newNumeratorFrac1;
            int newNumeratorFrac2;

            if (frac1.denominator != frac2.denominator)
            {
                newNumeratorFrac1 = frac1.numerator * frac2.denominator;
                newNumeratorFrac2 = frac2.numerator * frac1.denominator;
            }
            else
            {
                newNumeratorFrac1 = frac1.numerator;
                newNumeratorFrac2 = frac2.numerator;
            }

            if (newNumeratorFrac1 > newNumeratorFrac2)
            {
                message = String.Format("{0} > {1}", frac1.FractionValue(), frac2.FractionValue());
            }
            else if (newNumeratorFrac1 < newNumeratorFrac2)
            {
                message = String.Format("{0} < {1}", frac1.FractionValue(), frac2.FractionValue());
            }
            else
            {
                message = String.Format("{0} = {1}", frac1.FractionValue(), frac2.FractionValue());
            }

            return message;
        }
    }


    
}
