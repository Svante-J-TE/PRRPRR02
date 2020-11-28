using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Calculate
    {
        public double addNumbers(double[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
