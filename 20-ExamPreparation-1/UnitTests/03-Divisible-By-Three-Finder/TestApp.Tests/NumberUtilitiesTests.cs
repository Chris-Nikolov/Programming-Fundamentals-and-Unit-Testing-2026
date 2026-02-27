using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.Tests;

public class NumberUtilitiesTests
{
    [Test]
    public void GetDivisibleByThree_ShouldReturnEmptyString_WhenNoNumbersDivisibleByThree()
    {
        var input  = new List<int>{ 4, 5, 7 };
        var result = NumberUtilities.GetDivisibleByThree(input);
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnEmptyString_WhenListIsEmpty()
    {
        var input  = new List<int>();
        var result = NumberUtilities.GetDivisibleByThree(input);
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnEmptyString_WhenListIsNull()
    {
        var result = NumberUtilities.GetDivisibleByThree(null);
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnSingleNumber_WhenOnlyOneDivisibleByThree()
    {
        var input  = new List<int>{ 3 };
        var expected = "3";
        var result = NumberUtilities.GetDivisibleByThree(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnOnlyNumbersDivisibleByThree_WhenListHasMixedValues()
    {
        var input  = new List<int>{ 3, 7, 9 };
        var expected = "3, 9";
        var result = NumberUtilities.GetDivisibleByThree(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetDivisibleByThree_ShouldHandleNegativeNumbersCorrectly()
    {
        var input  = new List<int>{ -3, 7, 9, -12 };
        var expected = "-3, 9, -12";
        var result = NumberUtilities.GetDivisibleByThree(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnUniqueNumbers_WhenListHasDuplicates()
    {
        var input  = new List<int>{ 3, 7, 9, 12, 3, 12 };
        var expected = "3, 9, 12";
        var result = NumberUtilities.GetDivisibleByThree(input);
        Assert.That(result, Is.EqualTo(expected));
    }

}
