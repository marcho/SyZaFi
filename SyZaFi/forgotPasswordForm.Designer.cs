namespace SyZaFi
{
    partial class forgotPasswordForm
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
            this.remindPasswordButton = new System.Windows.Forms.Button();
            this.returnToForgotCredentialsButton = new System.Windows.Forms.Button();
            this.exitApplicationButton = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.employmentMonthTextBox = new System.Windows.Forms.TextBox();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // remindPasswordButton
            // 
            this.remindPasswordButton.Location = new System.Drawing.Point(12, 318);
            this.remindPasswordButton.Name = "remindPasswordButton";
            this.remindPasswordButton.Size = new System.Drawing.Size(260, 23);
            this.remindPasswordButton.TabIndex = 0;
            this.remindPasswordButton.Text = "Przypomnij hasło";
            this.remindPasswordButton.UseVisualStyleBackColor = true;
            this.remindPasswordButton.Click += new System.EventHandler(this.remindPasswordButton_Click);
            // 
            // returnToForgotCredentialsButton
            // 
            this.returnToForgotCredentialsButton.Location = new System.Drawing.Point(12, 347);
            this.returnToForgotCredentialsButton.Name = "returnToForgotCredentialsButton";
            this.returnToForgotCredentialsButton.Size = new System.Drawing.Size(260, 23);
            this.returnToForgotCredentialsButton.TabIndex = 1;
            this.returnToForgotCredentialsButton.Text = "Wróć";
            this.returnToForgotCredentialsButton.UseVisualStyleBackColor = true;
            this.returnToForgotCredentialsButton.Click += new System.EventHandler(this.returnToForgotCredentialsButton_Click);
            // 
            // exitApplicationButton
            // 
            this.exitApplicationButton.Location = new System.Drawing.Point(12, 376);
            this.exitApplicationButton.Name = "exitApplicationButton";
            this.exitApplicationButton.Size = new System.Drawing.Size(260, 23);
            this.exitApplicationButton.TabIndex = 2;
            this.exitApplicationButton.Text = "Wyjdź";
            this.exitApplicationButton.UseVisualStyleBackColor = true;
            this.exitApplicationButton.Click += new System.EventHandler(this.exitApplicationButton_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(172, 12);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 20);
            this.loginTextBox.TabIndex = 3;
            // 
            // employmentMonthTextBox
            // 
            this.employmentMonthTextBox.Location = new System.Drawing.Point(172, 64);
            this.employmentMonthTextBox.Name = "employmentMonthTextBox";
            this.employmentMonthTextBox.Size = new System.Drawing.Size(100, 20);
            this.employmentMonthTextBox.TabIndex = 4;
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.Location = new System.Drawing.Point(172, 38);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailAddressTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adres e-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Miesiąc zatrudnienia";
            // 
            // forgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailAddressTextBox);
            this.Controls.Add(this.employmentMonthTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.exitApplicationButton);
            this.Controls.Add(this.returnToForgotCredentialsButton);
            this.Controls.Add(this.remindPasswordButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "forgotPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Przypomnij hasło";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button remindPasswordButton;
        private System.Windows.Forms.Button returnToForgotCredentialsButton;
        private System.Windows.Forms.Button exitApplicationButton;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox employmentMonthTextBox;
        private System.Windows.Forms.TextBox emailAddressTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}