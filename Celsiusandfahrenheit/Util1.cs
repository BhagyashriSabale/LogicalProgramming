using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming.Celsiusandfahrenheit
{
    internal class Util1
    {
        public static double FehtoCelsius(double f)
        {
            return (f - 32) * 5 / 9;
        }

        public static double CeltoFehrenheit(double c)
        {
            return (c * 9 / 5) + 32;
        }
    }
}
