using Xunit;
using Katas.LargestDifference;

namespace KatasTests
{
    public class LargestDifferenceTests
    {
        [Fact]
        public void Constructor_InitOfDifferenceCalculator_ShouldCreateCorrectDefaultValues()
        {
            // Arrange
            int[] input = { 2, 3, 11, 7, 9, 5, 1, 3, 5 };
            LargestDifference ld = new(input);
            int[] expected = input;
            //// Act
            int[] actual = ld.Numbers;
            //// Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, new int[] { 2, 3, 1, 7, 9, 5, 11, 3, 5 })]
        [InlineData(9, new int[] { 2, 3, 11, 7, 9, 5, 1, 3, 5 })]
        public void LargestDiff_NumbersBetween1And11_ShouldReturnLargestDfference(int expected, int[] input)
        {
            // Arrange
            LargestDifference ld = new(input);
            //// Act
            int actual = ld.LargestDiff();
            //// Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NumberOfPairs_FourConsecutivePairs_ShouldCountNumberOfPairsThatSumUpToTheLargestDifference()
        {
            // Arrange
            int[] input = { 2, 3, 1, 7, 9, 5, 11, 3, 5 };
            LargestDifference ld = new(input);
            ld.LargestDiff();
            int expected = 4;
            //// Act
            int actual = ld.NumberOfPairs();
            //// Assert
            Assert.Equal(expected, actual);
        }
    }
}
