using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class RepeatingChecker_FirstReapeatingElementTests
{
    [Test]
    public void Test_FindFirstRepeatingElement_EmptyArray_ReturnsNegativeOne()
    {
        var input = Array.Empty<int>();
        var result = RepeatingChecker.FindFirstRepeatingElement(input);
        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithOneInteger_ReturnsNegativeOne()
    {
        var input = new[] { 1 };
        var result = RepeatingChecker.FindFirstRepeatingElement(input);
        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithManyNonRepeatingValues_ReturnsNegativeOne()
    {
        var input = new[] { 1, 2, 3, 4 };
        var result = RepeatingChecker.FindFirstRepeatingElement(input);
        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithTwoReapeatingNegativeOneValue_ReturnsNegativeOne()
    {
        var input = new[] { -1, 2, 3, 4, -1 };
        var result = RepeatingChecker.FindFirstRepeatingElement(input);
        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithManyIntegerWithSameValues_ReturnsTheIntegerValue()
    {
        var input = new[] { 1, 1, 1, 1, 1 };
        var result = RepeatingChecker.FindFirstRepeatingElement(input);
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithAtLeastTwoReaptingValues_ReturnsTheRepeatingValue()
    {
        var input = new[] { 1, 2, 3, 4, 4, 11, 13, 11 };
        var result = RepeatingChecker.FindFirstRepeatingElement(input);
        Assert.That(result, Is.EqualTo(4));
    }
}
