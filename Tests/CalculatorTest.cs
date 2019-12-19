using System;
using UnitestDemo;
using Xunit;

namespace Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAdd1()
        {
            var calculator = new Calculator();
            var result = calculator.Add(1, 2);

            Assert.Equal(3, result);
        }


        [Theory]
        [InlineData(1,2,3)]
        [InlineData(20,20,40)]
        [InlineData(-1,1,0)]
        [InlineData(100,2,20)]
        public void TestAddTheory(int value1, int value2, int expected)
        {
            var calculator = new Calculator();
            var result = calculator.Add(value1, value2);

            Assert.Equal(expected, result);
        }
    }
}
