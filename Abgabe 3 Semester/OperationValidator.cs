using System;
using System.Collections.Generic;

namespace Abgabe3Semester

{
    public class OperationValidator : IValidator
    {
        public bool ValidateEntry(string input)
        {
            if (!(string.IsNullOrWhiteSpace(input)) && (input.Length == 1) && (Operators.Operator.Contains(input[0])))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
