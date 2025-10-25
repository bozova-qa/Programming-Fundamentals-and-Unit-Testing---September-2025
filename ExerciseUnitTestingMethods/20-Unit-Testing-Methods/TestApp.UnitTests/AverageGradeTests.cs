using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class AverageGradeTests
{
    [Test]
    public void Test_GetGradeDefinition_AverageGradeUnderTwo_ReturnsErrorMessage()
    {
        //Arrange
        List<double> grades = new List<double>() { 2.50, 1.20, 1.80 }; 
        string expected = "Incorrect grades";

        //Act
        string result = AverageGrade.GetGradeDefinition(grades);

        //Assert

        Assert.That(result, Is.EqualTo(expected));


    }

    [Test]
    public void Test_GetGradeDefinition_AverageGradeOverSix_ReturnsErrorMessage()
    {
        //Arrange
        List<double> grades = new List<double>() { 7.40, 7.00, 8.60 };
        string expected = "Incorrect grades";

        //Act
        string result = AverageGrade.GetGradeDefinition(grades);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetGradeDefinition_FailScoreAverageGrade_ReturnsFailDefinitionMessage()
    {
        //Arrange
        List<double> grades = new List<double>() { 2.20, 2.50, 2.75 };
        string expected = "Fail";

        //Act
        string result = AverageGrade.GetGradeDefinition(grades);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetGradeDefinition_PoorScoreAverageGrade_ReturnsPoorDefinitionMessage()
    {
        //Arrange
        List<double> grades = new List<double>() { 3.00, 3.20, 3.49 };
        string expected = "Poor";

        //Act
        string result = AverageGrade.GetGradeDefinition(grades);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_GoodScoreAverageGrade_ReturnsGoodDefinitionMessage()
    {
        //Arrange
        List<double> grades = new List<double>() { 3.50, 4.49, 4.00 };
        string expected = "Good";

        //Act
        string result = AverageGrade.GetGradeDefinition(grades);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetGradeDefinition_VeryGoodScoreAverageGrade_ReturnsVeryGoodDefinitionMessage()
    {
        //Arrange
        List<double> grades = new List<double>() { 4.50, 5.20, 5.49 };
        string expected = "Very good";

        //Act
        string result = AverageGrade.GetGradeDefinition(grades);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_ExcellentScoreAverageGrade_ReturnsExcellentDefinitionMessage()
    {
        //Arrange
        List<double> grades = new List<double>() { 5.50, 6.00, 5.70 };
        string expected = "Excellent";

        //Act
        string result = AverageGrade.GetGradeDefinition(grades);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }
}
