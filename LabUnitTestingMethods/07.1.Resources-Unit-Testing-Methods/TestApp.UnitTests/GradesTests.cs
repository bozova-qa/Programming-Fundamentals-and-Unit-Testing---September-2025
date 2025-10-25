using NUnit.Framework;

namespace TestApp.UnitTests;

public class GradesTests
{
    [Test]
    public void Test_GradeAsWords_ValidGrade_ReturnsCorrectString()
    {
        // Arrange
        double grade = 4.50;
        string expected = "Very Good";

        // Act
        string result = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GradeAsWords_InvalidGrade_ReturnsCorrectString()
    {
        // Arrange
        double grade = 8;
        string expected = "Invalid!";

        // Act
        string result = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
