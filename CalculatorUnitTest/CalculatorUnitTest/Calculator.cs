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

        public double Power(double x, double exp)¨¨
        {
            
                double result = Math.Pow(x, exp);
                Accumulator = result;
                return result;
            
            
        }

        public double Divide(double dividend, double divisor)
        {
            //if (divisor == 0)
            //{
            //    return Double.NaN;
            //}

            //double result = dividend / divisor;
            //Accumulator = result;
            //return result;
            double result = 0;
            try
            {
                result = dividend / divisor;
                Accumulator = result;
                

            } catch(Exception e) when (divisor == 0)
            {
                return Double.NaN;
                throw e;
            }
            return result;
        }

        public double Sqrt(double a)
        {
            if (a < 0)
            {
                Clear();
                throw new Exception("Cant take sqrt of a negative number. ");
            }
            double result = Math.Sqrt(a);
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

        public double AcAdd(double addend)
        {
            return Add(Accumulator, addend);
        }

        public double AcSubstract(double subtractor)
        {
            return Subtract(Accumulator, subtractor);
        }

        public double AcMultiply(double multiplier)
        {
            return Multiply(Accumulator, multiplier);
        }

        public double AcDivide(double divisor)
        {
            return Divide(Accumulator, divisor);
        }

        public double AcPower(double exponent)
        {
            return Power(Accumulator, exponent);
        }

        public double AcSqrt()
        {
            return Sqrt(Accumulator);
        }
    }
}
