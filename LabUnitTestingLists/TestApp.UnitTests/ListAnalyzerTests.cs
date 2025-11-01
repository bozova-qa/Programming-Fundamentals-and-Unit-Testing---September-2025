using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListAnalyzerTests
{
    [Test]
    public void Test_Analyze_EmptyList_ShouldReturnNoElementsMsg()
    {
        //Arrange
        List<int> input = new();
        string expected = "No elements!";

        //Act
        string result = ListAnalyzer.Analyze(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_Analyze_OneElement_ShouldReturnSameValueForMinMaxAvg()
    {
        //Arrange
        List<int> input = new() { 5 };
        string expected = $"Element count: 1, Min value: 5, Max value: 5, Avg: {5:F2}.";

        //Act
        string result = ListAnalyzer.Analyze(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_Analyze_OnlySameValueElements_ShouldReturnSameValueForMinMaxAvg()
    {
        //Arrange
        List<int> input = new() { 3, 3, 3, 3 };
        string expected = $"Element count: 4, Min value: 3, Max value: 3, Avg: {3:F2}.";
        //Act
        string result = ListAnalyzer.Analyze(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));


    }

    [Test]
    public void Test_Analyze_DiffrentValues_ShouldReturnCorrectValues()
    {
        //Arrange
        List<int> input = new() { 3, 4, 6, 1 };
        string expected = $"Element count: 4, Min value: 1, Max value: 6, Avg: 3.50.";

        //Act
        string result = ListAnalyzer.Analyze(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }
}
