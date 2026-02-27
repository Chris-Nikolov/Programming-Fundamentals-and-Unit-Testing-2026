using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.Tests;

public class EvenNumbersTests
{
    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsErrorMessage_WhenStartIsGreaterThanEnd()
    {
        var startNumber = 2;
        var endNumber = 1;
        var expected = "Start number should be smaller than end number.";
        var result = EvenNumbers.GetEvenNumbersInRange(startNumber, endNumber);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsErrorMessage_WhenStartIsNegative()
    {
        var startNumber = -1;
        var endNumber = 2;
        var expected = "Start number should be positive number.";
        var result = EvenNumbers.GetEvenNumbersInRange(startNumber, endNumber);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsEmptyResult_WhenStartAndEndAreEqualOddNumbers()
    {
        var startNumber = 1;
        var endNumber = 1;
        var expected = "Empty result";
        var result = EvenNumbers.GetEvenNumbersInRange(startNumber, endNumber);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsSingleEvenNumber_WhenStartAndEndAreEqualEvenNumbers()
    {
        var startNumber = 2;
        var endNumber = 2;
        var expected = "2";
        var result = EvenNumbers.GetEvenNumbersInRange(startNumber, endNumber);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsEvenNumbers_WhenRangeHasEvens()
    {
        var startNumber = 1;
        var endNumber = 4;
        var expected = "2, 4";
        var result = EvenNumbers.GetEvenNumbersInRange(startNumber, endNumber);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsEvenNumbers_WhenStartAndEndAreEvenNumbers()
    {
        var startNumber = 2;
        var endNumber = 8;
        var expected = "2, 4, 6, 8";
        var result = EvenNumbers.GetEvenNumbersInRange(startNumber, endNumber);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsEvenNumbers_WhenStartAndEndAreOddNumbers()
    {
        var startNumber = 1;
        var endNumber = 3;
        var expected = "2";
        var result = EvenNumbers.GetEvenNumbersInRange(startNumber, endNumber);
        Assert.That(result, Is.EqualTo(expected));
    }
}
