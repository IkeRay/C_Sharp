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
 * Semester : Fall
 * Class : ITD 2343
 * Due Date : 10/10/2023
 */
namespace Project5Ray
{
    public partial class FrmChoices : Form
    {
        public FrmChoices()
        {
            InitializeComponent();
            lblOutput.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            // Close
            this.Close();
        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            // Clear Button
            UpperRangeTxt.Text = ""; 
            LowerRangeTxt.Text = "";
            lblOutput.Text = "";
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            // Check if the number is greater then, equal to, or lower then
            int checkNumber, lowerRange, upperRange;
            if (!int.TryParse(CheckNumberTxt.Text, out checkNumber) ||
                !int.TryParse(LowerRangeTxt.Text, out lowerRange) ||
                !int.TryParse(UpperRangeTxt.Text, out upperRange))
            {
                lblOutput.Text = "Please enter valid numbers in all fields.";
                return;
            }

            if (checkNumber == lowerRange)
            {
                lblOutput.Text = "The check number is equal to the Lower End of the Range.";
            }
            else if (checkNumber == upperRange)
            {
                lblOutput.Text = "The check number is equal to the Upper End of the Range.";
            }
            else if (checkNumber < lowerRange)
            {
                lblOutput.Text = "The number is lower than the low end of the range.";
            }
            else if (checkNumber > upperRange)
            {
                lblOutput.Text = "The number is bigger than the high end of the range.";
            }
            else
            {
                lblOutput.Text = $"The number is in the range of {lowerRange} and {upperRange}.";
            }
            
            //Clears Number after hitting check
            CheckNumberTxt.Text = "";
        }
    }
}
