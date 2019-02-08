using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Multiply_TwoPositiveIntegers()
        {
            var expected = 16;
            var a = 8;
            var b = 2;
            var actual = Multiply(a, b);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(12, 6, 2)]
        [InlineData(0, 0, 0)]
        public void Multiplication(int exp, int n1, int n2)
        {
            Assert.Equal(exp, Multiply(n1, n2));
        }
        int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
