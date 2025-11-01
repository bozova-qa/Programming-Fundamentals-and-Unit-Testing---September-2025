using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        // Arrange
        List<int> input = new List<int> { 5 };
        int expected = 5;

        // Act
        int result = MaxNumber.FindMax(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> input = new List<int>() { 2, 3, 4, 5, 7 };
        int expected = 7;

        // Act
        int result = MaxNumber.FindMax(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> input = new() { -1, -2, -3, -4 };
        int expected = -1;

        // Act
        int result = MaxNumber.FindMax(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> input = new() { -1, 3, -5, 4, 56, -7 };
        int expected = 56;

        // Act
        int result = MaxNumber.FindMax(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        // Arrange
        List<int> input = new() { 1, 2, 3, 5, 0, 5 };
        int expected = 5;

        // Act
        int result = MaxNumber.FindMax(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }
}
