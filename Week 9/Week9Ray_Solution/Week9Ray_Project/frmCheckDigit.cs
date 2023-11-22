using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week9Ray_Project
{
    public partial class frmCheckDigit : Form
    {
        private const int ACCOUNT_NUMBER_LENGTH = 8;
        public frmCheckDigit()
        {
            InitializeComponent();
            lblOutput.Text = "";

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            AccountNumberBox.Text = "";
            ConfAccountNumberBox.Text = "";
            PaymentNumberBox.Text = "";
        }

        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            {
                

                // Get input values from text boxes
                string accountNumber = AccountNumberBox.Text;
                string confirmAccountNumber = ConfAccountNumberBox.Text;
                string paymentAmount = PaymentNumberBox.Text;

                // Validate inputs
                ValidateInputs(accountNumber, confirmAccountNumber, paymentAmount);
            }
        }

            // Method to validate input values
            private void ValidateInputs(string accountNumber, string confirmAccountNumber, string paymentAmount)
            {
                if (string.IsNullOrWhiteSpace(accountNumber) || string.IsNullOrWhiteSpace(confirmAccountNumber) || string.IsNullOrWhiteSpace(paymentAmount))
                {
                    lblOutput.Text = ("All fields must be filled.");
                    return;
                }

                if (accountNumber.Length < ACCOUNT_NUMBER_LENGTH || accountNumber != confirmAccountNumber)
                {
                    lblOutput.Text =    ("Account numbers should be at least 8 characters long and must match.");
                    return;
                }

                if (!IsNumeric(paymentAmount))
                {
                    lblOutput.Text = ("Payment amount must be numeric.");
                    return;
                }

                // Process valid inputs
                lblOutput.Text = (accountNumber);
            lblOutput.Text = ("A payment of " + FormatPaymentAmount(paymentAmount) + " was applied to account " + accountNumber + " on " );
            }

            // Method to check if a string is numeric
            private bool IsNumeric(string value)
            {
                return double.TryParse(value, out _);
            }

            // Method to validate account number using a check-digit algorithm
            private void ValidateAccountNumber(string accountNumber)
            {
                int sum = 0;
                for (int i = 0; i < ACCOUNT_NUMBER_LENGTH - 1; i++)
                {
                    if (!char.IsDigit(accountNumber[i]))
                    {
                        lblOutput.Text = ("Invalid account number.");
                        return;
                    }
                    sum += int.Parse(accountNumber[i].ToString());
                }

                int checkDigit = sum % 10;
                int lastDigit = int.Parse(accountNumber[ACCOUNT_NUMBER_LENGTH - 1].ToString());

                if (checkDigit != lastDigit)
                {
                    lblOutput.Text = ("Invalid account number.");
                }
            }

            // Method to format payment amount to a standard format
            private string FormatPaymentAmount(string amount)
            {
                if (double.TryParse(amount, out double value))
                {
                    return value.ToString("C"); // Convert to currency format
                }
                return amount;
            }
    }
}