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
            //Assert.AreEqual("3 / 3", fract.FractionValue());
            Assert.AreEqual("1 / 1", fract.FractionValue());
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
            //Assert.AreEqual("10 / 12", fract.FractionValue());
            Assert.AreEqual("5 / 6", fract.FractionValue());
        }
        
        [TestMethod()]
        public void CompareFraction()
        {
            var fract1 = new Fraction(5, 7);
            var fract2 = new Fraction(1, 2);
            Assert.AreEqual("5 / 7 > 1 / 2", fract1.Compare(fract1,fract2));

            var fract3 = new Fraction(7, 15);
            var fract4 = new Fraction(1, 2);
            Assert.AreEqual("7 / 15 < 1 / 2", fract1.Compare(fract3, fract4));

            var fract5 = new Fraction(1, 2);
            var fract6 = new Fraction(2, 4);
            Assert.AreEqual("1 / 2 = 2 / 4", fract1.Compare(fract5, fract6));

            int a = 15;
            Assert.AreEqual("Разные типы", fract1.Compare(a, fract6));
        }
        [TestMethod()]
        public void Is_Equels()
        {
            var fract5 = new Fraction(1, 2);
            var fract6 = new Fraction(2, 4);
            int a = 15;
            Assert.AreEqual(false, fract5.Equals(a));
            Assert.AreEqual(true, fract5.Equals(fract6));
        }
    }

}