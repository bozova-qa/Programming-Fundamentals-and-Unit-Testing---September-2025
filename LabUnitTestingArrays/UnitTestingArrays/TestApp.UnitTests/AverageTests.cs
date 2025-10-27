using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class AverageTests
{
    // TODO: finish the test
    [Test]
    public void Test_CalculateAverage_InputHasOneElement_ShouldReturnSameElement()
    {
        // Arrange
        int[] array = { 42 };
        int expected = 42;
        // Act
        double result = Average.CalculateAverage(array);

        // Assert
       Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Test_CalculateAverage_InputHasPositiveIntegers_ShouldReturnCorrectAverage()
    {
        //Arrange
        int[] array = { 34, 4, 5, 7 };
        double expected = 12.50;
        //Act

        double result = Average.CalculateAverage(array);

        //Assert
        Assert.That(result, Is.EqualTo(expected));


    }

    [Test]
    public void Test_CalculateAverage_InputHasNegativeIntegers_ShouldReturnCorrectAverage()
    {
        //Arrange
        int[] array = { -1, -8, -3 };
        double expected = -4.00;
        //Act
        double result = Average.CalculateAverage(array);

        //Assert
        Assert.AreEqual(expected, result);

    }

    [Test]
    public void Test_CalculateAverage_InputHasMixedIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] array = { -1, 6, 5, 45, -76 };
        double expected = -4.20;

        //Act
        double result = Average.CalculateAverage(array);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }
}
