using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class DuplicatesTests
{
    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();

        // Act
        var result = Duplicates.RemoveDuplicates(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(Array.Empty<int>()));
    }

    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        // Arrange
        int [] numbers = new[] { 1, 2, 3 };
        // Act
        var result = Duplicates.RemoveDuplicates(numbers);
        // Assert
        Assert.That(result, Is.EqualTo(numbers));
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        // Arrange
        int [] numbers = new[] { 1, 2, 3, 3 };
        int [] expected = new[] { 1, 2, 3 };
        // Act
        var result = Duplicates.RemoveDuplicates(numbers);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        // Arrange
        int [] numbers = new[] { 3, 3, 3, 3 };
        int [] expected = new[] { 3 };
        // Act
        var result = Duplicates.RemoveDuplicates(numbers);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
