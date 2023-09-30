using System;

namespace Calculator
{
    public static class CalculationMethods
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int divide(int num1, int num2)
        {
            if (num2 == 0)
                throw new ArithmeticException("Divide By Zero Error");
            return num1 / num2;
            
        }
    }
}