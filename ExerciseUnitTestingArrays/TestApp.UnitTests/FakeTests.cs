using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        // Arrange
        char[] input = new char[] { '1','a', '4', 'k' };
        char[] expected = { 'a', 'k' };

        //Act
        char[] result = Fake.RemoveStringNumbers(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        // Arrange
        char[] input = { 'b', '@', 't', 'u' };
        char[] expected = { 'b', '@', 't', 'u' };

        //Act
        char[] result = Fake.RemoveStringNumbers(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        char[] input = Array.Empty<char>();

        //Act
        char[] result = Fake.RemoveStringNumbers(input);

        //Assert
        Assert.That(result, Is.Empty);

    }
}
