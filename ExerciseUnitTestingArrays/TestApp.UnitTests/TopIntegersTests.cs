using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class TopIntegersTests
{

    private TopIntegers instance;// декларираме променливата instance

    [SetUp]
    public void SetUp() // стартира се всеки път, когато извършваме тест
    {
        instance = new TopIntegers();
    }



    [Test]
    public void Test_FindTopIntegers_EmptyArrayParameter_ReturnEmptyString()
    {
        //Arrange
        int[] input = Array.Empty<int>();

        //Act
        //TopIntegers instance = new TopIntegers(); -> подготвяме инстанция в SetUp метода;
        string result = instance.FindTopIntegers(input);

        //Assert
        Assert.That(result, Is.Empty);


    }

    [Test]
    public void Test_FindTopIntegers_AllElementsAreTopIntegers_ReturnStringWithAllElements()
    {
        //Arrange
        int[] input = new int[] { 4, 3, 2 };
        string expected = "4 3 2";

        //Act
        //TopIntegers instance = new TopIntegers();
        string result = instance.FindTopIntegers(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_FindTopIntegers_OnlyOneElementArray_ReturnStringWithOneInteger()
    {
        //Arrange
        int[] input = new int[] { 5 };
        string expected = "5";

        //Act
        //TopIntegers instance = new TopIntegers();
        string result = instance.FindTopIntegers(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_FindTopIntegers_OnlySomeElementsAreTopIntegers_ReturnStringWithOnlyTopIntegers()
    {
        //Arrange
        int[] input = new int[] { 14, 24, 3, 19, 15, 17 };
        string expected = "24 19 17";

        //Act
        //TopIntegers instance = new TopIntegers();//когато имаме 20-30 теста, 20-30 пъти трябва да пишем това
        // можем да направим SET UP в началото;
        string result = instance.FindTopIntegers(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }
}

