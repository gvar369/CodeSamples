using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSamples
{
    class CountOfSmallNumbersAfterSelf
    {
        public IList<int> CountSmaller(int[] nums)
        {
            var output = new List<int>();
            if (nums != null && nums.Length > 0)
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    int count = 0;
                    int start = i + 1;
                    int times = nums.Length - i - 1;

                    for (int j = 0; j < times; j++)
                    {
                        if (nums[i] > nums[start])
                            count++;
                        start++;
                    }
                    output.Add(count);
                }
                output.Add(0);
            }
            return output;
        }
    }
}
