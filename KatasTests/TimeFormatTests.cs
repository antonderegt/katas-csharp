using Katas.Time;
using Xunit;

namespace KatasTests
{
    public class TimeFormatTests
    {
        [Theory]
        [InlineData("00:00:00", 0)]
        [InlineData("00:00:05", 5)]
        [InlineData("00:01:00", 60)]
        [InlineData("23:59:59", 86399)]
        [InlineData("99:59:59", 359999)]
        public void GetReadableTime_SuppliedWithSeconds_ReturnsInHHMMSSFormat(string expected, int seconds)
        {
            // Arrange
            // Act
            string actual = TimeFormat.GetReadableTime(seconds);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
