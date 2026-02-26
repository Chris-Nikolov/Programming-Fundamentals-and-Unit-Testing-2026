using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListSplitterTests
{
    [Test]
    public void Test_SplitEvenAndOdd_EmptyListParameter_ReturnsEmptyEvenAndOddLists()
    {
        var list = new List<int>();
        
        var result = ListSplitter.SplitEvenAndOdd(list);
        
        Assert.That(result.evens, Is.Empty);
        Assert.That(result.odds, Is.Empty);
        
    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyEvenValues_ReturnsEmptyOddList()
    {
        var list = new List<int>{ 2, 4, 6, 8 };
        
        var result = ListSplitter.SplitEvenAndOdd(list);
        
        Assert.That(result.evens, Is.EqualTo(list));
        Assert.That(result.odds, Is.Empty);
    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyOddValues_ReturnsEmptyEvenList()
    {
        var list = new List<int>{ 3, 9, 13, 5 };
        
        var result = ListSplitter.SplitEvenAndOdd(list);
        
        Assert.That(result.evens, Is.Empty);
        Assert.That(result.odds, Is.EqualTo(list));
    }

    [Test]
    public void Test_SplitEvenAndOdd_EvenAndOddValues_ReturnsListWithCorrectValues()
    {
        var list = new List<int>{ 2, 4, 6, 8, 3, 7, 9, 11 };
        
        var evens = new List<int> { 2, 4, 6, 8 };
        var odds = new List<int> { 3, 7, 9, 11};
        
        var result = ListSplitter.SplitEvenAndOdd(list);
        
        Assert.That(result.evens, Is.EqualTo(evens));
        Assert.That(result.odds, Is.EqualTo(odds));
    }
}
