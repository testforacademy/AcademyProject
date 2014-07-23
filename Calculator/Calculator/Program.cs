using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator(5, 5);

            var result = calc.AddTwoNumbers();

            var result1 = calc.SubTwoNumbers();

            ShowResult(result);
            ShowResult(result1);
        }

        private static void ShowResult(double result)
        {
            Console.WriteLine(result);
        }
    }
}
