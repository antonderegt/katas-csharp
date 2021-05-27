using Katas.Parseltongue;
using Xunit;

namespace KatasTests
{
    public class ParseltongueTests
    {
        [Theory]
        [InlineData(true, "abc def")]
        [InlineData(false, "s")]
        [InlineData(true, "ss")]
        [InlineData(true, "Sshe ssselected to eat that apple.")]
        [InlineData(false, "She ssselected to eat that apple.")]
        [InlineData(true, "You ssseldom sssspeak sso boldly, ssso messmerizingly.")]
        [InlineData(false, "Steve likes to eat pancakes")]
        [InlineData(true, "Sssteve likess to eat pancakess")]
        [InlineData(false, "Beatrice samples lemonade")]
        [InlineData(true, "Beatrice enjoysss lemonade")]
        public void IsParselTongue_WhenSuppliedWithAString_ReturnTrueIfItIsInParselTongue(bool expected, string sentence)
        {
            // Arrange
            // Act
            bool actual = Parseltongue.IsParseltongue(sentence);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
