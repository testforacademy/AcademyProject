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

            Console.WriteLine(result);
            Console.WriteLine(result1);
        }
    }
}
