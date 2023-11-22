using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2_Ray_Project
{
    /*
     * Name : Isom Ray
     * Class : ITD 2343
     * Due Date : 9/19/2023
     */
    public partial class FrmFall2023 : Form
    {
        public FrmFall2023()
        {
            InitializeComponent();

            // Label Output
            lblOutput.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void lblOutput_Click(object sender, EventArgs e)
        {

        }

        // Exit button
        private void Exit_Click(object sender, EventArgs e) 
        {
            this.Close();
        }

        // Save and output Button
        private void btnSave_Click(object sender, EventArgs e)
        {
            lblOutput.Text = textBox1.Text;
        }

        // Wipe button
        private void btnWipe_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
        }
        
        //Clears the Text box
        private void btnCancel_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
