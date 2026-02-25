using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class PalindromeIntegersTests
{
    [Test]
    public void Test_FindPalindromes_EmptyList_ReturnsEmptyList()
    {
        var input = new List<int>();
        
        var palindromes = new PalindromeIntegers();
        
        var result = palindromes.FindPalindromes(input);
        
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindPalindromes_NoPalindromes_ReturnsEmptyList()
    {
        var input = new List<int>{255, 800, 700};
        
        var palindromes = new PalindromeIntegers();
        
        var result = palindromes.FindPalindromes(input);
        
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindPalindromes_OnlySingleDigitsElements_ReturnsSameIntegersList()
    {
        var input = new List<int>{3, 2};
        
        var palindromes = new PalindromeIntegers();
        
        var result = palindromes.FindPalindromes(input);
        
        Assert.That(input, Is.EqualTo(result));
    }

    [Test]
    public void Test_FindPalindromes_AllElementsArePalindromes_ReturnsSameIntegersList()
    {
        var input = new List<int>{313, 212};
        
        var palindromes = new PalindromeIntegers();
        
        var result = palindromes.FindPalindromes(input);
        
        Assert.That(input, Is.EqualTo(result));
    }

    [Test]
    public void Test_FindPalindromes_PalimdromesAndNoPalindromesIntegers_ReturnsOnlyPalindromes()
    {
        var input = new List<int>{313, 212, 101, 123, 345};
        
        var expected = new List<int>{313, 212, 101};
        
        var palindromes = new PalindromeIntegers();
        
        var result = palindromes.FindPalindromes(input);
        
        Assert.That(expected, Is.EqualTo(result));
    }
}
