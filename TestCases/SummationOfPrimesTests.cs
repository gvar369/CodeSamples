using System;
using System.Collections.Generic;
using System.Text;
using CodeSamples.KElements;
using CodeSamples.SummationOfPrimes;
using Xunit;

namespace XUnitTestProject1
{
    public class SummationOfPrimesTests
    {
        [Fact]
        void PassingTest()
        {
            var sumOfPrimes = new SummationOfPrimes();
            var inputData = 10;
            var expectedOutput = 17;
            Assert.Equal(expectedOutput, sumOfPrimes.ProcessData(inputData));
        }

        //[Fact]
        //void LargeDataPassingTest()
        //{
        //    var sumOfPrimes = new SummationOfPrimes();
        //    var inputData = 2000000;
        //    var expectedOutput = 142913828922;
        //    Assert.Equal(expectedOutput, sumOfPrimes.ProcessData(inputData));
        //}

        //[Fact]
        //void LinqPassingTest()
        //{
        //    var sumOfPrimes = new SummationOfPrimes();
        //    var inputData = 10;
        //    var expectedOutput = 17;
        //    Assert.Equal(expectedOutput, sumOfPrimes.ProcessDataLinq(inputData));
        //}

        //[Fact]
        //void FailingTest()
        //{
        //    var kElements = new KElements();
        //    var inputData = new[] { 1, 6, 2, 1, 6, 1, 1 };
        //    var expectedOutput = new Dictionary<int, int> { { 1, 3 }, { 6, 2 } };
        //    Assert.NotEqual(expectedOutput, kElements.ProcessData(inputData, 2));
        //}
    }
}
