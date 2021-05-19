using System.Linq;

namespace Katas.Reducto
{
    /// <summary>
    /// Responsible for Reducto Multiplictum.
    /// </summary>
    public class Reducto
    {
        /// <summary>
        /// Sums up all input values and calculates the product of the digits of the sum until the result is a single digit.
        /// </summary>
        /// <param name="list">Unknown number of ints</param>
        /// <returns>Single digit</returns>
        public static int SumDigProd(params int[] list)
        {
            int sumOfInputs = list.Sum();
            int productOfDigits = sumOfInputs;

            // Take the product of the digits until the result is a single digit
            while (productOfDigits > 10)
            {
                productOfDigits = ProductOfDigits(productOfDigits);
            }

            return productOfDigits;
        }

        /// <summary>
        /// Calculates the product of the individual digits in a number.
        /// </summary>
        /// <param name="number">Number of any length</param>
        /// <returns>Product of digits</returns>
        public static int ProductOfDigits(int number)
        {
            return number.ToString().Aggregate(1, (total, c) => (c - '0') * total);
        }
    }
}
