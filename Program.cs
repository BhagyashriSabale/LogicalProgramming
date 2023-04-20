using LogicalProgramming.FibonacciSeries;
using System.Dynamic;

namespace LogicalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Logical Programming");
            Console.WriteLine("Please choose 1 Program from below list");
            Console.WriteLine("1.FibonacciSeries");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
                {
                case 1:
                    Calculatesum calculatesum = new Calculatesum();
                    Calculatesum.seriesaddition();
                break;
            }
        }
    }
}