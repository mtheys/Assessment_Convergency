using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MortgageCalculator.DTO
{
    public class MortgageDTO
    {
        public double InterestRate { get; set; }

        public double LoanInMonths { get; set; }

        public double PrincipalAmount { get; set; }

        public double AdditionalPayment { get; set; }
    }
}