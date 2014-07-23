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

        public double AddTwoNumbers()
        {
            return _firstNumber + _secondNumber;
        }

        public double SubTwoNumbers()
        {
            return _firstNumber - _secondNumber;
        }
    }
}