using MathOperationns.Lib;
using NUnit.Framework;

namespace MapsOperations.test
{
    [TestFixture]
    public class Calculatortest
    {
        [TestCase("3", "2", "1")]
        //[TestCase("1", "1", "2")]
        //public void ShouldPlusTwoNumbersUsinTestClasses(int a, int b, int expected)
        //{
            //var calculator = new Calculator();

            //var actual = calculator.Plus(a, b);

            //Assert.AreEqual(expected, actual, "�������� �������� ���������");
        //}
        public void ShouldMinusTwoNumbersUsinTestClasses(int a, int b, int expected)
        {
            var calculator = new Calculator();

            var actual = calculator.Minus(a, b);

            Assert.AreEqual(expected, actual, "�������� ��������� ���������");
        }
    }
}