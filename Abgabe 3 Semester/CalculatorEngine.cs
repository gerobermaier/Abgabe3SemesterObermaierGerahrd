using System;
using System.Collections.Generic;

namespace Abgabe3Semester
{


    class CalculatorEngine
    {
        private OperationValidator _operationValidator;
        public CalculatorEngine()
        {
            _operationValidator = new OperationValidator();
        }

        public double Calculate(string operation, double first, double second)
        {
            if (_operationValidator.ValidateEntry(operation))
            {
                switch (operation)
                {
                    case "+":
                        return first + second;
                    case "-":
                        return first - second;
                    case "*":
                        return first * second;
                    case "/":
                        return first / second;
                }
                return 0;
            }
            else { return 0; }
        }
    }

}
