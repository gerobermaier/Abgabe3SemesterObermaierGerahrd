using System;
using System.Collections.Generic;

namespace Abgabe3Semester
{
    public class DoubleValidator : IValidator
    {
        public bool ValidateEntry(string input)
        {
            return double.TryParse(input, out var number);
        }
    }
}