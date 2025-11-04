using System;
using System.Collections.Generic;
using System.Reflection;
using NUnit.Framework;

namespace TestApp.Tests;

public class NumberFinderTests
{
    [Test]
    public void Test_FindSmallestPositive_ShouldReturnError_WhenListIsNull()
    {
        // Arrange
        List<int> nullList = null; // липса на стойност
        string expected = "List cannot be empty.";

        // Act
        string result = NumberFinder.FindSmallestPositive(nullList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindSmallestPositive_ShouldReturnError_WhenListIsEmpty()
    {
        // Arrange
        List<int> input = new List<int>();
        string expected = "List cannot be empty.";

        // Act
        string result = NumberFinder.FindSmallestPositive(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindSmallestPositive_ShouldReturnSmallest_WhenListHasPositiveNumbers()
    {
        // Arrange
        List<int> input = new() { 2, 3, 4, 5, 6 };
        string expected = "Smallest positive number is: 2";

        // Act
        string result = NumberFinder.FindSmallestPositive(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_FindSmallestPositive_ShouldReturnSmallest_WhenListHasMixedNumbers()
    {
        // Arrange
        List<int> input = new() { 2, -3, 4, -5, 1 };
        string expected = "Smallest positive number is: 1";

        // Act
        string result = NumberFinder.FindSmallestPositive(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_FindSmallestPositive_ShouldReturnNotFoundMessage_WhenAllNumbersAreNegativeOrZero()
    {
        // Arrange
        List<int> input = new() { -2, 0, -5, -6 };
        string expected = "No positive numbers found.";

        // Act
        string result = NumberFinder.FindSmallestPositive(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_FindSmallestPositive_ShouldHandleDuplicates_Correctly()
    {
        // Arrange
        List<int> input = new() { 2, 3, 4, 2, 6 };
        string expected = "Smallest positive number is: 2";

        // Act
        string result = NumberFinder.FindSmallestPositive(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
