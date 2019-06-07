using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSamples.KElements
{
    public interface IKElements
    {
        Dictionary<int, int> ProcessData(int[] inputData, int k);
    }
}
