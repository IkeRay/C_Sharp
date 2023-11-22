using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

/*

     * Name : Isom Ray
     * Class : ITD 2343
     * Due Date : 10/3/2023

 */

namespace Module4Project
{
    public partial class frmOfDataTypes : Form
    {
        public frmOfDataTypes()
        {
            InitializeComponent();
            //makes label empty
            lblOutput.Text = "";

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            //closes application
            this.Close();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            //clears label
            lblOutput.Text = "";
        }

        private void frmOfDataTypes_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Asigns ESC as hotkey to close
            if (e.KeyChar == (char)27)
                Close();
        }

        private void Bytebtn_Click(object sender, EventArgs e)
        { 
            //Byte
            int num1 = 10;
            int num2 = 5;

            
            lblOutput.Text = $"{num1} + {num2} = {num1 + num2}";
        }

        private void Shortbtn_Click(object sender, EventArgs e)
        {
            // Short
            int num1 = 30;
            int num2 = 17;

            lblOutput.Text = $"{num1} - {num2} = {num1 - num2}";
        }

        private void Intbtn_Click(object sender, EventArgs e)
        {
            // Int
            int num1 = 52;
            int num2 = 7;

            
            lblOutput.Text = $"{num1} / {num2} = {num1 / num2}";
        }

        private void Longbtn_Click(object sender, EventArgs e)
        {
            // Long
            int num1 = 745;
            int num2 = 123;

           
            lblOutput.Text = $"{num1} % {num2} = {num1 % num2}";
        }

        private void Floatbtn_Click(object sender, EventArgs e)
        {
            // Float
            int num1 = 7940;
            int num2 = 345;

            lblOutput.Text = $"{num1:F2} % {num2:F2} = {(num1 % num2):F2}";
        }

        private void Doublebtn_Click(object sender, EventArgs e)
        {
            {
                // Doube 
                decimal num1 = 10.5M;
                decimal num2 = 34.4M;

                lblOutput.Text = $"{num1:F2} % {num2:F2} = {(num1 % num2):F2}";
            }
        }

        private void Decimalbtn_Click(object sender, EventArgs e)
        {
            // Decimal
            decimal num1 = 7.5M;
            decimal num2 = 238.1M;

            lblOutput.Text = $"{num1:F2} * {num2:F2} = {(num1 * num2):F2}";
        }

        private void Powbtn_Click(object sender, EventArgs e)
        {
            // Pow
            double baseValue = 12; 
            double exponent = 2; 

            double result = Math.Pow(baseValue, exponent);

            lblOutput.Text = $" The Pow of {baseValue} & {exponent} is {result}";
        }

        private void Roundbtn_Click(object sender, EventArgs e)
        {
            // Round
            double baseValue = 2.12345123;
            int exponent = 4;

            double result = Math.Round(baseValue, exponent);

            lblOutput.Text = $"{baseValue} rounded by {exponent} places is {result}";
        }

        private void Sqrtbtn_Click(object sender, EventArgs e)
        {
            // Root
            double SquareRoot = 24;

            double result = Math.Sqrt(SquareRoot);

            lblOutput.Text = $"The Squeare root of {SquareRoot} is {result}";

        }
    }
}
