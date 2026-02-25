using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class MiddleCharactersTests
{
    [Test]
    public void Test_GetMiddleChars_EmptyString_ReturnsEmptyStringMessage()
    {
        var input = string.Empty;
        var expected = "Empty string";
        var result = MiddleCharacters.GetMiddleChars(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetMiddleChars_WhiteSpaceString_ReturnsEmptyStringMessage()
    {
        var input = " ";
        var expected = "Empty string";
        var result = MiddleCharacters.GetMiddleChars(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetMiddleChars_SingleCharacterString_ReturnsTheCharacter()
    {
        var input = "M";
        var expected = "M";
        var result = MiddleCharacters.GetMiddleChars(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetMiddleChars_EvenStringLength_ReturnsTwoCharactersString()
    {
        var input = "Kris";
        var expected = "ri";
        var result = MiddleCharacters.GetMiddleChars(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetMiddleChars_OddStringLength_ReturnsOneCharactersString()
    {
        var input = "David";
        var expected = "v";
        var result = MiddleCharacters.GetMiddleChars(input);
        Assert.That(result, Is.EqualTo(expected));
    }
}
