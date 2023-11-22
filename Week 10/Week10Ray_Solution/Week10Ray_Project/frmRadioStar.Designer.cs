namespace Week10Ray_Project
{
    partial class frmRadioStar
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
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.Outputlbl = new System.Windows.Forms.Label();
            this.LeftTxt = new System.Windows.Forms.TextBox();
            this.RightTxt = new System.Windows.Forms.TextBox();
            this.Left = new System.Windows.Forms.Label();
            this.Right = new System.Windows.Forms.Label();
            this.AdditionBtn = new System.Windows.Forms.RadioButton();
            this.MultiplyBtn = new System.Windows.Forms.RadioButton();
            this.ModulusBtn = new System.Windows.Forms.RadioButton();
            this.SubBtn = new System.Windows.Forms.RadioButton();
            this.DivBtn = new System.Windows.Forms.RadioButton();
            this.VerboseBtn = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBtn.Location = new System.Drawing.Point(15, 104);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(133, 43);
            this.CalculateBtn.TabIndex = 9;
            this.CalculateBtn.Text = "CALCULATE";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click_1);
            // 
            // ClearBtn
            // 
            this.ClearBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ClearBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(154, 104);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(133, 43);
            this.ClearBtn.TabIndex = 10;
            this.ClearBtn.Text = "CLEAR";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(293, 104);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(133, 43);
            this.ExitBtn.TabIndex = 11;
            this.ExitBtn.Text = "EXIT";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Outputlbl
            // 
            this.Outputlbl.BackColor = System.Drawing.Color.Gray;
            this.Outputlbl.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outputlbl.Location = new System.Drawing.Point(12, 150);
            this.Outputlbl.Name = "Outputlbl";
            this.Outputlbl.Size = new System.Drawing.Size(776, 251);
            this.Outputlbl.TabIndex = 1;
            this.Outputlbl.Text = "label1";
            this.Outputlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeftTxt
            // 
            this.LeftTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftTxt.Location = new System.Drawing.Point(154, 12);
            this.LeftTxt.Name = "LeftTxt";
            this.LeftTxt.Size = new System.Drawing.Size(272, 26);
            this.LeftTxt.TabIndex = 1;
            // 
            // RightTxt
            // 
            this.RightTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightTxt.Location = new System.Drawing.Point(154, 59);
            this.RightTxt.Name = "RightTxt";
            this.RightTxt.Size = new System.Drawing.Size(272, 26);
            this.RightTxt.TabIndex = 2;
            // 
            // Left
            // 
            this.Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Left.Location = new System.Drawing.Point(23, 12);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(125, 26);
            this.Left.TabIndex = 3;
            this.Left.Text = "Left Operand:";
            this.Left.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Right
            // 
            this.Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Right.Location = new System.Drawing.Point(23, 58);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(125, 26);
            this.Right.TabIndex = 3;
            this.Right.Text = "Right Operand:";
            this.Right.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdditionBtn
            // 
            this.AdditionBtn.AutoSize = true;
            this.AdditionBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionBtn.Location = new System.Drawing.Point(455, 44);
            this.AdditionBtn.Name = "AdditionBtn";
            this.AdditionBtn.Size = new System.Drawing.Size(120, 26);
            this.AdditionBtn.TabIndex = 3;
            this.AdditionBtn.TabStop = true;
            this.AdditionBtn.Text = "Addition(+)";
            this.AdditionBtn.UseVisualStyleBackColor = true;
            // 
            // MultiplyBtn
            // 
            this.MultiplyBtn.AutoSize = true;
            this.MultiplyBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplyBtn.Location = new System.Drawing.Point(455, 76);
            this.MultiplyBtn.Name = "MultiplyBtn";
            this.MultiplyBtn.Size = new System.Drawing.Size(118, 26);
            this.MultiplyBtn.TabIndex = 4;
            this.MultiplyBtn.TabStop = true;
            this.MultiplyBtn.Text = "Multiply(*)";
            this.MultiplyBtn.UseVisualStyleBackColor = true;
            // 
            // ModulusBtn
            // 
            this.ModulusBtn.AutoSize = true;
            this.ModulusBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModulusBtn.Location = new System.Drawing.Point(455, 108);
            this.ModulusBtn.Name = "ModulusBtn";
            this.ModulusBtn.Size = new System.Drawing.Size(129, 26);
            this.ModulusBtn.TabIndex = 5;
            this.ModulusBtn.TabStop = true;
            this.ModulusBtn.Text = "Modulus(%)";
            this.ModulusBtn.UseVisualStyleBackColor = true;
            // 
            // SubBtn
            // 
            this.SubBtn.AutoSize = true;
            this.SubBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubBtn.Location = new System.Drawing.Point(597, 44);
            this.SubBtn.Name = "SubBtn";
            this.SubBtn.Size = new System.Drawing.Size(141, 26);
            this.SubBtn.TabIndex = 6;
            this.SubBtn.TabStop = true;
            this.SubBtn.Text = "Subtraction(-)";
            this.SubBtn.UseVisualStyleBackColor = true;
            // 
            // DivBtn
            // 
            this.DivBtn.AutoSize = true;
            this.DivBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivBtn.Location = new System.Drawing.Point(597, 76);
            this.DivBtn.Name = "DivBtn";
            this.DivBtn.Size = new System.Drawing.Size(111, 26);
            this.DivBtn.TabIndex = 7;
            this.DivBtn.TabStop = true;
            this.DivBtn.Text = "Division(/)";
            this.DivBtn.UseVisualStyleBackColor = true;
            // 
            // VerboseBtn
            // 
            this.VerboseBtn.AutoSize = true;
            this.VerboseBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerboseBtn.Location = new System.Drawing.Point(597, 108);
            this.VerboseBtn.Name = "VerboseBtn";
            this.VerboseBtn.Size = new System.Drawing.Size(156, 26);
            this.VerboseBtn.TabIndex = 8;
            this.VerboseBtn.Text = "Verbose Mode?";
            this.VerboseBtn.UseVisualStyleBackColor = true;
            this.VerboseBtn.CheckedChanged += new System.EventHandler(this.VerboseBtn_CheckedChanged);
            // 
            // frmRadioStar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CancelButton = this.ExitBtn;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.VerboseBtn);
            this.Controls.Add(this.ModulusBtn);
            this.Controls.Add(this.DivBtn);
            this.Controls.Add(this.SubBtn);
            this.Controls.Add(this.MultiplyBtn);
            this.Controls.Add(this.AdditionBtn);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.RightTxt);
            this.Controls.Add(this.LeftTxt);
            this.Controls.Add(this.Outputlbl);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.CalculateBtn);
            this.Name = "frmRadioStar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radio Buttons in Action";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label Outputlbl;
        private System.Windows.Forms.TextBox LeftTxt;
        private System.Windows.Forms.TextBox RightTxt;
        private System.Windows.Forms.Label Left;
        private System.Windows.Forms.Label Right;
        private System.Windows.Forms.RadioButton AdditionBtn;
        private System.Windows.Forms.RadioButton MultiplyBtn;
        private System.Windows.Forms.RadioButton ModulusBtn;
        private System.Windows.Forms.RadioButton SubBtn;
        private System.Windows.Forms.RadioButton DivBtn;
        private System.Windows.Forms.CheckBox VerboseBtn;
    }
}

