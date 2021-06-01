using System;
using System.Globalization;

namespace Katas.ColorUtil
{
    public class ColorUtil
    {
        public static bool ValidRgbColor(string rgb)
        {
            int numOfTerms = 3;
            int trimStart = 4;
            if (rgb.Substring(0, 5).Equals("rgba("))
            {
                numOfTerms = 4;
                trimStart = 5;
            }

            rgb = rgb.Substring(trimStart);
            rgb = rgb.Substring(0, rgb.Length - 1);
            var terms = rgb.Split(",");

            if (terms.Length != numOfTerms)
                return false;

            for (int i = 0; i < terms.Length; i++)
            {
                terms[i] = terms[i].Trim();
            }

            int r, g, b;
            double a;
            try
            {
                r = Int32.Parse(terms[0]);
                g = Int32.Parse(terms[1]);
                b = Int32.Parse(terms[2]);
                if (numOfTerms == 4)
                {
                    string alpha = 0 + terms[3];
                    a = double.Parse(alpha, CultureInfo.InvariantCulture);
                    if (a < 0 || a > 1)
                        return false;
                }
                return NumBetween0And255(r) && NumBetween0And255(g) && NumBetween0And255(b);
            }
            catch
            {
                string percentageString = String.Join("", terms);
                var newTerms = percentageString.Split("%");
                try
                {
                    r = Int32.Parse(newTerms[0]);
                    g = Int32.Parse(newTerms[1]);
                    b = Int32.Parse(newTerms[2]);
                    if (numOfTerms == 4)
                    {
                        string alpha = 0 + terms[3];
                        a = Double.Parse(alpha);
                        if (a < 0 || a > 1)
                            return false;
                    }
                    return NumBetween0And100(r) && NumBetween0And100(g) && NumBetween0And100(b);
                }
                catch
                {
                    return false;
                }
            }
        }

        public static bool NumBetween0And255(int num)
        {
            if (num >= 0 && num <= 255)
                return true;

            return false;
        }

        public static bool NumBetween0And100(int num)
        {
            if (num >= 0 && num <= 100)
                return true;

            return false;
        }
    }
}
