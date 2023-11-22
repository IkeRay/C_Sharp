using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*

     * Name : Isom Ray
     * Class : ITD 2343
     * Due Date : 10/24/2023

 */

namespace Module6MethodsProjectDL
{
    public partial class frmRealID : Form
    {
        // Public Contsants to use
        const byte ADD = 0;
        const byte SUBTRACT = 1;
        const byte MULTIPLY = 2;
        const byte DIVIDE = 3;
        const byte MODULUS = 4;

        public frmRealID()
        {
            InitializeComponent();
            LblOutput.Text = "";

        }

        //Moduluses Left and Right
        private void Modulus_Click(object sender, EventArgs e)
        {
            try
            {
                decimal dLeft = 0.0m;
                decimal dRight = 0.0m;
                decimal dAnswer = 0.0m;
                string szLeft = "";
                string szRight = "";
                string szAnswer = "";
                string szEquation = "";

                szLeft = RightTXT.Text;
                szRight = LeftTXT.Text;

                dLeft = Convert.ToDecimal(szLeft);
                dRight = Convert.ToDecimal(szRight);

                dAnswer = dLeft % dRight;

                szAnswer = dAnswer.ToString();

                szEquation = szLeft + " % " + szRight + " = " + szAnswer;

                LblOutput.Text = "";
                LblOutput.Text = szEquation;
                LblOutput.ForeColor = Color.Blue;
            }
            catch (FormatException)
            {
                LblOutput.ForeColor = Color.Red;
                LblOutput.Text = ("Invalid input. Please enter valid integers.");
            }


        }

        //Devide Left and Right
        private void Devide_Click(object sender, EventArgs e)
        {
            try
            {
                decimal dLeft = 0.0m;
                decimal dRight = 0.0m;
                decimal dAnswer = 0.0m;
                string szLeft = "";
                string szRight = "";
                string szAnswer = "";
                string szEquation = "";

                szLeft = RightTXT.Text;
                szRight = LeftTXT.Text;

                dLeft = Convert.ToDecimal(szLeft);
                dRight = Convert.ToDecimal(szRight);

                dAnswer = dLeft / dRight;

                szAnswer = dAnswer.ToString();

                szEquation = szLeft + " / " + szRight + " = " + szAnswer;

                LblOutput.Text = "";
                LblOutput.Text = szEquation;
                LblOutput.ForeColor = Color.Blue;

            }
            catch (FormatException ex)
            {
                LblOutput.ForeColor = Color.Red;
                LblOutput.Text = ("Invalid input. Please enter valid integers.");
            }
            catch (DivideByZeroException)
            {
                LblOutput.ForeColor = Color.Red;
                LblOutput.Text = ("SO FUN FACT YOU CANT DO THAT");
            }
        }

        //Multiply Left and Right
        private void Mul_Click(object sender, EventArgs e)
        {
            try
            {
                decimal dLeft = 0.0m;
                decimal dRight = 0.0m;
                decimal dAnswer = 0.0m;
                string szLeft = "";
                string szRight = "";
                string szAnswer = "";
                string szEquation = "";

                szLeft = RightTXT.Text;
                szRight = LeftTXT.Text;

                dLeft = Convert.ToDecimal(szLeft);
                dRight = Convert.ToDecimal(szRight);

                dAnswer = dLeft * dRight;

                szAnswer = dAnswer.ToString();

                szEquation = szLeft + " * " + szRight + " = " + szAnswer;

                LblOutput.Text = "";
                LblOutput.Text = szEquation;
                LblOutput.ForeColor = Color.Blue;
            }
            catch (FormatException ex)
            {
                LblOutput.ForeColor = Color.Red;
                LblOutput.Text = ("Invalid input. Please enter valid integers.");
            }

        }

        //Subtracts Left and Right
        private void Sub_Click(object sender, EventArgs e)
        {
            try
            {
                decimal dLeft = 0.0m;
                decimal dRight = 0.0m;
                decimal dAnswer = 0.0m;
                string szLeft = "";
                string szRight = "";
                string szAnswer = "";
                string szEquation = "";

                szLeft = RightTXT.Text;
                szRight = LeftTXT.Text;

                dLeft = Convert.ToDecimal(szLeft);
                dRight = Convert.ToDecimal(szRight);

                dAnswer = dLeft - dRight;

                szAnswer = dAnswer.ToString();

                szEquation = szLeft + " - " + szRight + " = " + szAnswer;

                LblOutput.Text = "";
                LblOutput.Text = szEquation;
                LblOutput.ForeColor = Color.Blue;
            }
            catch (FormatException ex)
            {
                LblOutput.ForeColor = Color.Red;
                LblOutput.Text = ("Invalid input. Please enter valid integers.");
            }

        }

        //Adds Left and Right
        private void Plus_Click(object sender, EventArgs e)
        {
            try
            {
                decimal dLeft = 0.0m;
                decimal dRight = 0.0m;
                decimal dAnswer = 0.0m;
                string szLeft = "";
                string szRight = "";
                string szAnswer = "";
                string szEquation = "";

                szLeft = RightTXT.Text;
                szRight = LeftTXT.Text;

                dLeft = Convert.ToDecimal(szLeft);
                dRight = Convert.ToDecimal(szRight);

                dAnswer = dLeft + dRight;

                szAnswer = dAnswer.ToString();

                szEquation = szLeft + " + " + szRight + " = " + szAnswer;

                LblOutput.Text = "";
                LblOutput.Text = szEquation;
                LblOutput.ForeColor = Color.Blue;
            }
            catch (FormatException ex)
            {
                LblOutput.ForeColor = Color.Red;
                LblOutput.Text = ("Invalid input. Please enter valid integers.");
            }

        }

        private void frmRealID_Load(object sender, EventArgs e)
        {

        }

        //Closese form
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Clears all Text
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            LblOutput.Text = "";
            RightTXT.Text = "";
            LeftTXT.Text = "";
        }
    }
}
