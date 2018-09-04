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

        [TestCase(2, 0, double.NaN)]
        [TestCase(2, 2, 1)]
        [TestCase(10, 2, 5)]

        public void Divide(double a, double b, double c)
        {
            Assert.That(uut.Divide(a,b), Is.EqualTo(c));
        }
      
        [TestCase(25, 5, 5, 25)]
        [TestCase(10, 5, 2, 4)]
        public void Accumulate(double a, double b, double c, double d)
        {
            Assert.That(uut.Divide(a, b), Is.EqualTo(c));
            Assert.That(uut.AcMultiply(c), Is.EqualTo(d));
        }
        
    }
}
