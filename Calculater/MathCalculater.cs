using System;
using System.Collections.Generic;
using System.Text;

namespace Calculater
{
    class MathCalculater
    {
        public static int Addition(int number, int number2)
        {
            int result = number + number2;
            return result;
        }

        public static int Subtraction(int number, int number2)
        {
            int result = number - number2;
            return result;
        }

        public static int Division(int number, int number2)
        {
            int result = 0;
            if (number2 != 0)
            {
                result = number / number2;
            }
            return result;
        }

        public static int Multiplication(int number, int number2)
        {
            int result = number * number2;
            return result;
        }

        public static double Sqrt(int number, int number2)
        {
            double result = Math.Pow(number, number2);
            return result;
        }
    }
}
