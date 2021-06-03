using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.CreditCard
{
    public class CreditCard
    {
        public static bool ValidateNumber(double num)
        {
            double numLength = Math.Floor(Math.Log10(num) + 1);
            if (numLength < 14 || numLength > 19)
                return false;

            double checkDigit = num % 10;
            double numMinusLastDigit = Math.Floor(num / 10);

            var digitList = numMinusLastDigit.ToString().Reverse().Select(c => c - '0').ToList();
            
            for (int i = 0; i < digitList.Count; i += 2)
            {
                int doubled = digitList[i] * 2;
                int doubledSingleDigit = doubled >= 10 ? 1 + doubled % 10 : doubled;
                digitList[i] = doubledSingleDigit;
            }

            int sum = digitList.Sum();

            return checkDigit == (10 - sum % 10);
        }
    }
}
