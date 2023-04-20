using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming.PerfectNumber
{
    internal class Perfectnum
    {
        public static void Perfect()
        {
            int num, sum = 0;
            Console.WriteLine("Please enter a number: ");
            num = int.Parse(Console.ReadLine());

            for(int i=1; i<num; i++) 
            {
                if(num%i==0)
                {
                    sum += i;
                }
                
            }
            if(sum==num)
            {
                Console.WriteLine("{0} is a perfect number", num);
            }
            else
            {
                Console.WriteLine("{0} is not a perfect number", num);
            }
        }
    }
}
