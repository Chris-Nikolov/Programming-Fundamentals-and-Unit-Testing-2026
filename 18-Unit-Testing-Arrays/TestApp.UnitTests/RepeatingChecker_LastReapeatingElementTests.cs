using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class RepeatingChecker_LastReapeatingElementTests
{
    [Test]
    public void Test_FindLastRepeatingElement_EmptyArray_ReturnsNegativeOne()
    {
        var input = Array.Empty<int>();
        var result = RepeatingChecker.FindLastRepeatingElement(input);
        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithOneInteger_ReturnsNegativeOne()
    {
        var input = new[] { 1 };
        var result = RepeatingChecker.FindLastRepeatingElement(input);
        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithManyNonRepeatingValues_ReturnsNegativeOne()
    {
        var input = new[] { 1, 2, 3, 4, 5 };
        var result = RepeatingChecker.FindLastRepeatingElement(input);
        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithTwoReapeatingNegativeOneValue_ReturnsNegativeOne()
    {
        var input = new[] { -1, 2, 3, 4, 5, -1 };
        var result = RepeatingChecker.FindLastRepeatingElement(input);
        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithManyIntegerWithSameValues_ReturnsTheIntegerValue()
    {
        var input = new[] { 3, 3, 3, 3 };
        var result = RepeatingChecker.FindLastRepeatingElement(input);
        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithAtLeastTwoReaptingValues_ReturnsTheRepeatingValue()
    {
        var input = new[] { 1, 2, 3, 4, 5, 1, 2, 3, 4 };
        var result = RepeatingChecker.FindLastRepeatingElement(input);
        Assert.That(result, Is.EqualTo(4));
    }
}
