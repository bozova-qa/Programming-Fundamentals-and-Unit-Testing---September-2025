using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    // TODO: finish test
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string validEmail = "test@example.com";

        // Act
        bool result = Email.IsValidEmail(validEmail);//ако очакваме true или false, няма смисъл да слагаме
        //expected

        // Assert
        Assert.That(result, Is.True); //може и Is.False да се слага
    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        // Arrange
        string invalidEmail = "@abv.bg";

        // Act
        bool result = Email.IsValidEmail(invalidEmail);//резултат - грешен имейл

        // Assert
        Assert.IsFalse(result); //ако резултатът е грешен, тестът минава
    }
        
    [TestCase(" ")]
    [TestCase(null)]//null - неинициирана променлива
    public void Test_IsValidEmail_NullInput(string email)
    {
        // Arrange
        

        // Act
        bool result = Email.IsValidEmail(email);

        // Assert
        Assert.IsFalse(result);// or Assert.That(result, Is.False)

     }
    }

