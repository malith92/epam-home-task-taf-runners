using CSharpCalculator;
using NUnit.Framework;

namespace NUnitTests
{
    /// <summary>
    /// Unit tests for Devide method in Calculator
    /// </summary>
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class DivideMethodTests
    {
        private Calculator calculator;

        [OneTimeSetUp]
        public void OneTimeSetupp()
        {
            Console.WriteLine("Calculator Devide Tests started");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Console.WriteLine("Calculator Devide Tests Ended");
        }

        [SetUp]
        public void SetUp()
        {
            Console.WriteLine("Test started");

            calculator = new Calculator();
        }

        [TearDown]
        public void TearDown()
        {
            calculator = null;

            Console.WriteLine("Test ended");
        }

        [Test]
        [TestCase(10, 5, 2)]
        [TestCase(0, 10, 0)]
        [TestCase(1, 0, Double.PositiveInfinity)]
        public void Divide_WhenCalled_ReturnsDivide(double x, double y, double expected)
        {
            Assert.AreEqual(expected, calculator.Divide(x, y));
        }
    }
}
