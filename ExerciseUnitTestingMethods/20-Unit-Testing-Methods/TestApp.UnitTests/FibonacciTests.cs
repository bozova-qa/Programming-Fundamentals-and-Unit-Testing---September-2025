using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        //Arrange
        int inputNumber = 0;
        int expected = 0;

        //Act
        int result = Fibonacci.CalculateFibonacci(inputNumber);

        //Assert
        Assert.AreEqual(expected, result);


    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        // Arrange
        int inputNumber = 3;
        int expected = 2;

        //Act

        int result = Fibonacci.CalculateFibonacci(inputNumber);

        //Assert

        Assert.That(result,Is.EqualTo(expected));
    }
}