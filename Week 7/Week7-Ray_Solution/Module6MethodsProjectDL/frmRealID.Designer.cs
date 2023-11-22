namespace Module6MethodsProjectDL
{
    partial class frmRealID
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
            this.LeftTXT = new System.Windows.Forms.TextBox();
            this.RightTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SubBtn = new System.Windows.Forms.Button();
            this.MulBtn = new System.Windows.Forms.Button();
            this.DevideBtn = new System.Windows.Forms.Button();
            this.ModBtn = new System.Windows.Forms.Button();
            this.LblOutput = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LeftTXT
            // 
            this.LeftTXT.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftTXT.Location = new System.Drawing.Point(157, 42);
            this.LeftTXT.Margin = new System.Windows.Forms.Padding(2);
            this.LeftTXT.Name = "LeftTXT";
            this.LeftTXT.Size = new System.Drawing.Size(122, 32);
            this.LeftTXT.TabIndex = 0;
            // 
            // RightTXT
            // 
            this.RightTXT.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightTXT.Location = new System.Drawing.Point(157, 3);
            this.RightTXT.Margin = new System.Windows.Forms.Padding(2);
            this.RightTXT.Name = "RightTXT";
            this.RightTXT.Size = new System.Drawing.Size(122, 32);
            this.RightTXT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Left Operand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "RightOperand";
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(8, 86);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(32, 37);
            this.AddBtn.TabIndex = 4;
            this.AddBtn.Text = "+";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.Plus_Click);
            // 
            // SubBtn
            // 
            this.SubBtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubBtn.Location = new System.Drawing.Point(67, 86);
            this.SubBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SubBtn.Name = "SubBtn";
            this.SubBtn.Size = new System.Drawing.Size(32, 37);
            this.SubBtn.TabIndex = 5;
            this.SubBtn.Text = "-";
            this.SubBtn.UseVisualStyleBackColor = true;
            this.SubBtn.Click += new System.EventHandler(this.Sub_Click);
            // 
            // MulBtn
            // 
            this.MulBtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MulBtn.Location = new System.Drawing.Point(127, 86);
            this.MulBtn.Margin = new System.Windows.Forms.Padding(2);
            this.MulBtn.Name = "MulBtn";
            this.MulBtn.Size = new System.Drawing.Size(32, 37);
            this.MulBtn.TabIndex = 6;
            this.MulBtn.Text = "*";
            this.MulBtn.UseVisualStyleBackColor = true;
            this.MulBtn.Click += new System.EventHandler(this.Mul_Click);
            // 
            // DevideBtn
            // 
            this.DevideBtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevideBtn.Location = new System.Drawing.Point(186, 86);
            this.DevideBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DevideBtn.Name = "DevideBtn";
            this.DevideBtn.Size = new System.Drawing.Size(32, 37);
            this.DevideBtn.TabIndex = 7;
            this.DevideBtn.Text = "/";
            this.DevideBtn.UseVisualStyleBackColor = true;
            this.DevideBtn.Click += new System.EventHandler(this.Devide_Click);
            // 
            // ModBtn
            // 
            this.ModBtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModBtn.Location = new System.Drawing.Point(245, 86);
            this.ModBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ModBtn.Name = "ModBtn";
            this.ModBtn.Size = new System.Drawing.Size(32, 37);
            this.ModBtn.TabIndex = 8;
            this.ModBtn.Text = "%";
            this.ModBtn.UseVisualStyleBackColor = true;
            this.ModBtn.Click += new System.EventHandler(this.Modulus_Click);
            // 
            // LblOutput
            // 
            this.LblOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LblOutput.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOutput.Location = new System.Drawing.Point(8, 134);
            this.LblOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(269, 84);
            this.LblOutput.TabIndex = 9;
            this.LblOutput.Text = "Answer Shows Here";
            this.LblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(8, 222);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(129, 55);
            this.ClearBtn.TabIndex = 10;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(143, 222);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(134, 55);
            this.ExitBtn.TabIndex = 10;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // frmRealID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.CancelButton = this.ExitBtn;
            this.ClientSize = new System.Drawing.Size(286, 279);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.ModBtn);
            this.Controls.Add(this.DevideBtn);
            this.Controls.Add(this.MulBtn);
            this.Controls.Add(this.SubBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RightTXT);
            this.Controls.Add(this.LeftTXT);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRealID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valid ID Required";
            this.Load += new System.EventHandler(this.frmRealID_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LeftTXT;
        private System.Windows.Forms.TextBox RightTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button SubBtn;
        private System.Windows.Forms.Button MulBtn;
        private System.Windows.Forms.Button DevideBtn;
        private System.Windows.Forms.Button ModBtn;
        private System.Windows.Forms.Label LblOutput;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}

