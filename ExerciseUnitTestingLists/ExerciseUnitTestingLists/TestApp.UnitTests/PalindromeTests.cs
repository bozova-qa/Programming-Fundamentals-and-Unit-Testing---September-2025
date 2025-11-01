using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> input = new() { "peep", "wow" };
        bool expected = true;

        // Act
        bool result = Palindrome.IsPalindrome(input);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> words = new();
        bool expected = true;

        // Act
        bool result = Palindrome.IsPalindrome(words);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        // Arrange
        List<string> words = new() { "peep" };
        bool expected = true;

        // Act
        bool result = Palindrome.IsPalindrome(words);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        // Arrange
        List<string> words = new() { "boom" };
        bool expected = false;

        // Act
        bool result = Palindrome.IsPalindrome(words);

        // Assert
        Assert.IsFalse(result);

    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> words = new() { "PeeP" };//"Level", "rADar", "CIVIC", "ReFer"
        bool expected = true;

        // Act
        bool result = Palindrome.IsPalindrome(words);

        // Assert
        Assert.IsTrue(result);

    }
}
