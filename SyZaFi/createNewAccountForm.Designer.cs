namespace SyZaFi
{
    partial class createNewAccountForm
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
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.workgroupListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.registerNewAccountButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.employmentMonthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(108, 12);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(164, 20);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(108, 243);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(164, 20);
            this.passwordTextBox.TabIndex = 4;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(108, 217);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(164, 20);
            this.loginTextBox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(108, 38);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(164, 20);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(108, 64);
            this.birthdayDateTimePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.birthdayDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(164, 20);
            this.birthdayDateTimePicker.TabIndex = 4;
            this.birthdayDateTimePicker.TabStop = false;
            this.birthdayDateTimePicker.Value = new System.DateTime(2019, 11, 12, 0, 0, 0, 0);
            // 
            // workgroupListBox
            // 
            this.workgroupListBox.FormattingEnabled = true;
            this.workgroupListBox.Items.AddRange(new object[] {
            "Finanse i rachunkowość",
            "Logistyka i magazyny",
            "Produkcja",
            "Właściciel",
            "Zasoby ludzkie"});
            this.workgroupListBox.Location = new System.Drawing.Point(108, 116);
            this.workgroupListBox.Name = "workgroupListBox";
            this.workgroupListBox.Size = new System.Drawing.Size(164, 95);
            this.workgroupListBox.Sorted = true;
            this.workgroupListBox.TabIndex = 5;
            this.workgroupListBox.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 376);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(260, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Wyjdź";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(12, 347);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(260, 23);
            this.returnButton.TabIndex = 7;
            this.returnButton.Text = "Wstecz";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // registerNewAccountButton
            // 
            this.registerNewAccountButton.Location = new System.Drawing.Point(12, 318);
            this.registerNewAccountButton.Name = "registerNewAccountButton";
            this.registerNewAccountButton.Size = new System.Drawing.Size(260, 23);
            this.registerNewAccountButton.TabIndex = 8;
            this.registerNewAccountButton.Text = "Załóż nowe konto";
            this.registerNewAccountButton.UseVisualStyleBackColor = true;
            this.registerNewAccountButton.Click += new System.EventHandler(this.registerNewAccountButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Data urodzenia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Grupa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Login";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hasło";
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.Location = new System.Drawing.Point(108, 269);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(164, 20);
            this.emailAddressTextBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Adres e-mail";
            // 
            // employmentMonthDatePicker
            // 
            this.employmentMonthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.employmentMonthDatePicker.Location = new System.Drawing.Point(108, 90);
            this.employmentMonthDatePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.employmentMonthDatePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.employmentMonthDatePicker.Name = "employmentMonthDatePicker";
            this.employmentMonthDatePicker.Size = new System.Drawing.Size(164, 20);
            this.employmentMonthDatePicker.TabIndex = 17;
            this.employmentMonthDatePicker.TabStop = false;
            this.employmentMonthDatePicker.Value = new System.DateTime(2019, 11, 12, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Data zatrudnienia";
            // 
            // createNewAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.employmentMonthDatePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.emailAddressTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerNewAccountButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.workgroupListBox);
            this.Controls.Add(this.birthdayDateTimePicker);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "createNewAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Utwórz nowe konto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.ListBox workgroupListBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button registerNewAccountButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailAddressTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker employmentMonthDatePicker;
        private System.Windows.Forms.Label label8;
    }
}