using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class NumberProcessorTests
{
    [Test]
    public void Test_ProcessNumbers_SquareEvenNumbers()
    {
        // Arrange
        List<int> input = new() { 2, 4, 6 };
        List<double> expected = new() { 4, 16, 36 };

        // Act
        List<double> actual = NumberProcessor.ProcessNumbers(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_ProcessNumbers_SquareRootOddNumbers()
    {
        // Arrange
        List<int> input = new() { 9, 49, 81 };
        List<double> expected = new() { 3, 7, 9 };

        // Act

        List<double> result = NumberProcessor.ProcessNumbers(input);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ProcessNumbers_HandleZero()
    {
        // Arrange
        List<int> input = new() { 0 };
        List<int> expected = new() { 0 };

        // Act
        List<double> result = NumberProcessor.ProcessNumbers(input);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ProcessNumbers_EmptyInput()
    {
        // Arrange
        List<int> input = new List<int>();
        List<int> expected = new List<int>();

        //Act
        List<double> result = NumberProcessor.ProcessNumbers(input);

        //Assert
        CollectionAssert.AreEqual(expected, result);

    }

    [Test]
    //Bonus test, not for judge

    public void Test_ProcessNumbers_SquareOddNumbers()
    {
        //Arrange
        List<int> input = new() { 7, 13 };//ако са нечетни и корените са дроби
        List<double> expected = new() { 2.64, 3.60 };

        //Act
        List<double> result = NumberProcessor.ProcessNumbers(input);

        //Assert
        Assert.That(Math.Round(result[0], 2), Is.EqualTo(expected[0]).Within(0.01));//заради многото числа след дес, запетая има разминаване
        

    }
}
