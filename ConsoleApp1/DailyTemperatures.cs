using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeSamples
{
    class DailyTemperatures
    {
        public static int[] DailyTemperatures1(int[] T)
        {
            var stack = new Stack<int>();
            var output = new int[T.Length];
            for (int i = 0; i < T.Length; i++)
            {
                while (stack.Count() > 0 && T[i] > T[stack.Peek()])
                {
                    int idx = stack.Pop();
                    output[idx] = i - idx;
                }
                stack.Push(i);
            }
            return output;
        }

        public static int[] DailyTemperatures2(int[] T)
        {
            var length = T.Length;
            var output = new int[length];

            for (int i = 0; i < length; i++)
            {
                int currentTemp = T[i];
                int k = i + 1;
                for (int j = 0; j < length - i - 1; j++)
                {
                    if (T[k] > currentTemp)
                    {
                        output[i] = k - i;
                        break;
                    }
                    k++;
                }
            }
            return output;
        }
    }
}
