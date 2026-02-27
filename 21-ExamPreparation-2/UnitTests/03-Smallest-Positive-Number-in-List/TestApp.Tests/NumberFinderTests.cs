using System;
using System.Collections.Generic;
using System.Reflection;
using NUnit.Framework;

namespace TestApp.Tests;

public class NumberFinderTests
{
    [Test]
    public void Test_FindSmallestPositive_ShouldReturnError_WhenListIsNull()
    {
        var expected = "List cannot be empty.";
        var result = NumberFinder.FindSmallestPositive(null);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindSmallestPositive_ShouldReturnError_WhenListIsEmpty()
    {
        var input = new List<int>();
        var result = NumberFinder.FindSmallestPositive(input);
        var expected = "List cannot be empty.";
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindSmallestPositive_ShouldReturnSmallest_WhenListHasPositiveNumbers()
    {
        var input = new List<int>{ 1, 2, 3 };
        var result = NumberFinder.FindSmallestPositive(input);
        var expected = "Smallest positive number is: 1";
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindSmallestPositive_ShouldReturnSmallest_WhenListHasMixedNumbers()
    {
        var input = new List<int>{ 1, 2, 3, -1, -2 };
        var result = NumberFinder.FindSmallestPositive(input);
        var expected = "Smallest positive number is: 1";
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindSmallestPositive_ShouldReturnNotFoundMessage_WhenAllNumbersAreNegativeOrZero()
    {
        var input = new List<int>{ -1, -2, -3, 0 };
        var result = NumberFinder.FindSmallestPositive(input);
        var expected = "No positive numbers found.";
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindSmallestPositive_ShouldHandleDuplicates_Correctly()
    {
        var input = new List<int>{ 1, 2, 3, 1, 2 };
        var result = NumberFinder.FindSmallestPositive(input);
        var expected = "Smallest positive number is: 1";
        Assert.That(result, Is.EqualTo(expected));
    }
}
