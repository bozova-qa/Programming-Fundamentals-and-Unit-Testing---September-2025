using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        

        //Arrange
        long number = 7;//number е просто
        long expected = 7;

        //Act

        long result = PrimeFactor.FindLargestPrimeFactor(number);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber() //взимаме по-голямо число
    {
        //Arrange
        long number = 145387;//смятаме пример с gpt
        long expected = 13217;

        //Act
        long result = PrimeFactor.FindLargestPrimeFactor(number);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]

    public void Test_FindLargestPrimeFactor_NonPrimeNumber()
    {
        //Arrange
        long number = 25; //търсим най-големия прост делител na 25
        long expected = 5; //най-големият просто делител на 25 е 5

        //Act

        long result = PrimeFactor.FindLargestPrimeFactor(number);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }
}
