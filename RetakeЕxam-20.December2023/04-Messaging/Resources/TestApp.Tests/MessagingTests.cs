using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.Tests;

public class MessagingTests
{
    [Test]
    public void Test_GetMessage_WithValidInput_ReturnsExpectedMessage()
    {
        // Arrange
        List<int> input = new() { 1, 2, 3 };
        string text = "Hello";
        string expected = "elH";

        // Act
        string result = Messaging.GetMessage(input, text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetMessage_EmptyList_ReturnsEmptyString()
    {
        // Arrange
        List<int> input = new List<int>();
        string text = "Hello";

        // Act
        string result = Messaging.GetMessage(input, text);

        // Assert
        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_GetMessage_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        List<int> input = new() { 1, 2, 3 };
        string text = "";

        // Act
        string result = Messaging.GetMessage(input, text);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetMessage_NullList_ReturnsEmptyString()
    {
        // Arrange
        List<int> input = null;
        string text = "Hello";

        // Act
        string result = Messaging.GetMessage(input, text);

        // Assert
        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_GetMessage_NullString_ReturnsEmptyString()
    {
        // Arrange
        List<int> input = new() { 1, 2, 3 };
        string text = null;

        // Act
        string result = Messaging.GetMessage(input, text);

        // Assert
        Assert.That(result, Is.Empty);

    }
}
