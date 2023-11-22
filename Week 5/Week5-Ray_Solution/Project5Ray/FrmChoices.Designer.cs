namespace Project5Ray
{
    partial class FrmChoices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChoices));
            this.Instructions = new System.Windows.Forms.Label();
            this.Leftlbl = new System.Windows.Forms.Label();
            this.Rightlbl = new System.Windows.Forms.Label();
            this.Middlelbl = new System.Windows.Forms.Label();
            this.LowerRangeTxt = new System.Windows.Forms.TextBox();
            this.UpperRangeTxt = new System.Windows.Forms.TextBox();
            this.CheckNumberTxt = new System.Windows.Forms.TextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Instructions
            // 
            this.Instructions.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructions.Location = new System.Drawing.Point(12, 9);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(489, 171);
            this.Instructions.TabIndex = 0;
            this.Instructions.Text = resources.GetString("Instructions.Text");
            // 
            // Leftlbl
            // 
            this.Leftlbl.AutoSize = true;
            this.Leftlbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leftlbl.Location = new System.Drawing.Point(13, 180);
            this.Leftlbl.Name = "Leftlbl";
            this.Leftlbl.Size = new System.Drawing.Size(144, 26);
            this.Leftlbl.TabIndex = 1;
            this.Leftlbl.Text = "Left Number";
            this.Leftlbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // Rightlbl
            // 
            this.Rightlbl.AutoSize = true;
            this.Rightlbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rightlbl.Location = new System.Drawing.Point(327, 180);
            this.Rightlbl.Name = "Rightlbl";
            this.Rightlbl.Size = new System.Drawing.Size(159, 26);
            this.Rightlbl.TabIndex = 1;
            this.Rightlbl.Text = "Right Number";
            // 
            // Middlelbl
            // 
            this.Middlelbl.AutoSize = true;
            this.Middlelbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Middlelbl.Location = new System.Drawing.Point(129, 241);
            this.Middlelbl.Name = "Middlelbl";
            this.Middlelbl.Size = new System.Drawing.Size(247, 26);
            this.Middlelbl.TabIndex = 1;
            this.Middlelbl.Text = "Number to be Checked";
            this.Middlelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Middlelbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // LowerRangeTxt
            // 
            this.LowerRangeTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowerRangeTxt.Location = new System.Drawing.Point(18, 210);
            this.LowerRangeTxt.Name = "LowerRangeTxt";
            this.LowerRangeTxt.Size = new System.Drawing.Size(139, 26);
            this.LowerRangeTxt.TabIndex = 2;
            // 
            // UpperRangeTxt
            // 
            this.UpperRangeTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpperRangeTxt.Location = new System.Drawing.Point(332, 210);
            this.UpperRangeTxt.Name = "UpperRangeTxt";
            this.UpperRangeTxt.Size = new System.Drawing.Size(154, 26);
            this.UpperRangeTxt.TabIndex = 2;
            // 
            // CheckNumberTxt
            // 
            this.CheckNumberTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckNumberTxt.Location = new System.Drawing.Point(163, 271);
            this.CheckNumberTxt.Name = "CheckNumberTxt";
            this.CheckNumberTxt.Size = new System.Drawing.Size(171, 26);
            this.CheckNumberTxt.TabIndex = 2;
            // 
            // ClearBtn
            // 
            this.ClearBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ClearBtn.BackColor = System.Drawing.Color.Salmon;
            this.ClearBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(35, 303);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(139, 44);
            this.ClearBtn.TabIndex = 3;
            this.ClearBtn.Text = "Clea&r";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // CheckBtn
            // 
            this.CheckBtn.BackColor = System.Drawing.Color.Salmon;
            this.CheckBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBtn.Location = new System.Drawing.Point(180, 303);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(139, 44);
            this.CheckBtn.TabIndex = 3;
            this.CheckBtn.Text = "&Check";
            this.CheckBtn.UseVisualStyleBackColor = false;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Salmon;
            this.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(325, 303);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(139, 44);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "E&xit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.Color.Orange;
            this.lblOutput.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(-2, 359);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(503, 103);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOutput.Click += new System.EventHandler(this.lblOutput_Click);
            // 
            // FrmChoices
            // 
            this.AcceptButton = this.CheckBtn;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.CancelButton = this.ExitBtn;
            this.ClientSize = new System.Drawing.Size(498, 460);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.CheckNumberTxt);
            this.Controls.Add(this.UpperRangeTxt);
            this.Controls.Add(this.LowerRangeTxt);
            this.Controls.Add(this.Middlelbl);
            this.Controls.Add(this.Rightlbl);
            this.Controls.Add(this.Leftlbl);
            this.Controls.Add(this.Instructions);
            this.Name = "FrmChoices";
            this.Text = "RayChoices";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Instructions;
        private System.Windows.Forms.Label Leftlbl;
        private System.Windows.Forms.Label Rightlbl;
        private System.Windows.Forms.Label Middlelbl;
        private System.Windows.Forms.TextBox LowerRangeTxt;
        private System.Windows.Forms.TextBox UpperRangeTxt;
        private System.Windows.Forms.TextBox CheckNumberTxt;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button CheckBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label lblOutput;
    }
}

