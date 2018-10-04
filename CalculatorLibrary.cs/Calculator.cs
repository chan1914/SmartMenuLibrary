using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.cs
{
    public class Calculator
    {
        public static double Sum(double[] ints)
        {

            double sum = 0.0;
            for (int i = 0; i < ints.Length; i++)
            {
                sum = ints[i] + sum;
            }
            return sum;

        }

        public static double Minimum(double[] ints)
        {
            double min = ints[0];
            for (int i = 1; i < ints.Length; i++)
            {
                if (min > ints[i])
                {
                    min = ints[i];
                }
            }
            return min;


            // return ints.Min(); // den mest effiktive metode at finde min value i array

        }

        public static double Add(double v1, double v2)
        {
            return v1 + v2;
        }

        public static double Subtract(double v1, double v2)
        {
            if (v1 > v2)
            {
                return v1 - v2;
            }

            return v2 - v1;
        }

        public static double Maximum(double[] ints)
        {
            double max = ints[0];
            for (int i = 0; i < ints.Length; i++)
            {
                if (max < ints[i])
                {
                    max = ints[i];
                }
            }
            return max;
            // return ints.Max(); // den mest effiktive metode at finde max value i array

        }

        public static double Divide(double v1, double v2)
        {
            return v1 / v2;
        }

        public static double Multiply(double v1, double v2)
        {
            return v1 * v2;
        }

        public static double Average(double[] ints)
        {
            int i = 0;
            double avr = 0.0;
            for (i = 0; i < ints.Length; i++)
            {
                avr = avr + ints[i];
            }
            return (avr / ints.Length);

            // return ints.Average(); // den mest effiktive metode at finde avarage number i array
        }

    }
}
