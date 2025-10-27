using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();
        int expected = 0;
        // Act
        int result = EvenOddSubtraction.FindDifference(emptyArray);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] arrEven = new int[] { 2, 4, 6 };
        int expected = 12;
        // Act
        int result = EvenOddSubtraction.FindDifference(arrEven);

        // Assert
        Assert.That(result, Is.EqualTo(12));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
    {
        //Arrange
        int[] arrOdd = new int[] { 1, 3, 7 };
        int expected = -11;

        //Act
        int result = EvenOddSubtraction.FindDifference(arrOdd);

        //Assert

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        // Arrange
        int[] arrMixed = new int[] { 1, 7, 44, 67, 9 };

        //Act
        int result = EvenOddSubtraction.FindDifference(arrMixed);

        //Assert
        Assert.That(result, Is.EqualTo(-40));

    }
}
