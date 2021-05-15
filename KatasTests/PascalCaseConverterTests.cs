using Xunit;
using Katas.PascalCaseConverter;

namespace KatasTests
{
    public class PascalCaseConverterTests
    {
        [Fact]
        public void FilterInput_StringWithSpaces_ShouldFilterInput()
        {
            // Arrange
            string sentence = "pineapple  on pizza";
            PascalCaseConverter pcc = new();
            string expected = "pineapple on pizza";
            // Act
            string actual = pcc.FilterInput(sentence);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FilterInput_StringWithSpecialCharacters_ShouldFilterInput()
        {
            // Arrange
            string sentence = "pineapple! on @pizza#";
            PascalCaseConverter pcc = new();
            string expected = "pineapple on pizza";
            // Act
            string actual = pcc.FilterInput(sentence);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MakeCamalCase_LowerCaseString_ShouldCamelCaseString()
        {
            // Arrange
            string[] sentence = "pineapple on pizza".Split(' ');
            PascalCaseConverter pcc = new();
            string expected = "PineappleOnPizza";
            // Act
            string actual = pcc.MakePascalCase(sentence);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("pinea#pple  on pizza!", "PineappleOnPizza")]
        [InlineData("pineapple  on pizza", "PineappleOnPizza")]
        [InlineData("The quick brown fox jumped over the lazy dog", "TheQuickBrownFoxJumpedOverTheLazyDog")]
        [InlineData("The qUick!  bRoWn fox    jumped, OVER the    lazy. dog", "TheQuickBrownFoxJumpedOverTheLazyDog")]
        public void Convert_LowerCaseStringWithExtraSpacesAndSpecialCharacters_ShouldCamelCaseString(string sentence, string expected)
        {
            // Arrange
            PascalCaseConverter pcc = new();
            // Act
            string actual = pcc.Convert(sentence);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
