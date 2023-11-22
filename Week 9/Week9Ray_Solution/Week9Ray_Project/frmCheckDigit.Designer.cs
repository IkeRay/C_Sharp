namespace Week9Ray_Project
{
    partial class frmCheckDigit
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
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ProcessBtn = new System.Windows.Forms.Button();
            this.AccountNumberBox = new System.Windows.Forms.TextBox();
            this.ConfAccountNumberBox = new System.Windows.Forms.TextBox();
            this.PaymentNumberBox = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClearBtn
            // 
            this.ClearBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClearBtn.Location = new System.Drawing.Point(533, 177);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(119, 44);
            this.ClearBtn.TabIndex = 0;
            this.ClearBtn.Text = "&Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitBtn.Location = new System.Drawing.Point(658, 177);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(119, 44);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Text = "E&xit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ProcessBtn
            // 
            this.ProcessBtn.Location = new System.Drawing.Point(408, 177);
            this.ProcessBtn.Name = "ProcessBtn";
            this.ProcessBtn.Size = new System.Drawing.Size(119, 44);
            this.ProcessBtn.TabIndex = 0;
            this.ProcessBtn.Text = "&Process";
            this.ProcessBtn.UseVisualStyleBackColor = true;
            this.ProcessBtn.Click += new System.EventHandler(this.ProcessBtn_Click);
            // 
            // AccountNumberBox
            // 
            this.AccountNumberBox.Location = new System.Drawing.Point(408, 25);
            this.AccountNumberBox.Name = "AccountNumberBox";
            this.AccountNumberBox.Size = new System.Drawing.Size(369, 20);
            this.AccountNumberBox.TabIndex = 1;
            // 
            // ConfAccountNumberBox
            // 
            this.ConfAccountNumberBox.Location = new System.Drawing.Point(408, 80);
            this.ConfAccountNumberBox.Name = "ConfAccountNumberBox";
            this.ConfAccountNumberBox.Size = new System.Drawing.Size(369, 20);
            this.ConfAccountNumberBox.TabIndex = 1;
            // 
            // PaymentNumberBox
            // 
            this.PaymentNumberBox.Location = new System.Drawing.Point(408, 133);
            this.PaymentNumberBox.Name = "PaymentNumberBox";
            this.PaymentNumberBox.Size = new System.Drawing.Size(369, 20);
            this.PaymentNumberBox.TabIndex = 1;
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOutput.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOutput.Location = new System.Drawing.Point(12, 267);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(765, 174);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "Account Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 42);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirm Account Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 42);
            this.label4.TabIndex = 3;
            this.label4.Text = "Payment Number:";
            // 
            // frmCheckDigit
            // 
            this.AcceptButton = this.ProcessBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelButton = this.ExitBtn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.PaymentNumberBox);
            this.Controls.Add(this.ConfAccountNumberBox);
            this.Controls.Add(this.AccountNumberBox);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ProcessBtn);
            this.Controls.Add(this.ClearBtn);
            this.Name = "frmCheckDigit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button ProcessBtn;
        private System.Windows.Forms.TextBox AccountNumberBox;
        private System.Windows.Forms.TextBox ConfAccountNumberBox;
        private System.Windows.Forms.TextBox PaymentNumberBox;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

