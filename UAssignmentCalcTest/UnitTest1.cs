using NUnit.Framework;

namespace UCalculatorTest
{
    public class Tests
    {
        Calculator objCalculator;

        [SetUp]
        public void Setup()
        {
            objCalculator = new Calculator();
        }

        [Test]
        public void AddNumbers()
        {
            int res = objCalculator.Add(4, 3);
            Assert.AreEqual(res, 7);
        }

        [Test]
        public void SubNumbers()
        {
            int res = objCalculator.Sub(8, 3);
            Assert.AreEqual(res, 5);
        }

        [Test]
        public void MulNumbers()
        {
            int res = objCalculator.Mul(8, 3);
            Assert.AreEqual(res, 24);
        }

        [Test]
        public void DivNumbers()
        {
            int res = objCalculator.Div(18, 3);
            Assert.AreEqual(res, 6);
        }
    }

    public class Calculator
    {
        public int Add(int num1, int num2)
        {
            int result = num1 + num2;
            System.Diagnostics.Debug.WriteLine("Test Result is" + " " + result);
            return result;
        }

        public int Sub(int num1, int num2)
        {
            int result = num1 - num2;
            System.Diagnostics.Debug.WriteLine("Test Result is" + " " + result);
            return result;

        }

        public int Mul(int num1, int num2)
        {
            int result = num1 * num2;
            System.Diagnostics.Debug.WriteLine("Test Result is" + " " + result);
            return result;


        }
        public int Div(int num1, int num2)
        {
            int result = num1 / num2;
            System.Diagnostics.Debug.WriteLine("Test Result is" + " " + result);
            return result;

        }
    }
}