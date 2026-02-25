using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverserTests
{
    [Test]
    public void Test_ReverseStrings_WithEmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        string[] inputArray = Array.Empty<string>();

        // Act
        string[] result = Reverser.ReverseStrings(inputArray);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_ReverseStrings_WithSingleString_ReturnsReversedString()
    {
        // Arrange
        var inputArray = new[] {"Hello"};
        
        // Act
        
        var result = Reverser.ReverseStrings(inputArray);
        
        // Assert
        Assert.That(result, Is.EqualTo(new[] { "olleH" }));
    }

    [Test]
    public void Test_ReverseStrings_WithMultipleStrings_ReturnsReversedStrings()
    {
        var inputArray = new[] {"Hello", "King"};
        
        var result = Reverser.ReverseStrings(inputArray);
        
        Assert.That(result, Is.EqualTo(new[] { "olleH", "gniK" }));
    }

    [Test]
    public void Test_ReverseStrings_WithSpecialCharacters_ReturnsReversedSpecialCharacters()
    {
        var inputArray = new[] {"Hello@#", "!$King"};
        
        var result = Reverser.ReverseStrings(inputArray);
        
        Assert.That(result, Is.EqualTo(new[] { "#@olleH", "gniK$!" }));
    }
}
