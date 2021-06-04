using Katas.FreddyFridays;
using Xunit;

namespace KatasTests
{
    public class FreddyFridaysTests
    {
        [Theory]
        [InlineData(2, 2020)]
        [InlineData(1, 2016)]
        [InlineData(3, 2015)]
        [InlineData(2, 2023)]
        [InlineData(2, 2024)]
        public void FindFridaysThe13thInYear_WhenSuppliedWithAYear_ReturnsTheNumberOfFriday13ths(int expected, int year)
        {
            // Arrange
            // Act
            int actual = FreddyFridays.FindFridaysThe13thInYear(year);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
