namespace SyZaFi
{
    partial class forgotBothForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.returnToForgotCredentialsButton = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.monthOfEmploymentTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.remindCredentialsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 376);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(260, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.TabStop = false;
            this.exitButton.Text = "Wyjście";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // returnToForgotCredentialsButton
            // 
            this.returnToForgotCredentialsButton.Location = new System.Drawing.Point(12, 347);
            this.returnToForgotCredentialsButton.Name = "returnToForgotCredentialsButton";
            this.returnToForgotCredentialsButton.Size = new System.Drawing.Size(260, 23);
            this.returnToForgotCredentialsButton.TabIndex = 1;
            this.returnToForgotCredentialsButton.TabStop = false;
            this.returnToForgotCredentialsButton.Text = "Cofnij";
            this.returnToForgotCredentialsButton.UseVisualStyleBackColor = true;
            this.returnToForgotCredentialsButton.Click += new System.EventHandler(this.returnToForgotCredentialsButton_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(121, 12);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(151, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(121, 38);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(151, 20);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(121, 64);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(151, 20);
            this.emailTextBox.TabIndex = 3;
            // 
            // monthOfEmploymentTextBox
            // 
            this.monthOfEmploymentTextBox.Location = new System.Drawing.Point(121, 90);
            this.monthOfEmploymentTextBox.Name = "monthOfEmploymentTextBox";
            this.monthOfEmploymentTextBox.Size = new System.Drawing.Size(151, 20);
            this.monthOfEmploymentTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Adres e-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Miesiąc zatrudnienia";
            // 
            // remindCredentialsButton
            // 
            this.remindCredentialsButton.Location = new System.Drawing.Point(12, 318);
            this.remindCredentialsButton.Name = "remindCredentialsButton";
            this.remindCredentialsButton.Size = new System.Drawing.Size(260, 23);
            this.remindCredentialsButton.TabIndex = 10;
            this.remindCredentialsButton.TabStop = false;
            this.remindCredentialsButton.Text = "Przypomnij dane";
            this.remindCredentialsButton.UseVisualStyleBackColor = true;
            this.remindCredentialsButton.Click += new System.EventHandler(this.remindCredentialsButton_Click);
            // 
            // forgotBothForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.remindCredentialsButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthOfEmploymentTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.returnToForgotCredentialsButton);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "forgotBothForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Przypomnij login i hasło";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button returnToForgotCredentialsButton;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox monthOfEmploymentTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button remindCredentialsButton;
    }
}