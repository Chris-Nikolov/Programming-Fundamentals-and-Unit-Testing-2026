using NUnit.Framework;

namespace TestApp.Tests
{
    public class PerfectSquareIntegersTests
    {
        [Test]
        public void Test_FindPerfectSquares_StartNumberGreaterThanEndNumber_ReturnsErrorMessage()
        {
            var startNumber = 11;
            var endNumber = 2;
            var expected = "Start number should be less than end number.";
            var result = PerfectSquareIntegers.FindPerfectSquares(startNumber, endNumber);
            Assert.That(result, Is.EqualTo(expected));
            
        }

        [Test]
        public void Test_FindPerfectSquares_GetSameSquareIntegerForStartAndEnd_ReturnsSameSquareInteger()
        {
            var startNumber = 1;
            var endNumber = 1;
            var expected = "1";
            var result = PerfectSquareIntegers.FindPerfectSquares(startNumber, endNumber);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_FindPerfectSquares_GetZeroAsSingleInteger_ReturnsZero()
        { 
            var startNumber = 0;
            var endNumber = 0;
            var expected = "0";
            var result = PerfectSquareIntegers.FindPerfectSquares(startNumber, endNumber);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_FindPerfectSquares_RangeIncludesMultiplePerfectSquares_RetursOnlySquareIntegers()
        {
            var startNumber = 1;
            var endNumber = 50;
            var expected = "1 4 9 16 25 36 49";
            var result = PerfectSquareIntegers.FindPerfectSquares(startNumber, endNumber);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_FindPerfectSquares_NoPerfectSquaresInRange_ReturnsEmptyString()
        {
            var startNumber = 2;
            var endNumber = 3;
            var expected = "";
            var result = PerfectSquareIntegers.FindPerfectSquares(startNumber, endNumber);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}

