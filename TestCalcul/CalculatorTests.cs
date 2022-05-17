using NUnit.Framework;

namespace TestCalcul
{
    public class CalculatorTests
    {
        private readonly int _numberOne = 4;
        private readonly int _numberTwo = 2;
        private readonly string _notANumber = "a";
        private readonly string _isANumber = "12";
        private Calculator _calcul;

        [SetUp]
        public void Init()
        {
            _calcul = new Calculator();
        }

        [TestCase]
        public void Add()
        {
            var addCalcul = _calcul.Add(_numberOne, _numberTwo);
            var addTest = _numberOne + _numberTwo;
            Assert.AreEqual(addCalcul, addTest);

        }

        [TestCase]
        public void Sub()
        {
            var subCalcul = _calcul.Sub(_numberOne, _numberTwo);
            var subTest = _numberOne - _numberTwo;
            Assert.AreEqual(subCalcul, subTest);

        }

        [TestCase]
        public void Mult()
        {
            var subCalcul = _calcul.Mult(_numberOne, _numberTwo);
            var subTest = _numberOne * _numberTwo;
            Assert.AreEqual(subCalcul, subTest);

        }

        [TestCase]
        public void Div()
        {
            var subCalcul = _calcul.Div(_numberOne, _numberTwo);
            var subTest = _numberOne / _numberTwo;
            Assert.AreEqual(subCalcul, subTest);

        }

        [TestCase]
        public void IsNumber()
        {
            var isNumber = _calcul.IsNumber(_isANumber);
            Assert.IsTrue(isNumber);
        }

        [TestCase]
        public void IsNotNumber()
        {
            var notNumber = _calcul.IsNumber(_notANumber);
            Assert.IsFalse(notNumber);
        }
    }
}