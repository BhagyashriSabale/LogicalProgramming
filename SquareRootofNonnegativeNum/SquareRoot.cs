using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming.SquareRootofNonnegativeNum
{
    internal class SquareRoot
    {
        public static double Sqrt(double c)
        {
            double epsilon = 1e-15;
            double t = c;

            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;
            }

            return t;
            Console.WriteLine($"The square root of {c} is {t}");
        }
    }
}
