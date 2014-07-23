using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Calculator
{
    public class Calculator
    {
        private readonly double _secondNumber;
        private readonly double _firstNumber;

        public Calculator(double firstNumber, double secondNumber)
        {
            _firstNumber = firstNumber;
            _secondNumber = secondNumber;
        }

        public string AddTwoNumbers()
        {
            return (_firstNumber + _secondNumber).ToString();
        }

        public string SubTwoNumbers()
        {
            return (_firstNumber - _secondNumber).ToString();
        }
    }
}