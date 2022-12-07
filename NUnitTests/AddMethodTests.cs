using CSharpCalculator;
using NUnit.Framework;

namespace NUnitTests
{
    /// <summary>
    /// Unit tests for Add method in Calculator
    /// </summary>
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class AddMethodTests
    {
        private Calculator calculator;

        [OneTimeSetUp]
        public void OneTimeSetupp()
        {
            Console.WriteLine("Calculator Add Tests started");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Console.WriteLine("Calculator Add Tests Ended");
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
        [TestCase(1, 1, 2)]
        [TestCase(-5.2, "3.8", -1.4)]
        public void Add_WhenCalled_ReturnsAddition(Object x, Object y, double expected)
        {
            Assert.AreEqual(expected, calculator.Add(Convert.ToDouble(x), Convert.ToDouble(y)), 1);
        }

        [Test]
        [TestCase(-1, -1, -2)]
        [Ignore("Not implmented")]
        public void Add_NegativeNumbers_ReturnsAddition(Object x, Object y, double expected)
        {
            Assert.AreEqual(expected, calculator.Add(Convert.ToDouble(x), Convert.ToDouble(y)), 1);
        }

        [Test]
        [TestCase(0, 0, 0)]
        public void Add_Zero_ReturnsAddition(Object x, Object y, double expected)
        {
            Assert.Fail();
        }
    }
}
