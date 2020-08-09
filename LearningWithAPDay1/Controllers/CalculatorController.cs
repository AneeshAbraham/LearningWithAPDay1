using Microsoft.AspNetCore.Mvc;
using SupportingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningWithAPDay1.Controllers
{
    [Route("api/")]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculator calculator;
        public CalculatorController(ICalculator calculator)
        {
            this.calculator = calculator;
        }

        [Route("add")]
        [HttpGet]
        public int Add()
        {
            return calculator.Add(1, 1);
        }

    }
}
