using Katas.Reducto;
using Xunit;

namespace KatasTests
{
    public class ReductoTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(9, 9)]
        [InlineData(7, 9, 8)]
        [InlineData(6, 16, 28)]
        [InlineData(1, 111111111)]
        [InlineData(2, 1, 2, 3, 4, 5, 6)]
        [InlineData(6, 8, 16, 89, 3)]
        [InlineData(6, 26, 497, 62, 841)]
        [InlineData(6, 17737, 98723, 2)]
        [InlineData(8, 123, -99)]
        [InlineData(8, 167, 167, 167, 167, 167, 3)]
        [InlineData(2, 98526, 54, 863, 156489, 45, 6156)]
        public void SumDigProd_SingleAndMultipleNumbersAsInput_ShouldReturnOneDigit(int expected, params int[] inputValues)
        {
            // Arrange
            // Act
            int actual = Reducto.SumDigProd(inputValues);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ProductOfDigits_NumberWithTwoDigits_ShouldReturnProductOfDigits()
        {
            // Arrange
            int input = 44;
            int expected = 16;
            // Act
            int actual = Reducto.ProductOfDigits(input);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}