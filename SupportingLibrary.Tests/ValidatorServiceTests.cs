using System;
using Xunit;

namespace SupportingLibrary.Tests
{
    public class ValidatorServiceTests
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 0)]
        public void AddShouldThrowArgumentNullExceptionWhenInvaidInputIsProvided(int num1, int num2)
        {
            var validatorService = new ValidatorService();
            var argumentException = Assert.Throws<ArgumentException>(() => validatorService.Validate(num1, num2));
            var invalidNumber = num1 == 0 ? num1 : num2;
            Assert.Equal($"Invalid input {invalidNumber}", argumentException.Message);
        }
    }
}
