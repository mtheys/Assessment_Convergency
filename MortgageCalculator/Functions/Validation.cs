using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MortgageCalculator.Functions
{
    public class Validation
    {
        public static bool ValidateDoubleInputs(string input)
        {
            bool isDouble = false;
            double price = 0;

            return isDouble = Double.TryParse(input, out price);
        }

        public static bool ValidateIntegerInputs(string input)
        {
            bool isInteger = false;
            int price = 0;

            return isInteger = int.TryParse(input,out price);
        }
    }
}