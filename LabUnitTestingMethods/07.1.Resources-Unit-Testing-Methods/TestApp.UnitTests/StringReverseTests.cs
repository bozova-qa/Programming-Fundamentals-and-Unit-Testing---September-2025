using NUnit.Framework;

namespace TestApp.UnitTests;
//class - наименуван блок от код, в който имаме методи;
public class StringReverseTests
{
    // TODO: finish test
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";
        string expected = "";
        // Act
        string result = StringReverse.Reverse(input);//от класа StringReverse избираме метода Reverse и 
        //го тестваме с променливата input;

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        // Arrange
        string input = "a";
        string expected = "a";


        //Act
        string result = StringReverse.Reverse(input);


        //Assert
        Assert.AreEqual(expected, result);

    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        // Arrange

        string input = "abc";
        string expected = "cba";


        //Act
        string result = StringReverse.Reverse(input);
        //Assert

        Assert.AreEqual(expected, result);
    }
}
