using Katas.ColorUtil;
using Xunit;

namespace KatasTests
{
    public class ColorUtilTests
    {
        [Theory]
        [InlineData(true, "rgb(0,0,0)")]
        [InlineData(true, "rgb(255,255,255)")]
        [InlineData(true, "rgb( 255 ,   255  ,255)")]
        [InlineData(true, "rgb(0%,50%,100%)")]
        [InlineData(false, "rgb(0,,0)")]
        [InlineData(false, "rgb (0,0,0)")]
        [InlineData(false, "rgb(0,0,0,0)")]
        [InlineData(false, "rgb(-1,0,0)")]
        [InlineData(false, "rgb(255,256,255)")]
        [InlineData(false, "rgb(100%,100%,101%)")]
        public static void ValidRgbColor_WhenSuppliedWithRgbString_ReturnsWhetherStringIsValid(bool expected, string rgb)
        {
            // Arrange
            // Act
            bool actual = ColorUtil.ValidRgbColor(rgb);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(true, "rgba(0,0,0,0)")]
        [InlineData(true, "rgba(255,255,255,1)")]
        [InlineData(true, "rgba(0,0,0,0.12345678)")]
        [InlineData(true, "rgba(0,0,0,.8)")]
        [InlineData(true, "rgba(0 , 127, 255 , 0.1)")]
        [InlineData(false, "rgba(0,0,0)")]
        [InlineData(false, "rgba(0,0,0,-1)")]
        [InlineData(false, "rgba(0,0,0,1.1)")]
        public static void ValidRgbColor_WhenSuppliedWithRgbaString_ReturnsWhetherStringIsValid(bool expected, string rgb)
        {
            // Arrange
            // Act
            bool actual = ColorUtil.ValidRgbColor(rgb);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
