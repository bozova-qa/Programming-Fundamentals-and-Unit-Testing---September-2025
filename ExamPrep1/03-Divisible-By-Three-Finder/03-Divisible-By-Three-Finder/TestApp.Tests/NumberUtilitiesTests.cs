using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.Tests;

public class NumberUtilitiesTests
{
    [Test]
    public void GetDivisibleByThree_ShouldReturnEmptyString_WhenNoNumbersDivisibleByThree()
    {
        //Arrange
        List<int> input = new() { 4, 5, 7 };
        string expected = string.Empty;

        //Act
        string result = NumberUtilities.GetDivisibleByThree(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnEmptyString_WhenListIsEmpty()
    {
        //Arrange
        List<int> input = new List<int>();
        string expected = string.Empty;

        //Act
        string result = NumberUtilities.GetDivisibleByThree(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnEmptyString_WhenListIsNull()
    {
        //Arrange
        List<int> input = null;

        //Act
        string result = NumberUtilities.GetDivisibleByThree(input);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnSingleNumber_WhenOnlyOneDivisibleByThree()
    {
        //Arrange
        List<int> input = new() { 6, 4, 5, 7 };
        string expected = "6";

        //Act
        string result = NumberUtilities.GetDivisibleByThree(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnOnlyNumbersDivisibleByThree_WhenListHasMixedValues()
    {
        //Arrange
        List<int> input = new() { 2, 3, 4, 5, 6, 7, 8, 9 };
        string expected = "3, 6, 9";

        //Act
        string result = NumberUtilities.GetDivisibleByThree(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetDivisibleByThree_ShouldHandleNegativeNumbersCorrectly()
    {
        //Arrange
        List<int> input = new() { -3, 4, -6, -9 };
        string expected = "-3, -6, -9";

        //Act
        string result = NumberUtilities.GetDivisibleByThree(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnUniqueNumbers_WhenListHasDuplicates()
    {
        //Arrange
        List<int> input = new() { 3, 4, 3, 6, 7, 6, 5 };
        string expected = "3, 6";

        //Act
        string result = NumberUtilities.GetDivisibleByThree(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

}
