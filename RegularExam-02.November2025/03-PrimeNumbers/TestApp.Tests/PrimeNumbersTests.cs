using NUnit.Framework;

namespace TestApp.Tests
{
    public class PrimeNumbersTests
    {
        [Test]
        public void StartGreaterThanEnd_ShouldReturnErrorMessage()
        {
            // Arrange
            int startNumber = 5;
            int endNumber = 3;
            string expected = "Start number should be bigger than end number.";

            // Act
            string result = PrimeNumbers.GetPrimeNumbersInRange(startNumber, endNumber);

            // Assert
            Assert.That(result, Is.EqualTo(expected));

        }

        [Test]
        public void OneToOne_NoPrimes_ReturnsEmptyString()
        {
            // Arrange
            int startNumber = 1;
            int endNumber = 1;
            string expected = string.Empty;

            // Act
            string result = PrimeNumbers.GetPrimeNumbersInRange(startNumber, endNumber);

            // Assert
            Assert.That(result, Is.EqualTo(expected));

        }

        [Test]
        public void ZeroToOne_NoPrimes_ReturnsEmptyString()
        {
            // Arrange
            int startNumber = 0;
            int endNumber = 1;
            string expected = string.Empty;

            // Act
            string result = PrimeNumbers.GetPrimeNumbersInRange(startNumber, endNumber);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TwoToThree_ReturnsTwoThree()
        {
            // Arrange
            int startNumber = 2;
            int endNumber = 3;
            string expected = "2 3";

            // Act
            string result = PrimeNumbers.GetPrimeNumbersInRange(startNumber, endNumber);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void OneToFifty_ReturnsAllPrimesCorrectly()
        {
            // Arrange
            int startNumber = 1;
            int endNumber = 50;
            string expected = "2 3 5 7 11 13 17 19 23 29 31 37 41 43 47";

            // Act
            string result = PrimeNumbers.GetPrimeNumbersInRange(startNumber, endNumber);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
