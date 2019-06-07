using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSamples
{
    class RemoveDuplicates
    {
        public static string RemoveDuplicates1(string S)
        {
            int i = 0;
            StringBuilder sb = new StringBuilder(S);
            while (i < sb.Length - 1)
            {
                if (sb[i] == sb[i + 1])
                {
                    sb.Remove(i, 2);
                    i = 0;
                }
                else
                    i++;
                Console.WriteLine(i);
                Console.WriteLine(sb.ToString());
            }

            return sb.ToString();
        }
    }
}
