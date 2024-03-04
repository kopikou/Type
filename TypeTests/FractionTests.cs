using Microsoft.VisualStudio.TestTools.UnitTesting;
using Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type.Tests
{
    [TestClass()]
    public class FractionTests
    {
        [TestMethod()]
        public void FractionValueTest()
        {
            var fract = new Fraction(1, 3);
            Assert.AreEqual("1 / 3", fract.FractionValue());
        }
        [TestMethod()]
        public void AddFractionSameDenominator()
        {
            var fract = new Fraction(1, 3);
            fract = fract + new Fraction(2, 3);
            Assert.AreEqual("3 / 3", fract.FractionValue());
        }
        [TestMethod()]
        public void AddFractionElseDenominator()
        {
            var fract = new Fraction(1, 3);
            fract = fract + new Fraction(1, 5);
            Assert.AreEqual("8 / 15", fract.FractionValue());
        }
        [TestMethod()]
        public void MinusFractionSameDenominator()
        {
            var fract = new Fraction(3, 3);
            fract = fract - new Fraction(2, 3);
            Assert.AreEqual("1 / 3", fract.FractionValue());
        }
        [TestMethod()]
        public void MinusFractionElseDenominator()
        {
            var fract = new Fraction(1, 3);
            fract = fract - new Fraction(1, 5);
            Assert.AreEqual("2 / 15", fract.FractionValue());
        }
        [TestMethod()]
        public void MultiplFractionDenominator()
        {
            var fract = new Fraction(2, 3);
            fract = fract * new Fraction(4, 5);
            Assert.AreEqual("8 / 15", fract.FractionValue());
        }
        [TestMethod()]
        public void DivisionFractionDenominator()
        {
            var fract = new Fraction(2, 3);
            fract = fract / new Fraction(4, 5);
            Assert.AreEqual("10 / 12", fract.FractionValue());
        }
    }

}