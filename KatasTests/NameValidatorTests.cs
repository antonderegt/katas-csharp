using Katas.NameValidator;
using Xunit;

namespace KatasTests
{
    public class NameValidatorTests
    {
        [Theory]
        [InlineData(false, "H. G. W.")]
        [InlineData(false, "H. G. W. Herbert")]
        [InlineData(true, " H. Herbert ")]
        [InlineData(true, "H.  Herbert")]
        [InlineData(true, "H. Wells")] // 1
        [InlineData(true, "H. G. Wells")] // 2
        [InlineData(true, "Herbert G. Wells")] // 3
        [InlineData(true, "Herbert George Wells")] // 4
        [InlineData(false, "Herbert")] // 5 Description = "Name must be 2 or 3 words."
        [InlineData(false, "Herbert W. G. Wells")] // 6 Description = "Name must be 2 or 3 words"
        [InlineData(false, "h. Wells")] // 7 Description= "Incorrect Capitalization."
        [InlineData(false, "herbert G. Wells")] // 8  Description = "Incorrect Capitalization."
        [InlineData(false, "H Wells")] // 9  Description = "Initials must end with a dot."
        [InlineData(false, "Herb. Wells")] // 10  Description = "Words cannot end with a dot."
        [InlineData(false, "H. George Wells")] // 11  Description = "First name is initial but middle name is word."
        [InlineData(false, "Herbert George W.")] // 12 Description = "Last name cannot be an initial."
        public void ValidName_SuppliedWithAName_ReturnsWhetherNameIsValid(bool expected, string name)
        {
            // Arrange
            // Act
            bool actual = NameValidator.ValidName(name);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(false, "Wells")]
        [InlineData(false, "H")]
        [InlineData(true, "H.")]
        [InlineData(false, "h.")]
        public void IsInitial_SuppliedWithAName_ReturnsWhetherWordIsValid(bool expected, string name)
        {
            // Arrange
            // Act
            bool actual = NameValidator.IsInitial(name);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(true, "Wells")]
        [InlineData(false, "H")]
        [InlineData(false, "H.")]
        [InlineData(false, "wells")]
        public void IsWord_SuppliedWithAName_ReturnsWhetherWordIsValid(bool expected, string name)
        {
            // Arrange
            // Act
            bool actual = NameValidator.IsWord(name);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
