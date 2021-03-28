using System;
using System.Collections.Generic;
using System.Text;

namespace SupportingLibrary
{
    public class Calculator : ICalculator
    {
        private readonly IValidatorService validatorService;

        public Calculator(IValidatorService validatorService)
        {
            this.validatorService = validatorService;
        }

        public int Add(int number1, int number2)
        {
            try
            {
                validatorService.Validate(number1, number2);
            }
            catch(ArgumentException argumentException)
            {
                throw new InvalidOperationException($"Invalid inputs provided: details: {argumentException.Message}");
            }
           
            return number1 + number2;
        }

        public int Sub(int number1, int number2)
        {
            throw new NotImplementedException();
        }
    }

    // Create 2 interfaces, 2 classes 
    // Add
    // Sub
}
