using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListManipulationTests
{
    [Test]
    public void Test_RemoveNegativesAndReverse_EmptyListInput_ReturnEmptyList()
    {
        //Arrange
        List<int> input = new List<int>();

        //Act
        List<int> result = ListManipulation.RemoveNegativesAndReverse(input);

        //Assert
        Assert.That(result, Is.Empty);
        //или CollectionAssert.IsEmpty(result);

    }

    [Test]
    public void Test_RemoveNegativesAndReverse_OnlyNegativeNumbers_ReturnEmptyList()
    {
        //Arrange
        List<int> input = new() { -1, -2, -3 };

        //Act
        List<int> result = ListManipulation.RemoveNegativesAndReverse(input);

        //Assert
        Assert.That(result, Is.Empty);


    }

    [Test]
    public void Test_RemoveNegativesAndReverse_OnlyOnePositiveNumber_ReturnSameCollection()
    {
        //Arrange
        List<int> input = new() { 5 };
        List<int> expected = new List<int>() {5};

        //Act
        List<int> result = ListManipulation.RemoveNegativesAndReverse(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
        //CollectionAssert.AreEqual(expected, result);

    }

    [Test]
    public void Test_RemoveNegativesAndReverse_OnlyPositiveNumbers_ReturnRevursedList()
    {
        //Arrange
        List<int> input = new() { 2, 3, 4, 5 };
        List<int> expected = new() { 5, 4, 3, 2 };

        //Act
        List<int> result = ListManipulation.RemoveNegativesAndReverse(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));


    }

    [Test]
    public void Test_RemoveNegativesAndReverse_PostiveAndNegativeElements_ReturnPositiveNumbersInReversedOrder()
    {
        //Arrange
        List<int> input = new() { 1, -2, 3, -4, 5 };
        List<int> expected = new() { 5, 3, 1 };

        //Act
        List<int> result = ListManipulation.RemoveNegativesAndReverse(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));


    }
}
