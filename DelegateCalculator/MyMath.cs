using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateCalculator
{
    public static class MyMath
    {
        public enum Operation
        {
            NONE,
            ADD,
            SUBTRACT,
            MULTIPLY,
            DIVIDE,
            POWER
        }



        public static double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        public static double Subtract(double number1, double number2)
        {
            return number1 - number2;
        }

        public static double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        public static double Divide(double number1, double number2)
        {
            return number1 / number2;
        }

        public static double Power(double number1, double number2)
        {
            return Math.Pow(number1, number2);
        }

        public static double None(double number1, double number2)
        {
            return -9999;
        }
    }
}
