using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Welcome to Fibonacci series program");
             FibonacciSeries Fibonacci = new FibonacciSeries();
             int number = Convert.ToInt32(Console.ReadLine());
             Fibonacci.Fibo(number);*/

            /* PerfectNumber perfectnum = new PerfectNumber();
             perfectnum.Perfect();*/

            /* PrimeNumber primenum = new PrimeNumber();
             primenum.Prime();*/
            /* ReverseNumber reversenum = new ReverseNumber();
             reversenum.Reverse();*/

            /* CouponNumber obj4 = new CouponNumber();
             obj4.couponsNumbers();*/

            /*SimulateStopwatch obj5 = new SimulateStopwatch();
            obj5.stopWatch();*/

            /*Console.WriteLine("Enter Amount to get Change");
            int amount = Convert.ToInt32(Console.ReadLine());
            VendingMachine vending = new VendingMachine();
            vending.Getchange(amount);*/

            /* DayOfWeek obj7 = new DayOfWeek();
             obj7.checkDayForADate();*/

            /* TempConversion obj8 = new TempConversion();
             obj8.temperatureConversion();*/

            /*MonthlyPayment obj9 = new MonthlyPayment();
            obj9.monthlyPayment();*/

            /*Binary binary = new Binary();
            binary.decimalToBinary();*/

            /*SqrtNewtonMethod sqrt = new SqrtNewtonMethod();
            SqrtNewtonMethod.Sqrt();*/

            SwapNibble obj12 = new SwapNibble();
            Console.WriteLine("Enter number to convert in Binary :");
            int number = Convert.ToInt32(Console.ReadLine());
            obj12.ToBinary(number);

            Console.ReadLine();
        }
    }
}
