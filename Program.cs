using LogicalProgramming.FibonacciSeries;
using LogicalProgramming.PerfectNumber;
using LogicalProgramming.PrimeNumber;
using LogicalProgramming.ReverseNumber;
using System.Dynamic;

namespace LogicalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Logical Programming");
            Console.WriteLine("Please choose 1 Program from below list");
            Console.WriteLine("1.FibonacciSeries\n2.PerfectNumber\n3.PrimeNumber\n4.ReverseNumber");
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
                case 3:
                    CheckPrime checkPrime = new CheckPrime();
                    CheckPrime.Primnum();
                    break;
                case 4:
                    Reverse reverse = new Reverse();
                    Reverse.Rev();
                    break;
            }
        }
    }
}