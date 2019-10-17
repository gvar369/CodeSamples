using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSamples
{
    public class CheckPair
    {
        internal int[] CheckPairInSum(int[]Arr,int sum)
        {
            
            for (int i=0;i< Arr.Length;i++)
            {
            if(Arr[i]>sum)
                {
                    Arr[i] = 0;
                }
            }
            
            for (int i = 0; i < Arr.Length; i++)
            {
               if( Arr[i]+Arr[i+1]==sum)
                {
                    return new int[] { Arr[i], Arr[i + 1] };
                }
            }
            return new int[0];
        }

    }
}
