using Katas.RomanNumerals;
using Xunit;

namespace KatasTests
{
    public class RomanNumeralsTests
    {
        [Theory]
        [InlineData("I", 1)]
        [InlineData("V", 5)]
        [InlineData("X", 10)]
        [InlineData("L", 50)]
        [InlineData("C", 100)]
        [InlineData("D", 500)]
        [InlineData("M", 1000)]
        [InlineData("MM", 2000)]
        [InlineData("MMD", 2500)]
        [InlineData("MMDXI", 2511)]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("IX", 9)]
        [InlineData("XLV", 45)]
        [InlineData("XCV", 95)]
        [InlineData("CDLV", 455)]
        [InlineData("CMXCVI", 996)]
        [InlineData("MMMMCMXCVI", 4996)]
        public void ConvertToRoman_WhenSuppliedWithNumber_ReturnsNumberConvertedToRoman(string expected, int num)
        {
            // Arrange
            // Act
            string actual = RomanNumerals.ConvertToRoman(num);
            // Assert
            Assert.True(expected.Equals(actual));
        }
    }
}
