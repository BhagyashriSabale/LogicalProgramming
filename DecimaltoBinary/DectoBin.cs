using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming.DecimaltoBinary
{
    internal class DectoBin
    {
        public static string ToBinary(int n)
        {
            return Convert.ToString(n, 2).PadLeft(32, '0');
        }
    }
}
