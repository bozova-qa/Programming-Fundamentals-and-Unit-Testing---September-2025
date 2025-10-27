using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeNumberFinderTests
{
    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithLessThanOrEqualToOneElementsOnly_ReturnsEmptyArray()
    {
        //Arrange
        int[] input = { -1, 0, 1 };
        

        //Act
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(input);


        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithOnlyOneNonPrimeNumber_ReturnsEmptyArray()
    {
        //Arrange
        int[] input = { 4 };
        int[] expected = Array.Empty<int>();

        //Act
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithNoPrimeNumbersOnly_ReturnsEmptyArray()
    {
        //Arrange
        int[] input = { 9, 12, 16 };
        int[] expected = Array.Empty<int>();

        //Act
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithOnlyOnePrimeNumber_ReturnsArrayWithTheSameNumber()
    {
        //Arrange
        int[] input = { 3, 4, 6, 8 };
        int[] expected = { 3 };

        //Act

        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithMixedNumbers_ReturnsArrayOnlyWithPrimeNumbers()
    {
        //Arrange
        int[] input = { 2, 3, 4, 5, 6, 7, 8 };
        int[] expected = { 2, 3, 5, 7 };

        //Act
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));


    }
}
