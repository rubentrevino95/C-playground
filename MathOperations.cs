using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //no object needed to be created for static classes to access
    class MathOperations
    {
        public static int GetSum(int value1, int value2)
        {
            return value1 + value2;
        }

        public static int GetSubtraction(int value1, int value2)
        {
            return value1 - value2;
        }

        public static int GetMultiplication(int value1, int value2)
        {
            return value1 * value2;
        }

        public static int GetDivision(int value1, int value2)
        {
            return value1 / value2;
        }
    }
}
