using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.Tests;

public class EvenNumbersTests
{
    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsErrorMessage_WhenStartIsGreaterThanEnd()
    {
        // Arrange
        List<int> input = new() { 8, 6 };
        string expected = "Start number should be smaller than end number.";

        //Act
        string result = EvenNumbers.GetEvenNumbersInRange(8, 6);

        //Assert
        Assert.That(result, Is.EqualTo(expected));


    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsErrorMessage_WhenStartIsNegative()
    {
        // Arrange
        List<int> input = new() { -4, 1 };
        string expected = "Start number should be positive number.";

        //Act
        string result = EvenNumbers.GetEvenNumbersInRange(-4, 1);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsEmptyResult_WhenStartAndEndAreEqualOddNumbers()
    {
        // Arrange
        List<int> input = new() { 3, 3 };
        string expected = "Empty result";
        //Act
        string result = EvenNumbers.GetEvenNumbersInRange(3, 3);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsSingleEvenNumber_WhenStartAndEndAreEqualEvenNumbers()
    {
        // Arrange
        List<int> input = new() { 4, 4 };
        string expected = "4";

        //Act
        string result = EvenNumbers.GetEvenNumbersInRange(4, 4);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsEvenNumbers_WhenRangeHasEvens()
    {
        // Arrange
        List<int> input = new() { 2, 10 };
        string expected = "2, 4, 6, 8, 10";

        //Act
        string result = EvenNumbers.GetEvenNumbersInRange(2, 10);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsEvenNumbers_WhenStartAndEndAreEvenNumbers()
    {
        // Arrange
        List<int> input = new() { 2, 8 };
        string expected = "2, 4, 6, 8";

        //Act
        string result = EvenNumbers.GetEvenNumbersInRange(2, 8);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsEvenNumbers_WhenStartAndEndAreOddNumbers()
    {
        // Arrange
        List<int> input = new() { 1, 7 };
        string expected = "2, 4, 6";

        //Act
        string result = EvenNumbers.GetEvenNumbersInRange(1, 7);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
