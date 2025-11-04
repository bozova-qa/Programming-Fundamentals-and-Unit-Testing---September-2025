using NUnit.Framework;
using System;

using System.Collections.Generic;

namespace TestApp.Tests;

public class DrumSetTests
{
    [Test]
    public void Test_Drum_TerminateCommandNotGiven_ThrowsArgumentException()
    {
        // Arrange
        decimal moneyInput = 100;
        List<int> initialQualityInput = new List<int> { 10, 20, 30 };
        List<string> commandsInput = new List<string> { "5", "10" };

        // Act & Assert
        Assert.Throws<ArgumentException> (() => DrumSet.Drum(moneyInput, initialQualityInput, commandsInput));

    }

    [Test]
    public void Test_Drum_StringGivenAsCommand_ThrowsArgumentException()
    {
        // Arrange
        decimal moneyInput = 100;
        List<int> initialQualityInput = new List<int> { 10, 20, 30 };
        List<string> commandsInput = new List<string> { "Hit it three times" };

        // Act & Assert
        Assert.Throws<ArgumentException>(() => DrumSet.Drum(moneyInput, initialQualityInput, commandsInput));

    }

    [Test]
    public void Test_Drum_ReturnsCorrectQualityAndAmount()
    {
        // Arrange
        decimal moneyInput = 100;
        List<int> initialQualityInput = new List<int> { 10, 20, 30 , };
        List<string> commandsInput = new List<string> { "5", "10", "Hit it again, Gabsy!" };
        string expected = "10 5 15\nGabsy has 70.00lv.";

        // Act
        string result = DrumSet.Drum(moneyInput, initialQualityInput, commandsInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
        
    }

    [Test]
    public void Test_Drum_BalanceZero_WithOneDrumLeftOver_ReturnsCorrectQualityAndAmount()
    {
        // Arrange
        decimal moneyInput = 0;
        List<int> initialQualityInput = new List<int> { 10, 20, 30, };
        List<string> commandsInput = new List<string> { "5", "10", "Hit it again, Gabsy!" };
        string expected = "5 15\nGabsy has 0.00lv.";

        // Act
        string result = DrumSet.Drum(moneyInput, initialQualityInput, commandsInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_Drum_NotEnoughBalance_RemovesAllDrums_ReturnsCorrectQualityAndAmount()
    {
        // Arrange
        decimal moneyInput = 0;
        List<int> initialQualityInput = new List<int> { 10, 20, 30, };
        List<string> commandsInput = new List<string> { "5", "10", "Hit it again, Gabsy!" };
        string expected = "5 15\nGabsy has 0.00lv.";

        // Act
        string result = DrumSet.Drum(moneyInput, initialQualityInput, commandsInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
