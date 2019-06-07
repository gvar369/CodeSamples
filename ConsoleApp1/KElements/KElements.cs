using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeSamples.KElements
{
    public class KElements : IKElements
    {
        public Dictionary<int, int> ProcessData(int[] inputData, int k)
        {
            //Data initilization
            //int[] inputData = new[] { 1, 6, 2, 1, 6, 1 };
            //k = 2;

            //Data processing
            var outputData = inputData
                .GroupBy(g => g) //grouping all data will result groups as {{1,1,1}, {2}, {6,6}}
                .OrderByDescending(o => o.Count()) //this will result in {{1,1,1}, {6,6}, {2}}
                .Select(s => new
                {
                    Val = s.Key,
                    NCount = s.Count()
                }) // this will result in {{1,3}, {6,2}, {2,1}} (Key is the value, Ncount is the number of times the value occurred)
                .Where(w => w.NCount >= k)
                .ToDictionary(x => x.Val, y => y.NCount); // this will result in {{1,3}, {6,2}}

            return outputData;
            //Data printing
            //foreach (var data in outputData)
            //{
            //    Console.WriteLine($"{data.Val} {data.NCount}");
            //}
        }
    }
}
