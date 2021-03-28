using System;
using System.Collections.Generic;
using System.Text;

namespace SupportingLibrary
{
    public class ValidatorService : IValidatorService
    {
        public void Validate(int number1, int number2)
        {
            if (number1 == 0)
            {
                throw new ArgumentException($"Invalid input {number1}");
            }
            if (number2 == 0)
            {
                throw new ArgumentException($"Invalid input {number2}");
            }
        }
    }
}
