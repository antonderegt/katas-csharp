using System;
using System.Linq;

namespace Katas.RemoveLetters
{
    /// <summary>
    /// This class can remove certain letters from string arrays.
    /// </summary>
    public class RemoveLetters
    {
        public string[] Letters { get; set; }
        public string Word { get; set; }

        /// <summary>
        /// Checks if a letter occurce more in the array or in the word.
        /// </summary>
        /// <param name="ch">Letter to count</param>
        /// <param name="word">The word on which the letter is counted</param>
        /// <param name="letters">The array on which the letter is counted</param>
        /// <returns>True if occurence of letter is higher in array, otherwise false</returns>
        public bool ArrayOccurenceIsHigher(string ch, string word, string[] letters)
        {
            int countOccurenceInString = word.Count(c => c == char.Parse(ch));
            int countOccurenceInArray = letters.Count(c => c == ch);

            return countOccurenceInArray > countOccurenceInString;
        }

        /// <summary>
        /// Remove letters from an array of letters.
        /// </summary>
        /// <returns>String array of remaining letters</returns>
        public string[] RemoveLettersFromArray()
        {
            return Letters.Where(ch => ArrayOccurenceIsHigher(ch, Word, Letters)).Distinct().ToArray();
        }
    }
}
