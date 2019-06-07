using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CodeSamples.IntegerToEnglish
{
    public class IntegerToEnglish
    {

        private static string[] ones = {
            "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
            "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen",
        };

        private static string[] tens = { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        private static string[] thous = { "hundred", "thousand", "million", "billion", "trillion", "quadrillion" };

        public string NumberToWords(int num)
        {
            string numString = "";
            if (num < 100)
            {
                if (num < 20)
                    numString = ones[num];
                else
                {
                    numString = tens[num / 10];
                    if ((num % 10) > 0)
                        numString += " " + ones[num % 10];
                }
            }
            else
            {
                int pow = 0, log = 0;
                string powStr = "";

                if (num < 1000) // number is between 100 and 1000
                {
                    pow = 100;
                    powStr = thous[0];
                }
                else // find the scale of the number
                {
                    log = (int) Math.Log(num, 1000);
                    pow = (int) Math.Pow(1000, log);
                    powStr = thous[log];
                }

                //int pow1 = Convert.ToInt32(powStr);

                numString = string.Format("{0} {1} {2}", NumberToWords(num / pow), powStr, NumberToWords(num % pow)).Trim();
            }

            return new CultureInfo("en-US", false).TextInfo.ToTitleCase(string.Format("{0}", numString).Trim());
        }
    }
}
