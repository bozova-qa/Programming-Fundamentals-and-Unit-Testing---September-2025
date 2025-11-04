using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.Tests;
public class PalindromeFinderTests
{
    [Test]
    public void Test_GetPalindromes_NullWordsList_ReturnsEmptyString()
    {
        // Arrange
        List<string> input = null;

        // Act
        string result = PalindromeFinder.GetPalindromes(input);

        // Assert
        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_GetPalindromes_EmptyWordsList_ReturnsEmptyString()
    {
        // Arrange
        List<string> input = new List<string>();

        // Act
        string result = PalindromeFinder.GetPalindromes(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetPalindromes_ListWithWords_ReturnsOnlyPalidromeWords()
    {
        // Arrange
        List<string> input = new() { "words", "wow", "exam", "peep", "noon" };
        string expected = "wow peep noon";

        // Act
        string result = PalindromeFinder.GetPalindromes(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetPalindromes_ListWithoutPalindromeWords_ReturnsEmptyString()
    {
        // Arrange
        List<string> input = new() { "words", "table", "coffee" };
        string expected = string.Empty;

        // Act
        string result = PalindromeFinder.GetPalindromes(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetPalindromes_ListOnlyWithPalidromeWords_ReturnsStringWithAllWords()
    {
        // Arrange
        List<string> input = new() { "wow", "peep", "kayak" };
        string expected = "wow peep kayak";

        // Act
        string result = PalindromeFinder.GetPalindromes(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

