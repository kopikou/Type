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
    }


    
}
