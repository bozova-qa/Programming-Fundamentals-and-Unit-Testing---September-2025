﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class RepeatingChecker_LastReapeatingElementTests
{
    [Test]
    public void Test_FindLastRepeatingElement_EmptyArray_ReturnsNegativeOne()
    {
        //Arrange
        int[] input = Array.Empty<int>();
        int expected = -1;

        //Act
        int result = RepeatingChecker.FindLastRepeatingElement(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithOneInteger_ReturnsNegativeOne()
    {
        //Arrange
        int[] input = new int[] { 2 };
        int expected = -1;

        //Act
        int result = RepeatingChecker.FindLastRepeatingElement(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithManyNonRepeatingValues_ReturnsNegativeOne()
    {
        //Arrange
        int[] input = new int[] { 3, 4, 2, 45, 56, 66 };
        int expected = -1;

        //Act
        int result = RepeatingChecker.FindLastRepeatingElement(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithTwoReapeatingNegativeOneValue_ReturnsNegativeOne()
    {
        //Arrange
        int[] input = new int[] { -1, -1 };
        int expected = -1;

        //Act
        int result = RepeatingChecker.FindLastRepeatingElement(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithManyIntegerWithSameValues_ReturnsTheIntegerValue()
    {
        //Arrange
        int[] input = new int[] { 5, 5, 5, 5, 5, 5, 5 };
        int expected = 5;

        //Act
        int result = RepeatingChecker.FindLastRepeatingElement(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithAtLeastTwoReaptingValues_ReturnsTheRepeatingValue()
    {
        //Arrange
        int[] input = new int[] { 3, 2, 34, 23, 34, 3 };
        int expected = 3;

        //Act
        int result = RepeatingChecker.FindLastRepeatingElement(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
