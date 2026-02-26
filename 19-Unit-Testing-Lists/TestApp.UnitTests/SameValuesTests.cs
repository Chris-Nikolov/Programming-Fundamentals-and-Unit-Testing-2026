using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SameValuesTests
{
    [Test]
    public void Test_FindSameValues_EmptyFirstList_ReturnsEmptyList()
    {
        var firstList = new List<int>();
        var secondList = new List<int> { 1, 2, 3 };
        
        var result = SameValues.FindSameValues(firstList, secondList);
        
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_EmptySecondList_ReturnsEmptyList()
    {
        var firstList = new List<int> { 1, 2, 3 };
        var secondList = new List<int>();
        
        var result = SameValues.FindSameValues(firstList, secondList);
        
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_NoSameValuesInBothLists_ReturnsEmptyList()
    {
        var firstList = new List<int> { 1, 2, 3 };
        var secondList = new List<int> { 80, 255, 99 };
        
        var result = SameValues.FindSameValues(firstList, secondList);
        
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_BothListWithSameValues_ReturnsListWithSameValues()
    {
        var firstList = new List<int> { 1, 2, 3 };
        var secondList = new List<int> { 1, 2, 3 };
        var expected = new List<int> { 1, 2, 3 };
        var result = SameValues.FindSameValues(firstList, secondList);
        
        Assert.That(result, Is.EqualTo(expected));
    }
}
