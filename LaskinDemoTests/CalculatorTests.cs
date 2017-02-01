using Microsoft.VisualStudio.TestTools.UnitTesting;
using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            // AAA princible
            // Arrange, tietojen alustus
            // Act, Call Method
            // Assert, varmistetaan että tulos ok

            // arrange
            Calculator calc = new Calculator();
            int a = 4, 
                b = 5, 
                expected = 9;

            // act
            int actual = calc.Add(a, b);

            // assert
            Assert.AreEqual(expected, actual);

            // toinen testi
            a = 0;
            b = 1;
            expected = 1;
            actual = calc.Add(a, b);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void MultiplyTest()
        {
            // arrange
            Calculator calc = new Calculator();
            int a = 4,
                b = 5,
                expected = 20;

            // act
            int actual = calc.Multiply(a, b);

            // assert
            Assert.AreEqual(expected, actual);

            // second test
            a = 0;
            b = 1;
            expected = 0;
            actual = calc.Multiply(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void DivisionTest()
        {
            // arrange
            Calculator calc = new Calculator();
            int a = 10,
                b = 2,
                expected = 5;

            // act
            int actual = calc.Division(a, b);

            // assert
            Assert.AreEqual(expected, actual);

            // second test
            a = 9;
            b = 3;
            expected = 3;
            actual = calc.Division(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SubtractTest()
        {
            // arrange
            Calculator calc = new Calculator();
            int a = 4,
                b = 5,
                expected = -1;

            // act
            int actual = calc.Subtract(a, b);

            // assert
            Assert.AreEqual(expected, actual);

            // second test
            a = 0;
            b = 1;
            expected = -1;
            actual = calc.Subtract(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}