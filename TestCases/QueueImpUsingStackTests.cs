using CodeSamples;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestCases
{
    public class QueueImpUsingStackTests
    {
        [Fact]
        public void PassingTests()
        {
            var queue = new QueueImplementationUsingStack();
            queue.Enqueue(5);
            queue.Enqueue(15);
            Assert.Equal<int>(5,queue.Dequeue());

        }
    }
}
