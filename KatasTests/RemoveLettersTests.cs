using Katas.RemoveLetters;
using System.Linq;
using Xunit;

namespace KatasTests
{
    public class RemoveLettersTests
    {
        [Fact]
        public void Constructor_InitializeRemoveLetters_ShouldHaveAnArrayOfLetters()
        {
            // Arrange
            string[] letters = { "t", "t", "e", "s", "t", "u" };
            string[] expected = letters;
            RemoveLetters removeLetters = new() { Letters = letters };
            // Act
            string[] actual = removeLetters.Letters;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Constructor_InitializeRemoveLetters_ShouldHaveAString()
        {
            // Arrange
            string word = "testing";
            string expected = word;
            RemoveLetters removeLetters = new() { Word = word };
            // Act
            string actual = removeLetters.Word;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckCount_CountOccurenceInStringAndArray_ShouldReturnTrueIfArrayCountIsHigher()
        {
            // Arrange
            string[] letters = { "t", "t" };
            string word = "t";
            RemoveLetters removeLetters = new() { Letters = letters, Word = word };
            bool expected = letters.Count(c => c == "t") > word.Count(c => c == 't');
            // Act
            bool actual = removeLetters.ArrayOccurenceIsHigher("t", word, letters);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new string[] { "s", "t", "r", "i", "n", "g", "w" }, "string", new string[] { "w" })]
        [InlineData(new string[] { "b", "b", "l", "l", "g", "n", "o", "a", "w" }, "balloon", new string[] { "b", "g", "w" })]
        [InlineData(new string[] { "a", "n", "r", "y", "o", "w" }, "norway", new string[] { })]
        public void RemoveLetters_RemoveLettersFromArray_ShouldReturnNonDuplicateLetters(string[] letters, string word, string[] expected)
        {
            // Arrange
            RemoveLetters removeLetters = new() { Letters = letters, Word = word };
            // Act
            string[] actual = removeLetters.RemoveLettersFromArray();
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
