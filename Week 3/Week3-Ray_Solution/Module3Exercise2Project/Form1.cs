using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module3Exercise2Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            lblMessage.BackColor = btnRed.BackColor;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            lblMessage.BackColor = btnBlue.BackColor;

        }

        private void btnL_Click(object sender, EventArgs e)
        {
            //Fixed btnL error
            lblMessage.Text = btnL.Text;

        }

        private void btnR_Click(object sender, EventArgs e)
        {
            // Fixed lbl error and btnR Error
            lblMessage.Text = btnR.Text;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
