using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        var input = new char [] {'1', '2', 'A', 'B', 'C', 'D'};
        var expected = new char [] { 'A', 'B', 'C', 'D'};
        var result = Fake.RemoveStringNumbers(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        var input = new char [] {'A', 'B', 'C', 'D'};
        var result = Fake.RemoveStringNumbers(input);
        Assert.That(result, Is.EqualTo(input));
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        var input = Array.Empty<char>();
        var result = Fake.RemoveStringNumbers(input);
        Assert.That(result, Is.EqualTo(input));
    }
}
