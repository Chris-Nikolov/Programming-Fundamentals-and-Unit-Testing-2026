using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListRemover_RemoveLessThanOrEqualToTests
{
    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_EmptyListParameter_ReturnsEmtyList()
    {
        var currList = new List<int>();
        var currLimit = 55;
        
        var result = ListRemover.RemoveElementsLessThanOrEqualTo(currList, currLimit);
        
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithLessThanOrEqualToThresholdElements_ReturnsEmtyList()
    {
        var currList = new List<int> { 10, 20, 33 };
        var currLimit = 80;
        
        var result = ListRemover.RemoveElementsLessThanOrEqualTo(currList, currLimit);
        
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithOnlyGreaterThanThresholdElements_ReturnsSameList()
    {
        var currList = new List<int> { 90, 81, 134};
        var currLimit = 80;
        
        var result = ListRemover.RemoveElementsLessThanOrEqualTo(currList, currLimit);
        
        Assert.That(result, Is.EqualTo(currList));
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyGreaterThanThreshold()
    {
        var currList = new List<int> { 70, 79, 34, 101, 112, 333, 80 };
        var currLimit = 80;
         var expected = new List<int> { 101, 112, 333 };
        var result = ListRemover.RemoveElementsLessThanOrEqualTo(currList, currLimit);
        
        Assert.That(result, Is.EqualTo(expected));
    }
}
