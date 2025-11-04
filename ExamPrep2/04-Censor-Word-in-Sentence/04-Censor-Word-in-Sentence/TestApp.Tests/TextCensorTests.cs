using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.Tests;

public class TextCensorTests
{
    [Test]
    public void CensorWord_ShouldReturnError_WhenSentenceIsNull()
    {
        // Arrange
        string sentence = null;
        string wordToCensor = "bad";
        string expected = "Sentence cannot be empty.";

        // Act
        string result = TextCensor.CensorWord(sentence, wordToCensor);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void CensorWord_ShouldReturnError_WhenSentenceIsWhitespace()
    {
        // Arrange
        string sentence = " ";
        string wordToCensor = "bad";
        string expected = "Sentence cannot be empty.";

        // Act
        string result = TextCensor.CensorWord(sentence, wordToCensor);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void CensorWord_ShouldReturnError_WhenWordIsNull()
    {
        // Arrange
        string sentence = "This is good.";
        string wordToCensor = null;
        string expected = "Word to censor cannot be empty.";

        // Act
        string result = TextCensor.CensorWord(sentence, wordToCensor);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void CensorWord_ShouldReturnError_WhenWordIsWhitespace()
    {
        // Arrange
        string sentence = "This is good.";
        string wordToCensor = " ";
        string expected = "Word to censor cannot be empty.";

        // Act
        string result = TextCensor.CensorWord(sentence, wordToCensor);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void CensorWord_ShouldReplaceSingleOccurrence()
    {
        // Arrange
        string sentence = "This is bad";
        string wordToCensor = "bad";
        string expected = "This is ***";

        // Act
        string result = TextCensor.CensorWord(sentence, wordToCensor);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void CensorWord_ShouldReplaceMultipleOccurrences()
    {
        // Arrange
        string sentence = "You know I'm bad I'm bad You know it really really bad";
        string wordToCensor = "bad";
        string expected = "You know I'm *** I'm *** You know it really really ***";

        // Act
        string result = TextCensor.CensorWord(sentence, wordToCensor);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void CensorWord_ShouldReturnOriginal_WhenWordNotFound()
    {
        // Arrange
        string sentence = "I believe i can fly";
        string wordToCensor = "bad";
        string expected = "I believe i can fly";

        // Act
        string result = TextCensor.CensorWord(sentence, wordToCensor);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void CensorWord_ShouldReplaceCaseInsensitive()
    {
        // Arrange
        string sentence = "You know I'm Bad I'm bad You know it really really bad";
        string wordToCensor = "bad";
        string expected = "You know I'm *** I'm *** You know it really really ***";

        // Act
        string result = TextCensor.CensorWord(sentence, wordToCensor);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

