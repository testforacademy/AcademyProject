using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator(5, 5);

            var result = calc.AddTwoNumbers();

            Console.WriteLine(result);
            Console.WriteLine(calc.SubTwoNumbers());
        }
    }
}
