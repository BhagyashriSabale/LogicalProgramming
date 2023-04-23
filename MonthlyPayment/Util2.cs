using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming.MonthlyPayment
{
    internal class Util2
    {
        public static double CalculateMonthlyPayemnt(double principal, double years, double interestRate)
        {
            double r = interestRate / (12 * 100); 
            double n = 12 * years; 
            double a = principal * r;
            double b = 1 - Math.Pow(1 + r, -n);
            return a / b;
        }
    }
}
