using CSharpCalculator;
using NUnit.Framework;

namespace NUnitTests
{
    /// <summary>
    /// Unit tests for Sub method in Calculator
    /// </summary>
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class SubMethodTests
    {
        private Calculator calculator;

        [OneTimeSetUp]
        public void OneTimeSetupp()
        {
            Console.WriteLine("Calculator Sub Tests started");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Console.WriteLine("Calculator Sub Tests Ended");
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
        [TestCase(1, 1, 0)]
        [TestCase(-1, 1, -2)]
        [TestCase(-5.2, 3.7, -8.9)]
        [TestCase(-5.2, "3.8", -9)]
        public void Sub_WhenCalled_ReturnsSubstraction(Object x, Object y, double expected)
        {
            Assert.AreEqual(expected, calculator.Sub(Convert.ToDouble(x), Convert.ToDouble(y)), 1);
        }
    }
}
