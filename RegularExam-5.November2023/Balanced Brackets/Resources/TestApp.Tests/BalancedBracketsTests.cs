using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class BalancedBracketsTests
{
    [Test]
    public void Test_IsBalanced_EmptyInput_ShouldReturnTrue()
    {
        // Arrange
        string[] input = Array.Empty<string>();
        bool expected = true;

        // Act
        bool result = BalancedBrackets.IsBalanced(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsBalanced_BalancedBrackets_ShouldReturnTrue()
    {
        // Arrange
        string[] input = new string[] { "(", ")", "(", ")" };
        bool expected = true;

        // Act
        bool result = BalancedBrackets.IsBalanced(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_IsBalanced_UnbalancedBrackets_ShouldReturnFalse()
    {
        // Arrange
        string[] input = new string[] { ")", "(", ")" };
        bool expected = false;

        // Act
        bool result = BalancedBrackets.IsBalanced(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_IsBalanced_MoreClosingBrackets_ShouldReturnFalse()
    {
        // Arrange
        string[] input = new string[] { "(", ")", "(", ")", ")" };
        bool expected = false;

        // Act
        bool result = BalancedBrackets.IsBalanced(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsBalanced_NoClosingBrackets_ShouldReturnFalse()
    {
        // Arrange
        string[] input = new string[] { "(", "(" };
        bool expected = false;

        // Act
        bool result = BalancedBrackets.IsBalanced(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
