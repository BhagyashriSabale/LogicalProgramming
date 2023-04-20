using LogicalProgramming.FibonacciSeries;
using LogicalProgramming.PerfectNumber;
using System.Dynamic;

namespace LogicalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Logical Programming");
            Console.WriteLine("Please choose 1 Program from below list");
            Console.WriteLine("1.FibonacciSeries\n2.PerfectNumber");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
                {
                case 1:
                    Calculatesum calculatesum = new Calculatesum();
                    Calculatesum.seriesaddition();
                break;
                case 2:
                    Perfectnum perfectnum = new Perfectnum();
                    Perfectnum.Perfect();
                    break;
            }
        }
    }
}