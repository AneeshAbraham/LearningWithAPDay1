using System;
using System.Collections.Generic;
using System.Text;

namespace SupportingLibrary
{
    public class Calculator : ICalculator
    {
        public int Add(int number1, int number2)
        {
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
