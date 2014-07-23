using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddTwoNumbers(2, 2));
            Console.WriteLine(SubTwoNumbers(5, 3));
        }

        public static string AddTwoNumbers(double x, double y)
        {
            return (x + y).ToString();
        }

        public static string SubTwoNumbers(double x, double y)
        {
            return (x - y).ToString();
        }
    }
}
