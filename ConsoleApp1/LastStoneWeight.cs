using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeSamples
{
    class LastStoneWeight
    {
        public static int LastStoneWeight1(int[] stones)
        {
            var sStones = stones.OrderByDescending(o => o).ToArray();
            while (sStones.Length > 1)
            {
                if (sStones[0] == sStones[1])
                    sStones[0] = 0;
                else
                    sStones[0] = sStones[0] - sStones[1];

                sStones[1] = 0;

                sStones = sStones.Where(w => w != 0).OrderByDescending(o => o).ToArray();
                Console.WriteLine("[" + string.Join(", ", sStones) + "]");
            }
            return sStones[0];
        }

        public static int LastStoneWeight2(int[] stones)
        {
            var dp = new bool[1501];
            dp[0] = true;
            int sumA = 0;
            foreach (var s in stones)
            {
                sumA += s;
                for (int i = 1500; i >= s; --i)
                {
                    dp[i] |= dp[i - s];
                }
            }
            for (int i = sumA / 2; i > 0; --i)
            {
                Console.WriteLine(dp[i]);
                if (dp[i]) return sumA - i - 1;
            }

            return 0;

            //while (stones.Length > 2)
            //{
            //    if (stones[0] == stones[1])
            //        stones[0] = 0;
            //    else
            //    {
            //        if (stones[0] > stones[1])
            //            stones[0] = stones[0] - stones[1];
            //        else
            //            stones[0] = stones[1] - stones[0];
            //    }


            //    stones[1] = 0;

            //    stones = stones.Where(w => w != 0).ToArray();
            //    Console.WriteLine("[" + string.Join(", ", stones) + "]");
            //}
            //return stones.Min();
        }
    }
}
