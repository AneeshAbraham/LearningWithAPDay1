using Moq;
using System;
using Xunit;

namespace SupportingLibrary.Tests
{
    public class CalculatorTests
    {
        private readonly ICalculator calculator;
        private readonly Mock<IValidatorService> mockValidatorService;
        public CalculatorTests()
        {
            mockValidatorService = new Mock<IValidatorService>();
            calculator = new Calculator(mockValidatorService.Object);
        }

        [Fact]
        public void AddShouldReturnTheSumOfTheInputs()
        {
            var sum = calculator.Add(1, 2);
            Assert.Equal(3, sum);
            mockValidatorService.Verify(x => x.Validate(It.IsAny<int>(), It.IsAny<int>()), Times.Once);
        }

        [Fact]
        public void AddShouldReturnInvalidOperationExceptionWhenInvalidInputIsProvided()
        {
            mockValidatorService.Setup(x => x.Validate(It.IsAny<int>(), It.IsAny<int>())).Throws(new ArgumentException("Invalid input"));
            var exception = Assert.Throws<InvalidOperationException>(() => calculator.Add(2, 2));
            mockValidatorService.Verify(x => x.Validate(It.IsAny<int>(), It.IsAny<int>()), Times.Once);
        }
        // async => await

    }
}
