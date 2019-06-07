using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSamples
{
    class GcdOfStrings
    {
        public static string GcdOfStrings1(string str1, string str2)
        {
            if (str1.Length == str2.Length)
            {
                if (str1.Equals(str2))
                {
                    Console.WriteLine($"str1: {str1}, str2: {str2}");
                    return str1;
                }
                else
                    return "";
            }
            else
            {
                if (str1.Length < str2.Length)
                {
                    Console.WriteLine($"switching str1: {str1}, str2: {str2}");
                    return GcdOfStrings1(str2, str1);
                }
                else
                {
                    Console.WriteLine($"str1 - substring: {str1.Substring(str2.Length)}, str2: {str2}");
                    return GcdOfStrings1(str1.Substring(str2.Length), str2);
                }

            }
        }
    }
}
