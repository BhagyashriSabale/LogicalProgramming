using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming.Stopwatch
{
    internal class ElapsedTime
    {
        public static void Time()
        {
            Console.WriteLine("Press any key to start the stopwatch.");
            Console.ReadKey();
            DateTime startTime = DateTime.Now;

            Console.WriteLine("Press any key to stop the stopwatch.");
            Console.ReadKey();
            DateTime endTime = DateTime.Now;

            TimeSpan elapsTime = endTime - startTime;

            Console.WriteLine("Elapsed time: {0}", elapsTime);
        }
    }
}
