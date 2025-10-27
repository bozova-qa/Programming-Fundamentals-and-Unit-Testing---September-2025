using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class EvenLengthWordsFilterTests
{
    [Test]
    public void Test_GetEvenWords_InputArrayWithEmptyStrings_ShouldReturnEmptyString()
    {
        //Arrange
        string[] input = Array.Empty<string>();
        string expected = string.Empty;

        //Act
        string result = EvenLengthWordsFilter.GetEvenWords(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithOneOddLengthWord_ShouldReturnEmptyString()
    {
        //Arrange
        string[] oneOddWord = { "two" };
        string expected = string.Empty;

        //Act
        string result = EvenLengthWordsFilter.GetEvenWords(oneOddWord);


        //Assert
        Assert.AreEqual(expected, result);


    }

    [Test]
    public void Test_GetEvenWords_InputArrayOnlyWithOddLengthWords_ShouldReturnEmptyString()
    {
        //Arrange

        string[] input = { "one", "two", "three" };
        string expected = string.Empty;

        //Act
        string result = EvenLengthWordsFilter.GetEvenWords(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithOneEvenLengthWord_ShouldReturnSameWord()
    {
        //Arrange
        string[] input = { "zero" };
        string expected = "zero";

        //Act
        string result = EvenLengthWordsFilter.GetEvenWords(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithEvenAndOddLengthWords_ShouldReturnOnlyEvenLengthWords()
    {
        //Arrange
        string[] input = { "new", "same", "old", "case" };
        string expected = "same case";

        //Act
        string result = EvenLengthWordsFilter.GetEvenWords(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));


    }
}

