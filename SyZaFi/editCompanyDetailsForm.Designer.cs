namespace SyZaFi
{
    partial class editCompanyDetailsForm
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
            this.companyNIPTextBox = new System.Windows.Forms.TextBox();
            this.companyKRSTextBox = new System.Windows.Forms.TextBox();
            this.companyREGONTextBox = new System.Windows.Forms.TextBox();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.modifyButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // companyNIPTextBox
            // 
            this.companyNIPTextBox.Location = new System.Drawing.Point(88, 38);
            this.companyNIPTextBox.Name = "companyNIPTextBox";
            this.companyNIPTextBox.Size = new System.Drawing.Size(184, 20);
            this.companyNIPTextBox.TabIndex = 0;
            // 
            // companyKRSTextBox
            // 
            this.companyKRSTextBox.Location = new System.Drawing.Point(88, 90);
            this.companyKRSTextBox.Name = "companyKRSTextBox";
            this.companyKRSTextBox.Size = new System.Drawing.Size(184, 20);
            this.companyKRSTextBox.TabIndex = 1;
            // 
            // companyREGONTextBox
            // 
            this.companyREGONTextBox.Location = new System.Drawing.Point(88, 64);
            this.companyREGONTextBox.Name = "companyREGONTextBox";
            this.companyREGONTextBox.Size = new System.Drawing.Size(184, 20);
            this.companyREGONTextBox.TabIndex = 2;
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.Location = new System.Drawing.Point(88, 12);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(184, 20);
            this.companyNameTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nazwa firmy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "KRS firmy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "REGON firmy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "NIP firmy";
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(12, 318);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(260, 23);
            this.modifyButton.TabIndex = 8;
            this.modifyButton.Text = "Zmień";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(12, 347);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(260, 23);
            this.returnButton.TabIndex = 9;
            this.returnButton.Text = "Wróć";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 376);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(260, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Wyjdź";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // editCompanyDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(this.companyREGONTextBox);
            this.Controls.Add(this.companyKRSTextBox);
            this.Controls.Add(this.companyNIPTextBox);
            this.Name = "editCompanyDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zmień dane firmy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox companyNIPTextBox;
        private System.Windows.Forms.TextBox companyKRSTextBox;
        private System.Windows.Forms.TextBox companyREGONTextBox;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button exitButton;
    }
}