using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class DuplicatesTests
{

    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] input = Array.Empty<int>();

        // Act
        int[] result = Duplicates.RemoveDuplicates(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    
    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        // Arrange
        int[] input = new int[] { 1, 2, 3 };
        int[] expected = { 1, 2, 3 };

        // Act
        int[] result = Duplicates.RemoveDuplicates(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
        
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        // Arrange
        int[] input = new int[] { 1, 3, 6, 3, 7, 7 };
        int[] expected = { 1, 3, 6, 7 };

        //Act
        int[] result = Duplicates.RemoveDuplicates(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        // Arrange
        int[] input = new int[] { 5, 5, 5, 5, 5, 5, 5 };
        int[] expected = { 5 };

        //Act
        int[] result = Duplicates.RemoveDuplicates(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }
}
