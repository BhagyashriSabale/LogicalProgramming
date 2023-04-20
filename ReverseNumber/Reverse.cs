using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming.ReverseNumber
{
    internal class Reverse
    {
        public static void Rev()
        {
            Console.WriteLine("Please enter a number");
            int num = int.Parse(Console.ReadLine());
            int reverse = 0;

            while(num > 0) 
            {
                int remainder = num % 10;
                reverse = (reverse * 10) + remainder;
                num = num / 10;
            }
            Console.WriteLine("Reversed number is: " + reverse);
        }
    }
}
