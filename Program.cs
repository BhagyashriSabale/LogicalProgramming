using LogicalProgramming.Celsiusandfahrenheit;
using LogicalProgramming.DayofWeek;
using LogicalProgramming.DecimaltoBinary;
using LogicalProgramming.FibonacciSeries;
using LogicalProgramming.MonthlyPayment;
using LogicalProgramming.PerfectNumber;
using LogicalProgramming.PrimeNumber;
using LogicalProgramming.ReverseNumber;
using LogicalProgramming.SquareRootofNonnegativeNum;
using LogicalProgramming.Stopwatch;
using LogicalProgramming.VendingMachine;
using System;
using System.Dynamic;

namespace LogicalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Logical Programming");
            Console.WriteLine("Please choose 1 Program from below list");
            Console.WriteLine("1.FibonacciSeries\n2.PerfectNumber\n3.PrimeNumber\n4.ReverseNumber\n6.Stopwatch");

            Console.WriteLine("8.DayofWeek\n9.CelsiusandFahrenheit\n10.MonthlyPayment\n11.VendingMachine\n12.SquareRoot\n13.DecimaltoBinary");
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
                case 6:
                     ElapsedTime elapsedTime = new ElapsedTime();
                     ElapsedTime.Time();
                break;

                case 8:
                    try
                    {
                        Console.WriteLine("Enter value of m: ");
                        int m = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter value of d: ");
                        int d = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter value of y: ");
                        int y = int.Parse(Console.ReadLine());

                        int dayOfWeek = Util.DayOfWeek(m, d, y);

                        Console.WriteLine(dayOfWeek);
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine("Error: " + e.Message);
                    }

                break;
                case 9:
                    Console.WriteLine("Enter temperature in Fahrenheit: ");
                    double f = double.Parse(Console.ReadLine());
                    double c = Util1.FehtoCelsius(f);
                    Console.WriteLine("Temperature in Celsius = " + c + "°C");

                    Console.WriteLine("Enter temperature in Celsius: ");
                    c = double.Parse(Console.ReadLine());
                    f = Util1.CeltoFehrenheit(c);
                    Console.WriteLine("Temperature in Fahrenheit = " + f + "°F");
                break;
                case 10:
                    Console.WriteLine("Enter the Amount: ");
                    double principal = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the year: ");
                    double years = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the InterestRate: ");
                    double interestRate = double.Parse(Console.ReadLine());
                    double monthlyPayment = Util2.CalculateMonthlyPayemnt(principal, years, interestRate);
                    Console.WriteLine("Monthly payment: $" + Math.Round(monthlyPayment, 2));
                break;
                case 11:
                    Console.WriteLine("Please enter amount: ");
                    int amount = int.Parse(Console.ReadLine());
                    VM vM = new VM();
                    VM.GetMinimumNumbOfNotes(amount);
                break;
                case 12:
                    Console.Write("Enter a non-negative number: ");
                    c = double.Parse(Console.ReadLine());

                    double sqrtC = SquareRoot.Sqrt(c);
                    Console.WriteLine($"The square root of {c} is {sqrtC}");
                break;
                case 13:
                    Console.Write("Enter a decimal number: ");
                    int n = int.Parse(Console.ReadLine());
                    string binary = DectoBin.ToBinary(n);
                    Console.WriteLine($"The binary representation of {n} is {binary}");
                    break;
            }
        }
    }
}