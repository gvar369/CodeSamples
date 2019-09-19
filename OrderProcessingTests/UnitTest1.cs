using OrderProcessing;
using System;
using Xunit;

namespace OrderProcessingTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var result = new Program().CheckInventory("X", 5);
            Assert.True(result);
        }
        [Fact]
        public void Test2()
        {
            var result = new Program().CheckInventory("X", 7);
            Assert.False(result);
        }
        [Fact]
        public void Test3()
        {
            var result = new Program().ChargePayment("164781198", 50);
            Assert.False(result);
        }
        [Fact]
        public void Test4()
        {
            var result = new Program().ChargePayment("164781198", 100);
            Assert.False(result);
        }
    }
}
