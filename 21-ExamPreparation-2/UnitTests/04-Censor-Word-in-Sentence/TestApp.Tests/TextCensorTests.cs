using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.Tests;

public class TextCensorTests
{
    [Test]
    public void CensorWord_ShouldReturnError_WhenSentenceIsNull()
    {
        var forbiddenWord = "forbidden";
        var expected = "Sentence cannot be empty.";
        var result = TextCensor.CensorWord(null, forbiddenWord);
        Assert.That(result, Is.EqualTo(expected));
        
    }

    [Test]
    public void CensorWord_ShouldReturnError_WhenSentenceIsWhitespace()
    {
        var sentence = " ";
        var forbiddenWord = "forbidden";
        var expected = "Sentence cannot be empty.";
        var result = TextCensor.CensorWord(sentence, forbiddenWord);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void CensorWord_ShouldReturnError_WhenWordIsNull()
    {
        var sentence = "Everything is forbidden here.";
        var expected = "Word to censor cannot be empty.";
        var result = TextCensor.CensorWord(sentence, null);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void CensorWord_ShouldReturnError_WhenWordIsWhitespace()
    {
        var sentence = "Everything is forbidden here.";
        var forbiddenWord = " ";
        var expected = "Word to censor cannot be empty.";
        var result = TextCensor.CensorWord(sentence, forbiddenWord);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void CensorWord_ShouldReplaceSingleOccurrence()
    {
        var sentence = "Everything is forbidden here.";
        var forbiddenWord = "forbidden";
        var expected = "Everything is ********* here.";
        var result = TextCensor.CensorWord(sentence, forbiddenWord);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void CensorWord_ShouldReplaceMultipleOccurrences()
    {
        var sentence = "The forbidden knowledge is forbidden here.";
        var forbiddenWord = "forbidden";
        var expected = "The ********* knowledge is ********* here.";
        var result = TextCensor.CensorWord(sentence, forbiddenWord);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void CensorWord_ShouldReturnOriginal_WhenWordNotFound()
    {
        var sentence = "Everything is forbidden here.";
        var forbiddenWord = "allowed";
        var expected = "Everything is forbidden here.";
        var result = TextCensor.CensorWord(sentence, forbiddenWord);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void CensorWord_ShouldReplaceCaseInsensitive()
    {
        var sentence = "The forbidden knowledge is FORBIDDEN here.";
        var forbiddenWord = "forbidden";
        var expected = "The ********* knowledge is ********* here.";
        var result = TextCensor.CensorWord(sentence, forbiddenWord);
        Assert.That(result, Is.EqualTo(expected));
    }
}

