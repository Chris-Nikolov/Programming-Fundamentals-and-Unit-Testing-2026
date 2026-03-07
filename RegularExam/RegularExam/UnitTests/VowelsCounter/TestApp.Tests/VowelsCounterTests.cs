using System;
using System.Text;
using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.Tests
{
    public class VowelsCounterTests
    {
        [Test]
        public void Test_CountTotalVowels_GetEmptyList_ReturnsZero()
        {
            var input =  new List<string>();
            var expected = 0;
            var result = VowelsCounter.CountTotalVowels(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_CountTotalVowels_GetListWithEmptyStringValues_ReturnsZero()
        {
            var input =  new List<string>{"", "", ""};
            var expected = 0;
            var result = VowelsCounter.CountTotalVowels(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_CountTotalVowels_MultipleLowerCaseStrings_ReturnsVowelsCount()
        {
            var input =  new List<string>{"a", "i", "w", "y", "k"};
            var expected = 2;
            var result = VowelsCounter.CountTotalVowels(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_CountTotalVowels_GetStringsWithNoVowels_ReturnsZero()
        {
            var input =  new List<string>{"b", "c", "q", "l", "x"};
            var expected = 0;
            var result = VowelsCounter.CountTotalVowels(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_CountTotalVowels_StringsWithMixedCaseVowels_ReturnsVowelsCount()
        {
            var input =  new List<string>{"A", "i", "W", "y", "k", "o", "U"};
            var expected = 4;
            var result = VowelsCounter.CountTotalVowels(input);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
