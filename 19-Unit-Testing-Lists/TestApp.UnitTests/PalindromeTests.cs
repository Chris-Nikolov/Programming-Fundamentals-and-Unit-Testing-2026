using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        var input = new List<string> { "lol", "wow", "pop" };
        // Act
        var result = Palindrome.IsPalindrome(input);
        // Assert
        Assert.IsTrue(result);
    }

    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> words = new();

        // Act
        var result = Palindrome.IsPalindrome(words);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        var input = new List<string> { "lol" };
        
        var result = Palindrome.IsPalindrome(input);
        
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        var input = new List<string> { "book", "spark", "game" };
        
        var result = Palindrome.IsPalindrome(input);
        
        Assert.IsFalse(result);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
       var input = new List<string> { "WoW", "lol", "Pop" };
       
       var result = Palindrome.IsPalindrome(input);
       
       Assert.IsTrue(result);
    }
}
