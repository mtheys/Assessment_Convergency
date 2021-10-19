using MortgageCalculator.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MortgageCalculator.Functions
{
    public class Calculation
    {
        public static double MonthlyPayment(MortgageDTO mortgageDTO)
        {
           
            double returnPayment = 0;
            double interestRate = mortgageDTO.InterestRate / 100;
            double loanAmount = mortgageDTO.PrincipalAmount; ;
            double downPayment = mortgageDTO.AdditionalPayment;
            double termOfLoan = mortgageDTO.LoanInMonths;

            try
            {
                if (loanAmount > 0 && mortgageDTO.InterestRate > 0)
                    returnPayment = (loanAmount - downPayment) * (Math.Pow((1 + interestRate / 12), termOfLoan) * interestRate) / (12 * (Math.Pow((1 + interestRate / 12), termOfLoan) - 1));
                else
                    returnPayment = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return returnPayment;
        }
    }
}