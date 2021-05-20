using Xunit;
using Katas.PasswordChecker;

namespace KatasTests
{
    public class PasswordCheckerTests
    {
        [Theory]
        [InlineData(true, "a")]
        [InlineData(false, "A")]
        public void ContainsLowercase_PasswordIsEntered_ShouldReturnTrueIfContainsLowercase(bool expected, string password)
        {
            // Arrange
            // Act
            bool actual = PasswordChecker.ContainsLowercase(password);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(false, "a")]
        [InlineData(true, "A")]
        [InlineData(false, "!@!pass1")]
        public void ContainsUppercase_PasswordIsEntered_ShouldReturnTrueIfContainsUppercase(bool expected, string password)
        {
            // Arrange
            // Act
            bool actual = PasswordChecker.ContainsUppercase(password);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(false, "a")]
        [InlineData(true, "#")]
        public void ContainsSpecialChar_PasswordIsEntered_ShouldReturnTrueIfContainsSpecialChar(bool expected, string password)
        {
            // Arrange
            // Act
            bool actual = PasswordChecker.ContainsSpecialChar(password);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(false, "a")]
        [InlineData(true, "asdfgqwe")]
        public void CheckLength_PasswordIsEntered_ShouldReturnTrueIfLengthIs8(bool expected, string password)
        {
            // Arrange
            // Act
            bool actual = PasswordChecker.CheckLength(password);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(false, "a")]
        [InlineData(true, "1")]
        public void ContainsDigit_PasswordIsEntered_ShouldReturnTrueIfContainsDigit(bool expected, string password)
        {
            // Arrange
            // Act
            bool actual = PasswordChecker.ContainsDigit(password);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(false, "a")]
        [InlineData(true, "a a")]
        public void ContainsWhiteSpace_PasswordIsEntered_ShouldReturnTrueIfContainsWhiteSpace(bool expected, string password)
        {
            // Arrange
            // Act
            bool actual = PasswordChecker.ContainsWhiteSpace(password);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Invalid", "stonk")]
        [InlineData("Invalid", "pass word")]
        [InlineData("Weak", "password")]
        [InlineData("Weak", "11081992")]
        [InlineData("Moderate", "mySecurePass123")]
        [InlineData("Moderate", "!@!pass1")]
        [InlineData("Strong", "@S3cur1t")]
        public void CheckPassword_PasswordIsEntered_ShouldReturnTrueIfAllChecksPass(string expected, string password)
        {
            // Arrange
            // Act
            string actual = PasswordChecker.CheckPassword(password);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
