using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator(5, 5);

            calc.SetFirst(10);
            calc.SetSecond(2);

            Console.WriteLine(calc.AddTwoNumbers());
            Console.WriteLine(calc.SubTwoNumbers());
        }
    }
}
