using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace MSTestTests
{
    /// <summary>
    /// Unit tests for Add method in Calculator
    /// </summary>
    [TestClass]
    public class AddMethodTests
    {
        private Calculator calculator;
        
        [ClassInitialize]
        public static void ClassInitialize11(TestContext testContext)
        {
            testContext.WriteLine("Calculator Add Tests started");
        }

        [ClassCleanup]
        public static void ClassClean()
        {
            Console.WriteLine("Calculator Add Tests ended");
        }

        [TestInitialize]
        public void TestInitialize()
        {
            Console.WriteLine("Test started");

            calculator = new Calculator();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            calculator = null;

            Console.WriteLine("Test ended");
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(-5.2, "3.8", -1.4)]
        public void Add_WhenCalled_ReturnsAddition(Object x, Object y, double expected)
        {
            Assert.AreEqual(expected, calculator.Add(Convert.ToDouble(x), Convert.ToDouble(y)), 1);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(-1, -1, -2)]
        [Ignore]
        public void Add_NegativeNumbers_ReturnsAddition(Object x, Object y, double expected)
        {
            Assert.AreEqual(expected, calculator.Add(Convert.ToDouble(x), Convert.ToDouble(y)), 1);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(0, 0, 0)]
        public void Add_Zero_ReturnsAddition(Object x, Object y, double expected)
        {
            Assert.Fail();
        }
    }
}
