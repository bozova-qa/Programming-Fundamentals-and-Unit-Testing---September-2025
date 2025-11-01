using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class IgnoreTheCharsTests
{
    [Test]
    public void Test_IgnoreChars_EmptyStringSentence_ReturnsEmptyString()
    {
        //Arrange
        string sentence = string.Empty;
        List<char> symbols = new List<char> { 'a', 'e' };

        //Act
        string result = IgnoreTheChars.IgnoreChars(sentence, symbols);

        //Assert
        Assert.AreEqual(sentence, result);

    }

    [Test]
    public void Test_IgnoreChars_EmptyList_ReturnsSameSentence()
    {
        //Arrange
        string sentence = "You are doing fine.";
        List<char> symbols = new();

        //Act
        string result = IgnoreTheChars.IgnoreChars(sentence, symbols);

        //Assert
        Assert.AreEqual(sentence, result);

    }

    [Test]
    public void Test_IgnoreChars_OneCharSentenceAndSameCharsForIgnoring_ReturnsEmptyString()
    {
        //Arrange
        string sentence = "a";
        List<char> symbols = new() { 'a' };

        //Act
        string result = IgnoreTheChars.IgnoreChars(sentence, symbols);

        //Assert
        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_IgnoreChars_WholeSentenceAndFewCharsToIgnore_ReturnsCorrectString()
    {
        //Arrange
        string sentence = "You are doing fine.";
        List<char> symbols = new() { 'o', 'u', 'a' };
        string expected = "Y re ding fine.";
        //Act
        string result = IgnoreTheChars.IgnoreChars(sentence, symbols);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }
}
