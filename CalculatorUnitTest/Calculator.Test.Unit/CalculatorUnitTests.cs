using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTests
    {
        private Calculator uut;
        [SetUp]
        public void Setup()
        {
           uut = new Calculator();
        }

        [TestCase(2,2,4)] 
        [TestCase(-2,-4,-6)]
        [TestCase(0,0,0)]
        public void Addition(double a, double b, double c)
        {
            
            Assert.That(uut.Add(a,b), Is.EqualTo(c));
        }

        [TestCase(5,3,2)]
        [TestCase(-5,-2,-3)]
        [TestCase(0,0,0)]
        public void Subtract(double a, double b, double c)
        {
            
            Assert.That(uut.Subtract(a, b), Is.EqualTo(c));
        }

        [TestCase(3,2,6)]
        [TestCase(-2,-4,8)]
        [TestCase(3,0,0)]
        public void Multiplication(double a, double b, double c)
        {
            Assert.That(uut.Multiply(a, b), Is.EqualTo(c));
        }

        [TestCase(2,4,16)]
        [TestCase(2,-4,0.0625)]
        [TestCase(-2, 4, 16)]
        [TestCase(-2, -4, 0.0625)]
        [TestCase(0,1,0)]
        [TestCase(2,0,1)]
        public void Power(double a, double b, double c)
        {
            Assert.That(uut.Power(a,b), Is.EqualTo(c));
        }

        [TestCase(-6, 2, -3)]
        [TestCase(2, 2, 1)]
        [TestCase(10, 2, 5)]
        public void Divide(double a, double b, double c)
        {
            Assert.That(uut.Divide(a,b), Is.EqualTo(c));
        }



        [TestCase(4,2)]
        [TestCase(49,7)]
        [TestCase(0,0)]
        public void Sqrt(double a, double b)
        {
            Assert.That(uut.Sqrt(a), Is.EqualTo(b));
        }

        // Testing exceptions:
        [Test]
        public void SqrtException()
        {
            Assert.Throws<Exception>(() => uut.Sqrt(-5));
        }

        [Test]
        public void DivideException()
        {
            Assert.Throws<Exception>(() => uut.Divide(2, 0));
        }


        [TestCase(6, 4, 10)]
        public void AccumulateAddition(double a, double b, double c)
        {
            Assert.That(uut.Add(a, b), Is.EqualTo(c));
            Assert.That(uut.AcAdd(a), Is.EqualTo(16));
            Assert.That(uut.AcAdd(a), Is.EqualTo(22));
        }

        [TestCase(8, 2, 6)]
        public void AccumulateSubstraction(double a, double b, double c)
        {
            Assert.That(uut.Subtract(a, b), Is.EqualTo(c));
            Assert.That(uut.AcSubstract(b), Is.EqualTo(4));
            Assert.That(uut.AcSubstract(c), Is.EqualTo(-2));
        }
        
        [TestCase(10, 7, 70)]
        public void AccumulateMultiplication(double a, double b, double c)
        {
            Assert.That(uut.Multiply(a, b), Is.EqualTo(c));
            Assert.That(uut.AcMultiply(a), Is.EqualTo(700));
            Assert.That(uut.AcMultiply(2), Is.EqualTo(1400));
        }

        [TestCase(25, 25, 5)]
        public void AccumulateDivision(double a, double b, double c)
        {
            Assert.That(uut.Divide(b, c), Is.EqualTo(5));
            Assert.That(uut.AcDivide(c), Is.EqualTo(1));
            Assert.That(uut.AcDivide(a), Is.EqualTo(0.04));
        }

        [TestCase(3, 3, 27)]
        public void AccumulatePower(double a, double b, double c)
        {
            Assert.That(uut.Power(a, b), Is.EqualTo(c));
            Assert.That(uut.AcPower(a), Is.EqualTo(19683));
            Assert.That(uut.AcPower(2), Is.EqualTo(387420489));
        }

        [TestCase(10, 5, 50, 2)]
        public void AccumulateAll(double a, double b, double c, double d)
        {
            Assert.That(uut.Add(b, b), Is.EqualTo(a));
            Assert.That(uut.AcMultiply(b), Is.EqualTo(c));
            Assert.That(uut.AcDivide(b), Is.EqualTo(a));
            Assert.That(uut.AcSubstract(b), Is.EqualTo(b));
            Assert.That(uut.AcPower(d), Is.EqualTo(25));
        }

        [TestCase(16,4)]
        public void AccumulateSqrt(double a, double b)
        {
            Assert.That(uut.Sqrt(a), Is.EqualTo(b));
            Assert.That(uut.AcSqrt(), Is.EqualTo(2));
            
        }


    }
}
