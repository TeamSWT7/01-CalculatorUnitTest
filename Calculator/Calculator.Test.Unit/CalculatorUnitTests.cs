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
        [TestCase(5, 10, -5, 10)]
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
        
        [TestCase(15, 5, 5, 5)]
        [TestCase(6, 3, -4, 7)]
        [TestCase(10, 4.5, 2, 3.5)]
        public void Subtract_WithAccumulator(double a, double b, double c, double r)
        {

            _uut.Subtract(a, b);
            Assert.That(_uut.Subtract(c), Is.EqualTo(r));
        }

        [TestCase(3, 7, 21)]
        [TestCase(7, 7, 49)]
        [TestCase(2.5, 4, 10)]
        public void Multiply_MultiplyPosValues_ResultIsCorrect(double a, double b, double r)
        {
            Assert.That(_uut.Multiply(a, b), Is.EqualTo(r));
        }

        [TestCase(10, -2, -20)]
        [TestCase(-4, 5, -20)]
        [TestCase(-5, -5, 25)]
        public void Multiply_MultiplyPosAndNegValues_ResultIsCorrect(double a, double b, double r)
        {
            Assert.That(_uut.Multiply(a, b), Is.EqualTo(r));
        }

        [TestCase(2, 2, 2, 8)]
        [TestCase(-5, 3, -2, 30)]
        [TestCase(2, 3, 0.5, 3)]
        public void Multiply_MultiplyWithAccumulator_ResultIsCorrect(double a, double b, double c, double r)
        {
            _uut.Multiply(a, b);

            Assert.That(_uut.Multiply(c), Is.EqualTo(r));
        }

        [TestCase(10, 2, 5)]
        [TestCase(21, 3, 7)]
        [TestCase(1, 1, 1)]
        public void Divide_DividePosValues_ResultIsCorrect(double a, double b, double r)
        {
            Assert.That(_uut.Divide(a, b), Is.EqualTo(r));
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


        [TestCase(12, 2, 2, 3)]
        [TestCase(-6, 3, -1, 2)]
        [TestCase(40, 2, 0.5, 40)]
        public void Divide_WithAccumulator(double a, double b, double c, double r)
        {
            _uut.Divide(a, b);

            Assert.That(_uut.Divide(c), Is.EqualTo(r));
        }

        [TestCase(2, 4, 16)]
        public void Power_PowerWithPosVal(double a, double b, double r)
        {
            Assert.That(_uut.Power(a, b), Is.EqualTo(r));
        }


        [TestCase(7, 14, 7)]
        [TestCase(14, 7, 0)]
        [TestCase(54, 22, 10)]
        [TestCase(55, 7, 6)]
        [TestCase(6, 4, 2)]
        public void Modulus_ModulusWithPosVal(double a, double b, double r)
        {
            Assert.That(_uut.Modulus(a, b), Is.EqualTo(r));
        }

        //Using Scientific method
        [TestCase(-20, 3, -2)]
        [TestCase(-2, 5, -2)]
        [TestCase(52, -21, 10)]
        public void Modulus_ModulusWithMinVal(double a, double b, double r)
        {
            Assert.That(_uut.Modulus(a, b), Is.EqualTo(r));
        }

        [TestCase(150, 0, 0)]
        [TestCase(-2, 0, 0)]
        [TestCase(5, 0, 0)]
        public void Modulus_ModulusWithZero_ResultIsZero(double a, double b, double r)
        {
            Assert.That(_uut.Modulus(a, b), Is.EqualTo(r));
        }

        [TestCase(55, 7, 4, 2)]
        public void Modulus_ModulusWithAccumulator(double a, double b, double c, double r)
        {
            _uut.Modulus(a, b);
            Assert.That(_uut.Modulus(c), Is.EqualTo(r));
        }

        [TestCase(4, 50.24)]
        [TestCase(2, 12.56)]
        [TestCase(-2, 0)]
        public void AreaCircle_AreaWithPosAndNegValues(double a, double r)
        {
            Assert.That(_uut.AreaCircle(a), Is.EqualTo(r).Within(0.1));
        }

        [TestCase(5, 4 , 254.46)]
        public void AreaCircle_AreaWithAccumulator(double a, double b, double r)
        {
            _uut.Add(a, b);
            Assert.That(_uut.AreaCircle(), Is.EqualTo(r).Within(0.1));
        }
    }
}
