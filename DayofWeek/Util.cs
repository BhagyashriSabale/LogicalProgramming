using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming.DayofWeek
{
    internal class Util
    {
        public static int DayOfWeek(int m, int d, int y)
        {
            if (m < 1 || m > 12 || d < 1 || d > 31 || y < 0)
            {
                throw new ArgumentException("Invalid input values");
            }

            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;
            return d0;
        }
    }
}
