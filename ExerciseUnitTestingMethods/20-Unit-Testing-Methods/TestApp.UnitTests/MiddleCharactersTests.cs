using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class MiddleCharactersTests
{
    [Test]
    public void Test_GetMiddleChars_EmptyString_ReturnsEmptyStringMessage()
    {
        //Arrange
        string text = "";//или string.Empty;
        string expected = "Empty string";

        //Act
        string result = MiddleCharacters.GetMiddleChars(text);

        //Assert
        Assert.AreEqual(expected, result);

    }

    [Test]
    public void Test_GetMiddleChars_WhiteSpaceString_ReturnsEmptyStringMessage()
    {
        //Arrange
        string text = " ";
        string expected = "Empty string";

        //Act
        string result = MiddleCharacters.GetMiddleChars(text);

        //Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetMiddleChars_SingleCharacterString_ReturnsTheCharacter()
    {
        //Arrange
        string text = "a";
        string expected = "a";

        //Act
        string result = MiddleCharacters.GetMiddleChars(text);

        //Assert
        Assert.AreEqual(expected, result);

    }

    [Test]
    public void Test_GetMiddleChars_EvenStringLength_ReturnsTwoCharactersString()
    {
        //Arrange
        string text = "abcdef";
        string expected = "cd";

        //Act
        string result = MiddleCharacters.GetMiddleChars(text);

        //Assert

        Assert.AreEqual(expected, result);


    }

    [Test]
    public void Test_GetMiddleChars_OddStringLength_ReturnsOneCharactersString()
    {
        //Arrange
        string text = "abcde";
        string expected = "c";

        //Act
        string result = MiddleCharacters.GetMiddleChars(text);

        //Assert
        Assert.AreEqual(expected, result);

    }
}
