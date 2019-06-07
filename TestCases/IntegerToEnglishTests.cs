using CodeSamples.IntegerToEnglish;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xunit;

namespace XUnitTestProject1
{
    public class IntegerToEnglishTests
    {
        [Fact]
        void PassingTest()
        {
            var intToEnglish = new IntegerToEnglish();
            var inputData = 1234;
            var expectedOutput = "one thousand two hundred thirty four";
            Assert.Equal(new CultureInfo("en-US", false).TextInfo.ToTitleCase(expectedOutput), intToEnglish.NumberToWords(inputData));
            Assert.Equal(new CultureInfo("en-US", false).TextInfo.ToTitleCase("one hundred"), intToEnglish.NumberToWords(100));
        }
    }
}
