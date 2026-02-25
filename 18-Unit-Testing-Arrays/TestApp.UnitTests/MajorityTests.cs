using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class MajorityTests
{
    [Test]
    public void Test_IsEvenOrOddMajority_EmpryArray_ReturnsZero()
    {
        var input = Array.Empty<int>();
        var result = Majority.IsEvenOrOddMajority(input);
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_ArrayOnlyWithZeros_ReturnsZero()
    {
        var input = new[] { 0, 0, 0 };
        var result = Majority.IsEvenOrOddMajority(input);
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_EqualOddAndEvenNumbers_ReturnsZero()
    {
        var input = new[] {  1, 2 };
        var result = Majority.IsEvenOrOddMajority(input);
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_EvenMajority_ReturnsPositiveNumber()
    {
        var input = new[] {  1, 2, 4 };
        var result = Majority.IsEvenOrOddMajority(input);
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_OddMajority_ReturnsNegativeNumber()
    {
        var input = new[] {  1, 2, 3 };
        var result = Majority.IsEvenOrOddMajority(input);
        Assert.That(result, Is.EqualTo(-1));
    }
}