using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming.FibonacciSeries
{
    internal class Calculatesum
    {
        public static void seriesaddition()
        {
            int n, i, num1 = 0, num2 = 1, sum = 0;

            Console.WriteLine("Enter the no.of Terms:");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Fibonacci series:");

            for (i = 1; i <= n; i++)
            {

                if (i == 1)
                {
                    Console.Write(num1 + " ");
                    continue;
                }
                if (i == 2)
                {
                    Console.Write(num2 + " ");
                    continue;
                }
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
                Console.Write(sum + " ");
            }
        }
    }
}
