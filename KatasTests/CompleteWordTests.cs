using Xunit;
using Katas.CompleteWord;

namespace KatasTests
{
    public class CompleteWordTests
    {
        [Theory]
        [InlineData(true, "a", "a")]
        [InlineData(false, "a", "b")]
        [InlineData(true, "butl", "beautiful")]
        [InlineData(false, "butlz", "beautiful")]
        [InlineData(false, "tulb", "beautiful")]
        [InlineData(false, "bbutl", "beautiful")]
        [InlineData(true, "llo", "hello")]
        public void CanComplete_WhenSuppliedWithInputAndWord_ReturnsIfInputCanBeCompletedToWord(bool expected, string input, string word)
        {
            // Arrange & Act
            bool actual = CompleteWord.CanComplete(input, word);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
