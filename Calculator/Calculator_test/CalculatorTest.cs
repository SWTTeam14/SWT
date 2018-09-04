using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Application
{
    class CalculatorTest
    {
        static void Main(string[] args)
        {
            //Test addition
            Calculator calculation = new Calculator();
            Console.WriteLine(calculation.Add(2, 2));
            Console.WriteLine(calculation.Add(-4, -2));
            Console.WriteLine(calculation.Add(0, 0));
            //Test substraction
            Console.WriteLine(calculation.Subtract(5,3));
            Console.WriteLine(calculation.Subtract(-5,-2));
            Console.WriteLine(calculation.Subtract(0,0));
            //Test Multiplication
            Console.WriteLine(calculation.Multiply(3,2));
            Console.WriteLine(calculation.Multiply(-2, -4));
            Console.WriteLine(calculation.Multiply(3, 0));
            //Test power
            Console.WriteLine(calculation.Power(2,4));
            Console.WriteLine(calculation.Power(2, -4));
            Console.WriteLine(calculation.Power(-2, 4));
            Console.WriteLine(calculation.Power(-2, -4));


        }
    }
}
