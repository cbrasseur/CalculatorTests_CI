namespace TestCalcul
{
    public class Calculator
    {
        public Calculator()
        {
            
        }

        public bool IsNumber(string? number)
        {
            return int.TryParse(number, out _);
        }

        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Sub(int number1, int number2)
        {
            return number1 - number2;
        }

        public int Mult(int number1, int number2)
        {
            return number1 * number2;
        }

        public float Div(int number1, int number2)
        {
            return number1 / number2;
        }
    }
}