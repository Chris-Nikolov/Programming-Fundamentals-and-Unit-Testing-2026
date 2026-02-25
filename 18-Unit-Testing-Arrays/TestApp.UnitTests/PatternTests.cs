using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        var input = new[] { 1, 2, 3, 3, 4 };
        var expected = new[] { 1, 4, 2, 3 };
        var result = Pattern.SortInPattern(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        var input = Array.Empty<int>();
        var result = Pattern.SortInPattern(input);
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        var input = new[] { 1 };
        var result = Pattern.SortInPattern(input);
        Assert.That(result, Is.EqualTo(input));
        
    }
}
