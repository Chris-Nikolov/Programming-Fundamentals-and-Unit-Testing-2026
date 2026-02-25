using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class TopIntegersTests
{
    [Test]
    public void Test_FindTopIntegers_EmptyArrayParameter_ReturnEmptyString()
    {
        var input = Array.Empty<int>();
        var topInt = new TopIntegers();
        var result = topInt.FindTopIntegers(input);
        Assert.That(result, Is.EqualTo(string.Empty));
        
    }

    [Test]
    public void Test_FindTopIntegers_AllElementsAreTopIntegers_ReturnStringWithAllElements()
    {
        var input = new[] { 5, 4, 3 };
        var topInt = new TopIntegers();
        var result = topInt.FindTopIntegers(input);
        Assert.That(result, Is.EqualTo("5 4 3"));
    }

    [Test]
    public void Test_FindTopIntegers_OnlyOneElementArray_ReturnStringWithOneInteger()
    {
        var input = new[] { 5 };
        var topInt = new TopIntegers();
        var result = topInt.FindTopIntegers(input);
        Assert.That(result, Is.EqualTo("5"));
    }

    [Test]
    public void Test_FindTopIntegers_OnlySomeElementsAreTopIntegers_ReturnStringWithOnlyTopIntegers()
    {
        var input = new[] { 5, 6, 3, 4, 2 };
        var topInt = new TopIntegers();
        var result = topInt.FindTopIntegers(input);
        Assert.That(result, Is.EqualTo("6 4 2"));
    }
}

