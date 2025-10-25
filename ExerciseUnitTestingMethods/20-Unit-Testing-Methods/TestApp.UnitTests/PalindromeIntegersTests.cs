using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class PalindromeIntegersTests
{
    [Test]
    public void Test_FindPalindromes_EmptyList_ReturnsEmptyList()
    {
        //Arrange
        List<int> emptyList = new List<int>();
       
        //Act
        //вдигаме инстанция на PalindromeIntegers, защото методът не е статичен;
        //един вид instance замества клас
        PalindromeIntegers instance = new PalindromeIntegers();
        List<int> result = instance.FindPalindromes(emptyList);

        //Assert
        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_FindPalindromes_NoPalindromes_ReturnsEmptyList()
    {
        //Arrange
        List<int> noPalindromes = new List<int>() { 34, 578, 45 };

        //Act
        PalindromeIntegers instance = new PalindromeIntegers();
        List<int> result = instance.FindPalindromes(noPalindromes);

        //Assert
        Assert.That(result, Is.Empty);


    }

    [Test]
    public void Test_FindPalindromes_OnlySingleDigitsElements_ReturnsSameIntegersList()
    {
        //Arrange
        List<int> singleDigits = new List<int>() { 2, 3, 4 };
        List<int> expected = new List<int> { 2, 3, 4 };

        //Act
        PalindromeIntegers instance = new PalindromeIntegers();
        List<int> result = instance.FindPalindromes(singleDigits);

        //Assert
        Assert.That(result, Is.EqualTo(expected));


    }

    [Test]
    public void Test_FindPalindromes_AllElementsArePalindromes_ReturnsSameIntegersList()
    {
        //Arrange
        List<int> allPalindromes = new List<int>() { 101, 22, 303 };
        List<int> expected = new List<int>() { 101, 22, 303 };

        //Act

        PalindromeIntegers instance = new PalindromeIntegers();
        List<int> result = instance.FindPalindromes(allPalindromes);

        //Assert
        Assert.That(result,Is.EqualTo(expected));


    }

    [Test]
    public void Test_FindPalindromes_PalimdromesAndNoPalindromesIntegers_ReturnsOnlyPalindromes()
    {
        //Arrange
        List<int> PalimdromesAndNoPalindromes = new List<int>() { 101, 45, 55, 707 };
        List<int> expected = new List<int>() { 101, 55, 707 };

        //Act
        PalindromeIntegers instance = new PalindromeIntegers();
        List<int> result = instance.FindPalindromes(PalimdromesAndNoPalindromes);

        //Assert
        Assert.AreEqual(expected, result);


    }
}
