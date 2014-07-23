using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddTwoNumber(2, 2));
        }

        public static double AddTwoNumber(double x, double y)
        {
            return x + y;
        }
    }
}
