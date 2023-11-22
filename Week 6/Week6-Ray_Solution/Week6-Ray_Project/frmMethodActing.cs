using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Week6_Ray_Project
{
    public partial class frmMethodActing : Form
    {
        public frmMethodActing()
        {
            InitializeComponent();
            //Prints nothing in label
            lblOutput.Text = "";
        }
        
        const string Addition = "add";
        const string Subtraction = "subtract";
        const string Multiplication = "multiply";
        const string Division = "divide";
        const string Modulus = "modulus";

        private double PerformOperation(double operand1, double operand2, string operation)
        {
           
            double result = 0.0;
            switch (operation)
            {
                case Addition:
                    result = operand1 + operand2;
                    break;
                case Subtraction:
                    result = operand1 - operand2;
                    break;
                case Multiplication:
                    result = operand1 * operand2;
                    break;
                case Division:
                    if (operand2 != 0)
                    {
                        result = operand1 / operand2;
                    }
                    else
                    {
                        // Handle division by zero error
                        result = double.NaN;
                    }
                    break;
                case Modulus:
                    if (operand2 != 0)
                    {
                        result = operand1 % operand2;
                    }
                    else
                    {
                        // Handle modulus by zero error
                        result = double.NaN;
                    }
                    break;
            }

            return result;
        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            // Closes Application
            this.Close();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            // Clears lbl and text boxes
            lblOutput.Text = "";
            RightTxtBox.Text = "";
            LeftTxtBox.Text = "";
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            double operand1 = Convert.ToDouble(LeftTxtBox.Text);
            double operand2 = Convert.ToDouble(RightTxtBox.Text);
            string operation = Addition;

            double result = PerformOperation(operand1, operand2, operation);

            lblOutput.Text = LeftTxtBox.Text + " + " + RightTxtBox.Text
                + " = " + result.ToString();
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            double operand1 = Convert.ToDouble(LeftTxtBox.Text);
            double operand2 = Convert.ToDouble(RightTxtBox.Text);
            string operation = Subtraction;

            double result = PerformOperation(operand1, operand2, operation);

            lblOutput.Text = LeftTxtBox.Text + " - " + RightTxtBox.Text
                + " = " + result.ToString();
        }

        private void MulBtn_Click(object sender, EventArgs e)
        {
            double operand1 = Convert.ToDouble(LeftTxtBox.Text);
            double operand2 = Convert.ToDouble(RightTxtBox.Text);
            string operation = Multiplication;

            double result = PerformOperation(operand1, operand2, operation);

            lblOutput.Text = LeftTxtBox.Text + " * " + RightTxtBox.Text
                + " = " + result.ToString();
        }

        private void DivBtn_Click(object sender, EventArgs e)
        {
            double operand1 = Convert.ToDouble(LeftTxtBox.Text);
            double operand2 = Convert.ToDouble(RightTxtBox.Text);
            string operation = Division;

            double result = PerformOperation(operand1, operand2, operation);

            lblOutput.Text = LeftTxtBox.Text + " / " + RightTxtBox.Text
                + " = " + result.ToString();
        }

        private void PercBtn_Click(object sender, EventArgs e)
        {
            double operand1 = Convert.ToDouble(LeftTxtBox.Text);
            double operand2 = Convert.ToDouble(RightTxtBox.Text);
            string operation = Modulus;

            double result = PerformOperation(operand1, operand2, operation);

            lblOutput.Text = LeftTxtBox.Text + " % " + RightTxtBox.Text
                + " = " + result.ToString();
        }
    }
}
