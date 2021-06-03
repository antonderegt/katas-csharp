using Katas.CreditCard;
using Xunit;

namespace KatasTests
{
    public class CreditCardTests
    {
        [Theory]
        [InlineData(false, 123)]
        [InlineData(false, 79927398714)]
        [InlineData(false, 79927398713)]
        [InlineData(true, 709092739800713)]
        [InlineData(false, 1234567890123456)]
        [InlineData(true, 12345678901237)]
        [InlineData(true, 5496683867445267)]
        [InlineData(false, 4508793361140566)]
        [InlineData(true, 376785877526048)]
        [InlineData(false, 36717601781975)]
        public void ValidateNumber_WhenSuppliedWithNumber_ReturnsTrueIfNumberIsValidOtherwiseFalse(bool expected, double num)
        {
            // Arrange
            // Act
            bool actual = CreditCard.ValidateNumber(num);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
