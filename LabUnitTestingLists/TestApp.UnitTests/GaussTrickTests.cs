using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> input = new();

        // Act
        List<int> result = GaussTrick.SumPairs(input);

        // Assert
        CollectionAssert.AreEqual(input, result);
    }

    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> input = new List<int> { 1 };

        // Act
        List<int> result = GaussTrick.SumPairs(input);

        // Assert
        CollectionAssert.AreEqual(input, result);
    }

    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> input = new() { 1, 2, 3, 4 };
        List<int> expected = new() { 5, 5 };

        // Act
        List<int> result = GaussTrick.SumPairs(input);

        // Assert
        CollectionAssert.AreEqual(result, expected);
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        //Arrange
        List<int> input = new() { 1, 2, 3, 4, 5 };
        List<int> expected = new() { 6, 6, 3 };

        //Act
        List<int> result = GaussTrick.SumPairs(input);

        //Assert
        CollectionAssert.AreEqual(result, expected);

    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        //Arrange
        List<int> input = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> expected = new() { 11, 11, 11, 11, 11 };

        //Act
        List<int> result = GaussTrick.SumPairs(input);

        //Assert
        CollectionAssert.AreEqual(result, expected);

    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        //Arrange
        List<int> input = new() { 1, 2, 3, 4, 5, 6, 7 };
        List<int> expected = new() { 8, 8, 8, 4 };

        //Act
        List<int> result = GaussTrick.SumPairs(input);

        //Assert
        CollectionAssert.AreEqual(result, expected);
    }
}
