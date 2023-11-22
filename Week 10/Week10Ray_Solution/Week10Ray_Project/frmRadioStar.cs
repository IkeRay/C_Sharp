using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week10Ray_Project
{
    public partial class frmRadioStar : Form
    {
        private const string VerboseModeOn = "Verbose On";
        private const string VerboseModeOff = "Verbose Off";

        public frmRadioStar()
        {
            InitializeComponent();
            Outputlbl.Text = "";
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Outputlbl.Text = "";
            LeftTxt.Text = "";
            RightTxt.Text = "";
            AdditionBtn.Checked = true;
            VerboseBtn.Checked = true;
        }

        private void Calculate()
        {
            Outputlbl.Text = "";

            if (!ValidateInputs())
                return;

            int leftOperand = ConvertToInt(LeftTxt.Text);
            int rightOperand = ConvertToInt(RightTxt.Text);

            if (!IsValidOperation(leftOperand, rightOperand))
                return;

            string operation = GetSelectedOperation();
            int result = PerformOperation(leftOperand, rightOperand, operation);

            DisplayResult(leftOperand, rightOperand, operation, result);
        }

        // Method to validate inputs
        private bool ValidateInputs()
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(LeftTxt.Text) && string.IsNullOrEmpty(RightTxt.Text))
            {
                DisplayErrorMessage("Both boxes are empty.");
                isValid = false;
            }
            // ... Perform other validation checks here as required ...
            return isValid;
        }

        // Helper method to convert input to integer
        private int ConvertToInt(string input)
        {
            if (!int.TryParse(input, out int result))
                DisplayErrorMessage("Invalid input format.");
            return result;
        }

        // Method to check for divide by zero or modulus on negative numbers
        private bool IsValidOperation(int leftOperand, int rightOperand)
        {
            if (rightOperand == 0)
            {
                DisplayErrorMessage("Cannot divide by zero.");
                return false;
            }
            if (GetSelectedOperation() == "Modulus" && leftOperand < 0)
            {
                DisplayErrorMessage("Cannot perform modulus on negative numbers.");
                return false;
            }
            return true;
        }

        // Method to get the selected operation
        private string GetSelectedOperation()
        {
            if (AdditionBtn.Checked)
                return "+";
            if (SubBtn.Checked)
                return "-";
            if (MultiplyBtn.Checked)
                return "*";
            if (DivBtn.Checked)
                return "/";
            if (ModulusBtn.Checked)
                return "%";
            return "";
        }

        // Method to perform the selected operation
        private int PerformOperation(int leftOperand, int rightOperand, string operation)
        {
            switch (operation)
            {
                case "+":
                    return leftOperand + rightOperand;
                case "-":
                    return leftOperand - rightOperand;
                case "*":
                    return leftOperand * rightOperand;
                case "/":
                    return leftOperand / rightOperand;
                case "%":
                    return leftOperand % rightOperand;
                default:
                    return 0;
            }
        }

        // Method to display the result based on Verbose mode
        private void DisplayResult(int leftOperand, int rightOperand, string operation, int result)
        {
            string equation = $"{leftOperand} {operation} {rightOperand} = {result}";

            if (VerboseBtn.Text == VerboseModeOn)
                Outputlbl.Text = equation;
            else
                Outputlbl.Text = $"The Answer is: {result}";
        }



        // Method to display error messages
        private void DisplayErrorMessage(string error)
        {
            Outputlbl.Text += $"Error: {error}\n";
        }

        // Event handler for Calculate button click
        private void CalculateBtn_Click_1(object sender, EventArgs e)
        {
            Calculate();
        }

        private void VerboseBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (VerboseBtn.Checked)
            {
                VerboseBtn.Text = VerboseModeOn;
            }
            else
            {
                VerboseBtn.Text = VerboseModeOff;
            }
        }
    }
}

