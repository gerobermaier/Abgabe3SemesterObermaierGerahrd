using System;
using System.Collections.Generic;

namespace Abgabe3Semester
{ 
    
     class InputConverter
    {
        private double _convertedInput;
        private DoubleValidator doubleValidator;
        public bool isConverted = false;


        public InputConverter()
        {
            doubleValidator = new DoubleValidator();
        }

        public double ConvertInputToNumeric(string input)
        {
            _convertedInput = 0;


            if (doubleValidator.ValidateEntry(input))
            {
                _convertedInput = Convert.ToDouble(input);
                isConverted = true;
            }
            else
            {
                isConverted = false;
                _convertedInput = 0;
            }

            return _convertedInput;
        }

    }

}

