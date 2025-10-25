using NUnit.Framework;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void Test_CalculateFactorial_InputZero_ReturnsOne()
    {
        // Arrange -> подготвяме данните, с които ще работим;
        int number = 0;
        int expected = 1;

        //Act -> изпълняваме метода с подготвените данни;
        int result = Factorial.CalculateFactorial(number);

        //щом напишем Class.(Factorial.) получаваме достъп до всички статични методи в този клас


        //Assert -> правим проверка дали методът работи правилно; дали очакваният и полученият резултат съвпадат
        Assert.AreEqual(expected, result);

    }

    [Test]
    public void Test_CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        //Arrange
        int number = 5;
        int expected = 120;

        //Act
        int result = Factorial.CalculateFactorial(number);

        //Assert
        Assert.AreEqual(expected, result);

        //имаме два сценария да тестват един метод
    }
}
