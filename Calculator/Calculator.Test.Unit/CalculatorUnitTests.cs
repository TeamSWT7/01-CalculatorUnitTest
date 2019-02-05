using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTests
    {
        private Calculator _uut;
        [SetUp]
        public void Setup()
        {
            _uut = new Calculator();
        }

        //Test 1
        [TestCase(2, 4, 6)]
        [TestCase(0, 6, 6)]
        [TestCase(10, 20, 30)]
        [TestCase(4.3, 2.5, 6.8)]
        public void Add_AddPosValues_ResultIsCorrect(double a, double b, double r)
        {
            Assert.That(_uut.Add(a, b), Is.EqualTo(r));
        }

        [TestCase(10, -5, 5)]
        [TestCase(5, -10, -5)]
        [TestCase(2.5, -5, -2.5)]
        public void Add_AddPosAndNegValues(double a, double b, double r)
        {
            Assert.That(_uut.Add(a, b), Is.EqualTo(r));
        }

        [TestCase(5, 10, 5, 20)]
        public void Add_AddWithAccumulator_ResultIsCorrect(double a, double b, double c, double r)
        {
            // Add first result to accumulator
            _uut.Add(a, b);

            // Assert with accumulated result
            Assert.That(_uut.Add(c), Is.EqualTo(r));
        }

        [TestCase(10, 5, 5)]
        [TestCase(7, 14, -7)]
        [TestCase(5.5, 3, 2.5)]
        public void Subtract_SubtractPosValues_ResultIsCorrect(double a, double b, double r)
        {
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(r));
        }

        [TestCase(10, 2, 5)]
        [TestCase(21, 3, 7)]
        [TestCase(1, 1, 1)]
        public void Divide_DividePosValues_ResultIsCorrect(double a, double b, double r)
        {
            Assert.That(_uut.Divide(4, 2), Is.EqualTo(2));
        }

        [TestCase(4, -2, -2)]
        [TestCase(-8, 2, -4)]
        public void Divide_DividePosAndNegValues_ResultIsCorrect(double a, double b, double r)
        {
            Assert.That(_uut.Divide(a, b), Is.EqualTo(r));
        }

        [TestCase(3, 0, 0)]
        [TestCase(0, 4, 0)]
        [TestCase(-3, 0, 0)]
        [TestCase(0, -4, 0)]
        public void Divide_DivisionWithZero_ResultIsZero(double a, double b, double r)
        {
            Assert.That(_uut.Divide(a, b), Is.EqualTo(r));
        }
    }
}