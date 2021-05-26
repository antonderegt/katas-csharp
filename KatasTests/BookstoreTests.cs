using Katas.Bookstore;
using Xunit;

namespace KatasTests
{
    public class BookstoreTests
    {
        [Theory]
        [InlineData(0, new int[] { })]
        [InlineData(8, new int[] { 1 })]
        [InlineData(8, new int[] { 2 })]
        [InlineData(8, new int[] { 3 })]
        [InlineData(8 * 3, new int[] { 1, 1, 1 })]
        public void PriceRecursive_OneOrZeroBooks_ShouldReturn0Or8(double expected, int[] books)
        {
            // Arrange
            // Act
            double actual = Bookstore.PriceRecursive(books);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8 * 2 * 0.95, new int[] { 0, 1 })]
        [InlineData(8 * 3 * 0.9, new int[] { 0, 2, 3 })]
        [InlineData(8 * 4 * 0.8, new int[] { 0, 1, 2, 3 })]
        public void PriceRecursive_MiltipleDifferentBooks_ShouldReturnDiscountedPrice(double expected, int[] books)
        {
            // Arrange
            // Act
            double actual = Bookstore.PriceRecursive(books);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8 + (8 * 2 * 0.95), new int[] { 0, 0, 1 })]
        [InlineData(2 * (8 * 2 * 0.95), new int[] { 0, 0, 1, 1 })]
        [InlineData((8 * 4 * 0.8) + (8 * 2 * 0.95), new int[] { 0, 0, 1, 2, 2, 3 })]
        [InlineData((8 * 3 * 0.9) + (8 * 3 * 0.9) + (8 * 3 * 0.9), new int[] { 0, 0, 0, 1, 1, 1, 2, 2, 2 })]
        [InlineData((8 * 4 * 0.8) + (8 * 3 * 0.9) + (8 * 3 * 0.9), new int[] { 0, 0, 0, 1, 1, 1, 2, 2, 2, 3 })]
        [InlineData((8 * 4 * 0.8) + (8 * 4 * 0.8) + 8, new int[] { 0, 0, 1, 1, 2, 2, 3, 3, 3 })]
        public void PriceRecursive_MiltipleDifferentAndDoubleBooks_ShouldReturnDiscountedPrice(double expected, int[] books)
        {
            // Arrange
            // Act
            double actual = Bookstore.PriceRecursive(books);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, new int[] { })]
        [InlineData(8, new int[] { 1 })]
        [InlineData(8, new int[] { 2 })]
        [InlineData(8, new int[] { 3 })]
        [InlineData(8 * 3, new int[] { 1, 1, 1 })]
        public void Price_OneOrZeroBooks_ShouldReturn0Or8(double expected, int[] books)
        {
            // Arrange
            // Act
            double actual = Bookstore.Price(books);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8 * 2 * 0.95, new int[] { 0, 1 })]
        [InlineData(8 * 3 * 0.9, new int[] { 0, 2, 3 })]
        [InlineData(8 * 4 * 0.8, new int[] { 0, 1, 2, 3 })]
        public void Price_MiltipleDifferentBooks_ShouldReturnDiscountedPrice(double expected, int[] books)
        {
            // Arrange
            // Act
            double actual = Bookstore.Price(books);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8 + (8 * 2 * 0.95), new int[] { 0, 0, 1 })]
        [InlineData(2 * (8 * 2 * 0.95), new int[] { 0, 0, 1, 1 })]
        [InlineData((8 * 4 * 0.8) + (8 * 2 * 0.95), new int[] { 0, 0, 1, 2, 2, 3 })]
        [InlineData((8 * 3 * 0.9) + (8 * 3 * 0.9) + (8 * 3 * 0.9), new int[] { 0, 0, 0, 1, 1, 1, 2, 2, 2 })]
        [InlineData((8 * 4 * 0.8) + (8 * 3 * 0.9) + (8 * 3 * 0.9), new int[] { 0, 0, 0, 1, 1, 1, 2, 2, 2, 3 })]
        [InlineData((8 * 4 * 0.8) + (8 * 4 * 0.8) + 8, new int[] { 0, 0, 1, 1, 2, 2, 3, 3, 3 })]
        public void Price_MiltipleDifferentAndDoubleBooks_ShouldReturnDiscountedPrice(double expected, int[] books)
        {
            // Arrange
            // Act
            double actual = Bookstore.Price(books);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
