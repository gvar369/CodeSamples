using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeSamples.KElements;
using Xunit;

namespace XUnitTestProject1
{
    public class KElementTest
    {
        [Fact]
        void PassingTest()
        {
            var kElements = new KElements();
            var inputData = new[] {1, 6, 2, 1, 6, 1};
            var expectedOutput = new Dictionary<int, int> { {1, 3}, {6, 2} };
            Assert.Equal(expectedOutput, kElements.ProcessData(inputData, 2));
        }

        [Fact]
        void FailingTest()
        {
            var kElements = new KElements();
            var inputData = new[] { 1, 6, 2, 1, 6, 1, 1 };
            var expectedOutput = new Dictionary<int, int> { { 1, 3 }, { 6, 2 } };
            Assert.NotEqual(expectedOutput, kElements.ProcessData(inputData, 2));
        }
    }
}
