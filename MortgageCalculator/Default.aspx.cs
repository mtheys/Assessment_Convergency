using MortgageCalculator.DTO;
using MortgageCalculator.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MortgageCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            MortgageDTO mortgageDTO = new MortgageDTO();
            ResetBoxesAfterValidation();
            bool fail = false;
            mortgageDTO.AdditionalPayment = 0;

            if (Validation.ValidateDoubleInputs(txtPrincipalAmount.Text))
                mortgageDTO.PrincipalAmount = Double.Parse(txtPrincipalAmount.Text);
            else
            {
                txtPrincipalAmount.BackColor = System.Drawing.Color.Yellow;
                fail = true;
            }

            if (Validation.ValidateDoubleInputs(txtAdditionalAmount.Text))
                mortgageDTO.AdditionalPayment = Double.Parse(txtAdditionalAmount.Text);
            else
            {
                txtAdditionalAmount.BackColor = System.Drawing.Color.Yellow;
                fail = true;
            }

            if (Validation.ValidateIntegerInputs(txtInterestRate.Text))
                mortgageDTO.InterestRate = Double.Parse(txtInterestRate.Text);
            else
            {
                txtInterestRate.BackColor = System.Drawing.Color.Yellow;
                fail = true;
            }

            mortgageDTO.LoanInMonths = int.Parse(ddlLoanTerm.SelectedValue.ToString());

            if(!fail)
            {
                float value;
                value = (float)System.Math.Round(Calculation.MonthlyPayment(mortgageDTO), 2);
                txtResult.Text = value.ToString();
            }

        }

        protected void ResetBoxesAfterValidation()
        {
            txtPrincipalAmount.BackColor = System.Drawing.Color.Empty;
            txtInterestRate.BackColor = System.Drawing.Color.Empty;
           
        }

       
    }
}