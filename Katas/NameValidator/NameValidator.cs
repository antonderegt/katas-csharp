using System.Collections.Generic;
using System.Linq;

namespace Katas.NameValidator
{
    public class NameValidator
    {
        public static bool ValidName(string name)
        {
            List<string> terms = name.Trim().Split(' ').Where(t => !string.IsNullOrEmpty(t)).ToList();

            if (terms.Count == 2)
            {
                return IsInitial(terms[0]) && IsWord(terms[1]);
            }

            if (terms.Count == 3)
            {
                bool allInitialsExpended = IsWord(terms[0]) && IsWord(terms[1]) && IsWord(terms[2]);
                bool middleInitialExpended = IsWord(terms[0]) && IsInitial(terms[1]) && IsWord(terms[2]);
                bool initialsNotExpended = IsInitial(terms[0]) && IsInitial(terms[1]) && IsWord(terms[2]);

                return allInitialsExpended || middleInitialExpended || initialsNotExpended;
            }

            return false;
        }

        public static bool IsInitial(string term)
        {
            bool hasLengthOfTwo = term.Length == 2;
            bool startsWithLetter = char.IsLetter(term[0]);
            bool startsWithUpper = term[0] == char.ToUpper(term[0]);
            bool endsWithDot = term[^1].Equals('.');

            return hasLengthOfTwo && startsWithLetter && startsWithUpper && endsWithDot;
        }

        public static bool IsWord(string term)
        {
            bool moreThanTwoChars = term.Length > 2;
            bool startWithUpperCase = term[0] == char.ToUpper(term[0]);
            bool containsOnlyChars = term.All(c => char.IsLetter(c));

            return moreThanTwoChars && startWithUpperCase && containsOnlyChars;
        }
    }
}
