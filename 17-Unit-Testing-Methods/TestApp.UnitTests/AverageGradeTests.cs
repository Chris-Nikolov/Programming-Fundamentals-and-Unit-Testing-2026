using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class AverageGradeTests
{
    [Test]
    public void Test_GetGradeDefinition_AverageGradeUnderTwo_ReturnsErrorMessage()
    {
        var input = new List<double>{1.0, 1.2};
        var expected = "Incorrect grades";
        var result = AverageGrade.GetGradeDefinition(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_AverageGradeOverSix_ReturnsErrorMessage()
    {
        var input = new List<double>{7.0, 8.0};
        var expected = "Incorrect grades";
        var result = AverageGrade.GetGradeDefinition(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_FailScoreAverageGrade_ReturnsFailDefinitionMessage()
    {
        var input = new List<double>{2.0, 3.0, 2.0};
        var expected = "Fail";
        var result = AverageGrade.GetGradeDefinition(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_PoorScoreAverageGrade_ReturnsPoorDefinitionMessage()
    {
        var input = new List<double>{2.0, 4.0, 2.0, 4.0};
        var expected = "Poor";
        var result = AverageGrade.GetGradeDefinition(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_GoodScoreAverageGrade_ReturnsGoodDefinitionMessage()
    {
        var input = new List<double>{6.0, 2.0};
        var expected = "Good";
        var result = AverageGrade.GetGradeDefinition(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_VeryGoodScoreAverageGrade_ReturnsVeryGoodDefinitionMessage()
    {
        var input = new List<double>{6.0, 4.0};
        var expected = "Very good";
        var result = AverageGrade.GetGradeDefinition(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_ExcellentScoreAverageGrade_ReturnsExcellentDefinitionMessage()
    {
        var input = new List<double>{6.0, 5.0, 6.0, 6.0};
        var expected = "Excellent";
        var result = AverageGrade.GetGradeDefinition(input);
        Assert.That(result, Is.EqualTo(expected));
    }
}
