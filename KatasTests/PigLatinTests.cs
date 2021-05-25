using Katas.PigLatin;
using System;
using Xunit;

namespace KatasTests
{
    public class PigLatinTests
    {
        [Theory]
        [InlineData("flag", "agflay")]
        [InlineData("Flag", "Agflay")]
        [InlineData("Apple", "Appleyay")]
        [InlineData("button", "uttonbay")]
        [InlineData("", "")]
        [InlineData("ate", "ateyay")]
        [InlineData("apple", "appleyay")]
        [InlineData("oaken", "oakenyay")]
        [InlineData("eagle", "eagleyay")]
        [InlineData("have", "avehay")]
        [InlineData("cram", "amcray")]
        [InlineData("take", "aketay")]
        [InlineData("cat", "atcay")]
        [InlineData("shrimp", "impshray")]
        [InlineData("trebuchet", "ebuchettray")]
        public void TranslateWord_WhenGivenAWord_ShouldReturnPigLatinizedWord(string word, string expected)
        {
            // Arrange

            // Act
            string actual = PigLatin.TranslateWord(word);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Honey waffles.", "Oneyhay afflesway.")]
        [InlineData("I like to eat honey waffles.", "Iyay ikelay otay eatyay oneyhay afflesway.")]
        [InlineData("Do you think it is going to rain today?", "Oday ouyay inkthay ityay isyay oinggay otay ainray odaytay?")]
        public void TranslateSentence_WhenGivenASentence_ShouldReturnPigLatinizedSentence(string sentence, string expected)
        {
            // Arrange

            // Act
            string actual = PigLatin.TranslateSentence(sentence);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
