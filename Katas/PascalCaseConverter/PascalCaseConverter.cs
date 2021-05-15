using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.PascalCaseConverter
{
    /// <summary>
    /// Converts a string to CamelCase.
    /// </summary>
    public class PascalCaseConverter
    {
        /// <summary>
        /// Converts a string to CamelCase.
        /// </summary>
        /// <param name="sentence">Input sentence</param>
        /// <returns>PascalCase string</returns>
        public string Convert(string sentence)
        {
            string filteredInput = FilterInput(sentence);

            string[] splitOnWhiteSpace = filteredInput.Split(' ');

            string pascalCase = MakePascalCase(splitOnWhiteSpace);

            return pascalCase;
        }

        /// <summary>
        /// Filters extra spaces and special characters from sentence.
        /// </summary>
        /// <param name="sentence">Input sentence</param>
        /// <returns>Filtered string</returns>
        public string FilterInput(string sentence)
        {
            char[] chars = sentence.ToCharArray();

            StringBuilder sb = new StringBuilder();
            sb.Append(chars[0]);

            for (int i = 1; i < chars.Length; i++)
            {
                if ((chars[i] >= '0' && chars[i] <= '9') || (chars[i] >= 'A' && chars[i] <= 'Z') || (chars[i] >= 'a' && chars[i] <= 'z'))
                {
                    sb.Append(chars[i]);
                }
                else if (chars[i] == ' ' && chars[i - 1] != ' ')
                {
                    sb.Append(' ');
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Converts a string array to CamelCase.
        /// </summary>
        /// <param name="words">String array</param>
        /// <returns>PascalCase string</returns>
        public string MakePascalCase(string[] words)
        {
            string[] pascalCase = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                string lowerCaseWord = words[i].ToLower();
                string word = char.ToUpper(lowerCaseWord[0]) + lowerCaseWord.Substring(1);
                pascalCase[i] = word;
            }

            return String.Join("", pascalCase);
        }
    }
}
