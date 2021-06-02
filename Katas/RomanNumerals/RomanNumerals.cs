namespace Katas.RomanNumerals
{
    public class RomanNumerals
    {
        public static string ConvertToRoman(int num)
        {
            string roman = "";

            roman += GetAllRomanOfType(num, 1000);
            num -= (num / 1000) * 1000;

            if (num >= 900)
            {
                roman += "CM";
                num -= 900;
            }
            roman += GetAllRomanOfType(num, 500);
            num -= (num / 500) * 500;

            if (num >= 400)
            {
                roman += "CD";
                num -= 400;
            }
            roman += GetAllRomanOfType(num, 100);
            num -= (num / 100) * 100;

            if (num >= 90)
            {
                roman += "XC";
                num -= 90;
            }
            roman += GetAllRomanOfType(num, 50);
            num -= (num / 50) * 50;

            if (num >= 40)
            {
                roman += "XL";
                num -= 40;
            }
            roman += GetAllRomanOfType(num, 10);
            num -= (num / 10) * 10;

            if(num == 9)
            {
                roman += "IX";
                num = 0;
            }
            roman += GetAllRomanOfType(num, 5);
            num -= (num / 5) * 5;

            if (num == 4)
            {
                roman += "IV";
                num = 0;
            }
            roman += GetAllRomanOfType(num, 1);

            return roman;
        }

        public static string GetAllRomanOfType(int num, int divider)
        {
            string roman = "";
            int d = num / divider;

            while (d > 0)
            {
                roman += GetSingleRoman(divider);
                d--;
            }

            return roman;
        }

        public static string GetSingleRoman(int num)
        {
            switch (num)
            {
                default:
                case 1:
                    return "I";
                case 5:
                    return "V";
                case 10:
                    return "X";
                case 50:
                    return "L";
                case 100:
                    return "C";
                case 500:
                    return "D";
                case 1000:
                    return "M";
            }
        }
    }
}
