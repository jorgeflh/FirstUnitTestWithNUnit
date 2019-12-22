using NUnit.Framework;

namespace FirstUnitTestWithNUnit.Tests
{
    [TestFixture]
    public class CalculateTests
    {
        private Calculate calculate;

        [SetUp]
        public void Setup()
        {
            calculate = new Calculate();
        }

        [Test]
        public void Sum_WhenPassingTwoIntegers_ReturnsTheSum()
        {
            // Act
            var result = calculate.Sum(1, 1);

            // Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Subtract_WhenPassingTwoIntegers_ReturnsTheSubtraction()
        {
            // Act
            var result = calculate.Subtract(2,1);

            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Greater_WhenTheFirstArgumentIsGreater_ReturnsTheFirstArgument()
        {
            // Act
            var result = calculate.Greater(1, 0);

            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Greater_WhenTheSecondArgumentIsGreater_ReturnsTheSecondArgument()
        {
            // Act
            var result = calculate.Greater(0, 1);

            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Greater_WhenTheTwoArgumentsAreEquals_ReturnsTheFirstArgument()
        {
            // Act
            var result = calculate.Greater(0, 0);

            // Assert
            Assert.That(result, Is.EqualTo(0));
        }
    }
}