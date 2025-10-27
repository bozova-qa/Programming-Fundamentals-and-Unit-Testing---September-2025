using NUnit.Framework;

using System;

namespace TestApp.UnitTests;


//class ReverseTests - блок от код, в който имаме методи
public class ReverseTests
{
    [Test] // метод с анотация тест = метод ще тества друг метод и ще играе ролята на тест;
    public void Test_ReverseArray_InputIsEmpty_ShouldReturnEmptyString()
    {
        // Arrange - подогтвяме данните, с които ще работи
        int[] emptyArray = Array.Empty<int>();

        // Act - изпълняваме метода с данните горе
        string result = Reverse.ReverseArray(emptyArray);

        // Assert - проверяваме резултата от изпълнението
        //string.Empty == ""
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    // TODO: finish the test
    [Test]
    public void Test_ReverseArray_InputHasOneElement_ShouldReturnTheSameElement()
    {
        // Arrange
        int[] numbers = new int[] {23};
        string expected = "23";

        // Act
        string result = Reverse.ReverseArray(numbers); //"23"

        // Assert
        Assert.That(result, Is.EqualTo(expected));
       
    }

    [Test]
    public void Test_ReverseArray_InputHasMultipleElements_ShouldReturnReversedString()
    {
        // Arrange
        int[] numbers = new int[] { 23, 45, 56 };
        string expected = "56 45 23";

        //Assert
        string result = Reverse.ReverseArray(numbers);

        //Act
        Assert.That(result, Is.EqualTo(expected));
    }
}
