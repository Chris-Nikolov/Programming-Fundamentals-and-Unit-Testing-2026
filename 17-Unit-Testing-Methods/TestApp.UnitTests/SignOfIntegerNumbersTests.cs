using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SignOfIntegerNumbersTests
{
    [Test]
    public void Test_CheckSign_NotAnIntegerValue_ReturnErrorMessage()
    {
        var input = "test";
        var expected = "The input is not an integer!";
        
        var result = SignOfIntegerNumbers.CheckSign(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckSign_ZeroValueInput_ReturnMessageForZero()
    {
        var input = "0";
        var expected = "The number 0 is zero.";
        var result = SignOfIntegerNumbers.CheckSign(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckSign_NegativeValueInput_ReturnMessageForNegativeInteger()
    {
        var input = "-1";
        var expected = "The number -1 is negative.";
        var result = SignOfIntegerNumbers.CheckSign(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckSign_PositiveValueInput_ReturnMessageForPositiveInteger()
    {
        var input = "1";
        var expected = "The number 1 is positive.";
        var result = SignOfIntegerNumbers.CheckSign(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }
}
