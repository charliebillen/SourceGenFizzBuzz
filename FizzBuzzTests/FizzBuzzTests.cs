using Xunit;

namespace FizzBuzzTests
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(0, "FizzBuzz")]
        [InlineData(1, "1")]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        public void GetAnswer_GivenANumber_ReturnsTheExpectedOutput(int number, string expected)
        {
            var actual = FizzBuzz.GetAnswer(number);

            Assert.Equal(expected, actual);
        }
    }
}
