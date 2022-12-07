using Xunit;
using CSharpCalculator;
using Xunit.Abstractions;

namespace XUnitTests
{
    /// <summary>
    /// Unit tests for Add method in Calculator
    /// </summary>
    public class AddMethodTests : IDisposable
    {
        private Calculator calculator;
        private readonly ITestOutputHelper output;

        // setup
        public AddMethodTests(ITestOutputHelper output)
        {
            this.output = output;

            output.WriteLine("Test started");

            calculator = new Calculator();
        }

        // teardown
        public void Dispose()
        {
            output.WriteLine("Test ended");
        }

        [Fact]
        public void Add_WhenCalled_ReturnsAddition()
        {
            Assert.Equal(2, calculator.Add(1.0, 1.0));
        }

        [Fact]
        public void Add_Zero_ReturnsAddition()
        {
            Assert.True(false);
        }

        [Fact(Skip = "Not Implemented Correctly")]
        public void Add_NegativeNumbers_ReturnsAddition()
        {
            Assert.Equal(-1, -1);
        }


    }
}
