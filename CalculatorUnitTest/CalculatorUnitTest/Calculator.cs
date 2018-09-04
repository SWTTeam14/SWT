using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        private double _accumulator = 0;

        public double Add(double a, double b)
        {
            double result = a + b;
            Accumulator = result;
            return result;
        }

        public double Subtract(double a, double b)
        {
            double result = a - b;
            Accumulator = result;
            return result;
        }

        public double Multiply(double a, double b)
        {
            double result = a * b;
            Accumulator = result;
            return result;
        }

        public double Power(double x, double exp)
        {
            double result = Math.Pow(x, exp);
            Accumulator = result;
            return result;
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                return Double.NaN;
            }

            double result = dividend / divisor;
            Accumulator = result;
            return result;
        }

        public double Accumulator
        {
            get { return _accumulator; }
            private set
            {
                _accumulator = value;
            }
        }

        public void Clear()
        {
            Accumulator = 0;
        }

        public double Add(double addend)
        {
            return Add(Accumulator, addend);
        }

        public double Substract(double subtractor)
        {
            return Subtract(Accumulator, subtractor);
        }

        public double Multiply(double multiplier)
        {
            return Multiply(Accumulator, multiplier);
        }

        public double Divide(double divisor)
        {
            return Divide(Accumulator, divisor);
        }

        public double Power(double exponent)
        {
            return Power(Accumulator, exponent);
        }
    }
}
