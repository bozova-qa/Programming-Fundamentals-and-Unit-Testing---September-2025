using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListRemover_RemoveGreaterThanTests
{
    [Test]
    public void Test_RemoveElementsGreaterThan_EmptyListParameter_ReturnsEmtyList()
    {
        // Arrange
        List<int> input = new List<int>();
        int threshold = 5;

        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(input, 5);

        //Assert
        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithGreaterThanThresholdElements_ReturnsEmtyList()
    {
        // Arrange
        List<int> input = new() { 6, 7, 8 };
        int threshold = 5;

        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(input, 5);

        //Assert
        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanOrEqualToThresholdElements_ReturnsSameList()
    {
        // Arrange
        List<int> input = new() { 1, 2, 3 };
        int threshold = 5;
        List<int> expected = new() { 1, 2, 3 };

        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(input, 5);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyLessThanOrEqualToThreshold()
    {
        // Arrange
        List<int> input = new() { 1, 2, 3, 5, 7, 8 };
        int threshold = 5;
        List<int> expected = new() { 1, 2, 3, 5 };

        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(input, 5);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
