using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListRemover_RemoveGreaterThanTests
{
    [Test]
    public void Test_RemoveElementsGreaterThan_EmptyListParameter_ReturnsEmtyList()
    {
        var currList = new List<int>();
        var currLimit = 5;
        
        var result = ListRemover.RemoveElementsGreaterThan(currList, currLimit);
        
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithGreaterThanThresholdElements_ReturnsEmtyList()
    {
        var currList = new List<int>();
        var currLimit = 5;
        
        var result = ListRemover.RemoveElementsGreaterThan(currList, currLimit);
        
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanOrEqualToThresholdElements_ReturnsSameList()
    {
        var currList = new List<int> { 70, 80, 34};
        var currLimit = 80;
        
        var result = ListRemover.RemoveElementsGreaterThan(currList, currLimit);
        
        Assert.That(result, Is.EqualTo(currList));
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyLessThanOrEqualToThreshold()
    {
        var currList = new List<int> {60, 8, 33, 80, 94, 255};
        var currLimit = 70;
        
        var expected = new List<int> {60, 8, 33};
        
        var result = ListRemover.RemoveElementsGreaterThan(currList, currLimit);
        
        Assert.That(result, Is.EqualTo(expected));
    }
}
