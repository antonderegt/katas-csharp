using System.Collections.Generic;
using System.Linq;

namespace Katas.Bookstore
{
    public class Bookstore
    {
        public static double PriceRecursive(int[] books)
        {
            if (books.Length == 0) return 0;

            List<int> bookList = new(books);
            HashSet<int> uniqueBooks = new();
            for (int i = 0; i < bookList.Count; i++)
            {
                int currentBook = bookList.ElementAt(i);
                if (!uniqueBooks.Contains(currentBook))
                {
                    uniqueBooks.Add(currentBook);
                    bookList.RemoveAt(i);
                    i--;
                }
            }

            int numUniqueBooks = uniqueBooks.Count;
            double discount = CalculateDiscount(numUniqueBooks);

            return PriceRecursive(bookList.ToArray()) + 8 * numUniqueBooks * discount;
        }

        public static double Price(int[] books)
        {
            if (books.Length == 0) return 0;

            List<int> bookList = new(books);
            double price = 0.0;

            while (bookList.Count > 0)
            {
                HashSet<int> uniqueBooks = new();
                for (int i = 0; i < bookList.Count; i++)
                {
                    int currentBook = bookList.ElementAt(i);
                    if (!uniqueBooks.Contains(currentBook))
                    {
                        uniqueBooks.Add(currentBook);
                        bookList.RemoveAt(i);
                        i--;
                    }
                }

                int numUniqueBooks = uniqueBooks.Count;
                double discount = CalculateDiscount(numUniqueBooks);

                price += 8 * numUniqueBooks * discount;
            }

            return price;
        }

        private static double CalculateDiscount(int numOfBooks)
        {
            return numOfBooks switch
            {
                4 => 0.8,
                3 => 0.9,
                2 => 0.95,
                _ => 1.0,
            };
        }
    }
}
