using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class RepeatingChecker_FirstReapeatingElementTests
{
    [Test]
    public void Test_FindFirstRepeatingElement_EmptyArray_ReturnsNegativeOne()
    {
        //Arrange
        int[] inputArray = Array.Empty<int>();
        int expected = -1;

        //Act
        int result = RepeatingChecker.FindFirstRepeatingElement(inputArray);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithOneInteger_ReturnsNegativeOne()
    {
        //Arrange
        int[] input = new int[] { 2 };
        int expected = -1;

        //Act
        int result = RepeatingChecker.FindFirstRepeatingElement(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));


    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithManyNonRepeatingValues_ReturnsNegativeOne()
    {
        //Arrange
        int[] inputArray = new int[] { 3, 4, 12, 56, 77, 8 };
        int expected = -1;

        //Act
        int result = RepeatingChecker.FindFirstRepeatingElement(inputArray);

        //Assert
        Assert.That(result, Is.EqualTo(expected));


    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithTwoReapeatingNegativeOneValue_ReturnsNegativeOne()
    {
        //Arrange
        int[] inputArray = new int[] { -1, 4, 5, 3, -1 };
        int expected = -1;

        //Act
        int result = RepeatingChecker.FindFirstRepeatingElement(inputArray);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithManyIntegerWithSameValues_ReturnsTheIntegerValue()
    {
        //Arrange
        int[] input = new int[] { 5, 5, 5, 5, 5 };
        int expected = 5;

        //Act
        int result = RepeatingChecker.FindFirstRepeatingElement(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithAtLeastTwoReaptingValues_ReturnsTheRepeatingValue()
    {
        //Arrange
        int[] input = new int[] { 4, 5, 5, 6, 7, 12 };
        int expected = 5;

        //Act
        int result = RepeatingChecker.FindFirstRepeatingElement(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
