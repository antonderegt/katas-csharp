using System;
using System.Linq;

namespace Katas.PasswordChecker
{
    public class PasswordChecker
    {
        private const int MinLength = 8;
        private const string Strong = "Strong";
        private const string Moderate = "Moderate";
        private const string Weak = "Weak";
        private const string Invalid = "Invalid";

        public static bool ContainsLowercase(string password)
        {
            return password.Any(char.IsLower);
        }

        public static bool ContainsUppercase(string password)
        {
            return password.Any(char.IsUpper);
        }

        public static bool ContainsDigit(string password)
        {
            return password.Any(char.IsDigit);
        }

        public static bool ContainsSpecialChar(string password)
        {
            return password.Any(ch => !char.IsLetterOrDigit(ch));
        }

        public static bool ContainsWhiteSpace(string password)
        {
            return password.Any(ch => ch == ' ');
        }

        public static bool CheckLength(string password)
        {
            return password.Length >= MinLength;
        }

        public delegate bool CharChecker(string password);
        public static bool CheckChar(string password, CharChecker charChecker)
        {
            return charChecker(password);
        }

        //int containsLowercase = ContainsLowercase(password) ? 1 : 0;
        //int containsUppercase = ContainsUppercase(password) ? 1 : 0;
        //int containsDigit = ContainsDigit(password) ? 1 : 0;
        //int containsSpecialChar = ContainsSpecialChar(password) ? 1 : 0;
        //int checkLength = CheckLength(password) ? 1 : 0;
        //bool containsWhiteSpace = ContainsWhiteSpace(password);

        public static string CheckPassword(string password)
        {
            bool containsWhiteSpace = password.Any(ch => ch == ' ');
            if (password.Length < 6 || containsWhiteSpace)
            {
                return Invalid;
            }

            int containsLowercase = password.Any(char.IsLower) ? 1 : 0;
            int containsUppercase = password.Any(char.IsUpper) ? 1 : 0;
            int containsDigit = password.Any(char.IsDigit) ? 1 : 0;
            int containsSpecialChar = password.Any(ch => !char.IsLetterOrDigit(ch)) ? 1 : 0;
            int checkLength = password.Length >= MinLength ? 1 : 0;

            ShowHints(containsLowercase, containsUppercase, containsDigit, containsSpecialChar, checkLength);

            int passwordStrength = containsLowercase + containsUppercase + containsDigit + containsSpecialChar + checkLength;

            if (passwordStrength == 5)
                return Strong;

            if (passwordStrength >= 3)
                return Moderate;

            return Weak;
        }

        private static void ShowHints(int containsLowercase, int containsUppercase, int containsDigit, int containsSpecialChar, int checkLength)
        {
            if (containsLowercase == 0)
            {
                Console.WriteLine("Password has to contain a lowercase letter.");
            }
            if (containsUppercase == 0)
            {
                Console.WriteLine("Password has to contain a uppercase letter.");
            }
            if (containsDigit == 0)
            {
                Console.WriteLine("Password has to contain a digit.");
            }
            if (containsSpecialChar == 0)
            {
                Console.WriteLine("Password has to contain a special char.");
            }
            if (checkLength == 0)
            {
                Console.WriteLine("Password has to be at least 8 characters.");
            }
        }
    }
}
