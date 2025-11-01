﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SameValuesTests
{
    [Test]
    public void Test_FindSameValues_EmptyFirstList_ReturnsEmptyList()
    {
        // Arrange
        List<int> firstList = new List<int>();
        List<int> secondList = new() { 2, 3, 4 };
       

        // Act
        List<int> result = SameValues.FindSameValues(firstList, secondList);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_EmptySecondList_ReturnsEmptyList()
    {
        // Arrange
        List<int> firstList = new() { 2, 3, 4 };
        List<int> secondList = new List<int>();

        // Act
        List<int> result = SameValues.FindSameValues(firstList, secondList);

        // Assert
        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_FindSameValues_NoSameValuesInBothLists_ReturnsEmptyList()
    {
        // Arrange
        List<int> firstList = new() { 6, 7, 8 };
        List<int> secondList = new() { 2, 3, 4 };

        // Act
        List<int> result = SameValues.FindSameValues(firstList, secondList);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_BothListWithSameValues_ReturnsListWithSameValues()
    {
        // Arrange
        List<int> firstList = new() { 6, 7, 8 };
        List<int> secondList = new() { 6, 7, 8 };
        List<int> expected = new() { 6, 7, 8 };

        // Act
        List<int> result = SameValues.FindSameValues(firstList, secondList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }
}
