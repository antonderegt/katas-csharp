using System;
using System.Linq;

namespace Katas.PigLatin
{
    public class PigLatin
    {
        public static string TranslateWord(string word)
        {
            if (word.Length == 0)
                return "";

            string specialChar = "";
            if (!char.IsLetterOrDigit(word[^1]))
            {
                specialChar = word[^1].ToString();
                word = word[0..^1];
            }

            bool startWithUppercase = false;
            if (char.IsUpper(word[0]))
            {
                startWithUppercase = true;
                word = word.ToLower();
            }

            char[] vowels = { 'a', 'i', 'e', 'o', 'u', 'A', 'I', 'E', 'O', 'U' };
            bool startsWithVowel = vowels.Contains(word[0]);
            int prefexIndex = -1;

            for (int i = 0; i < word.Length; i++)
            {
                if (vowels.Contains(word[i]))
                {
                    prefexIndex = i;
                    break;
                }
            }

            string prefix = word.Substring(0, prefexIndex);
            string postfix = startsWithVowel ? "yay" : "ay";
            postfix += specialChar;
            string middle;

            if (startWithUppercase)
            {
                middle = word.Substring(prefexIndex, 1).ToUpper() + word[(prefexIndex + 1)..];
            }
            else
            {
                middle = word[prefexIndex..];
            }

            return middle + prefix + postfix;
        }

        public static string TranslateSentence(string sentence)
        {
            string pigLatinSentence = "";
            string[] words = sentence.Split(' ');

            foreach (string word in words)
            {
                pigLatinSentence += TranslateWord(word) + ' ';
            }

            return pigLatinSentence.Trim();
        }
    }
}
