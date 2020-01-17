namespace SyZaFi
{
    partial class generateFilesSingleForm
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
            this.employeesListBox = new System.Windows.Forms.ListBox();
            this.contractOfEmploymentButton = new System.Windows.Forms.Button();
            this.contractOfMandateButton = new System.Windows.Forms.Button();
            this.contractWorkButton = new System.Windows.Forms.Button();
            this.annexChangeOfSalaryButton = new System.Windows.Forms.Button();
            this.annexChangeOfPositionButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeesListBox
            // 
            this.employeesListBox.FormattingEnabled = true;
            this.employeesListBox.Location = new System.Drawing.Point(12, 12);
            this.employeesListBox.Name = "employeesListBox";
            this.employeesListBox.Size = new System.Drawing.Size(260, 95);
            this.employeesListBox.TabIndex = 0;
            // 
            // contractOfEmploymentButton
            // 
            this.contractOfEmploymentButton.Location = new System.Drawing.Point(12, 202);
            this.contractOfEmploymentButton.Name = "contractOfEmploymentButton";
            this.contractOfEmploymentButton.Size = new System.Drawing.Size(260, 23);
            this.contractOfEmploymentButton.TabIndex = 1;
            this.contractOfEmploymentButton.Text = "Umowa o pracę";
            this.contractOfEmploymentButton.UseVisualStyleBackColor = true;
            this.contractOfEmploymentButton.Click += new System.EventHandler(this.contractOfEmploymentButton_Click);
            // 
            // contractOfMandateButton
            // 
            this.contractOfMandateButton.Location = new System.Drawing.Point(12, 231);
            this.contractOfMandateButton.Name = "contractOfMandateButton";
            this.contractOfMandateButton.Size = new System.Drawing.Size(260, 23);
            this.contractOfMandateButton.TabIndex = 2;
            this.contractOfMandateButton.Text = "Umowa zlecenie";
            this.contractOfMandateButton.UseVisualStyleBackColor = true;
            this.contractOfMandateButton.Click += new System.EventHandler(this.contractOfMandateButton_Click);
            // 
            // contractWorkButton
            // 
            this.contractWorkButton.Location = new System.Drawing.Point(12, 260);
            this.contractWorkButton.Name = "contractWorkButton";
            this.contractWorkButton.Size = new System.Drawing.Size(260, 23);
            this.contractWorkButton.TabIndex = 3;
            this.contractWorkButton.Text = "Umowa o dzieło";
            this.contractWorkButton.UseVisualStyleBackColor = true;
            this.contractWorkButton.Click += new System.EventHandler(this.contractWorkButton_Click);
            // 
            // annexChangeOfSalaryButton
            // 
            this.annexChangeOfSalaryButton.Location = new System.Drawing.Point(12, 289);
            this.annexChangeOfSalaryButton.Name = "annexChangeOfSalaryButton";
            this.annexChangeOfSalaryButton.Size = new System.Drawing.Size(260, 23);
            this.annexChangeOfSalaryButton.TabIndex = 4;
            this.annexChangeOfSalaryButton.Text = "Aneks - podwyżka";
            this.annexChangeOfSalaryButton.UseVisualStyleBackColor = true;
            this.annexChangeOfSalaryButton.Click += new System.EventHandler(this.annexChangeOfSalaryButton_Click);
            // 
            // annexChangeOfPositionButton
            // 
            this.annexChangeOfPositionButton.Location = new System.Drawing.Point(12, 318);
            this.annexChangeOfPositionButton.Name = "annexChangeOfPositionButton";
            this.annexChangeOfPositionButton.Size = new System.Drawing.Size(260, 23);
            this.annexChangeOfPositionButton.TabIndex = 5;
            this.annexChangeOfPositionButton.Text = "Aneks - zmiana stanowiska";
            this.annexChangeOfPositionButton.UseVisualStyleBackColor = true;
            this.annexChangeOfPositionButton.Click += new System.EventHandler(this.annexChangeOfPositionButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(12, 347);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(260, 23);
            this.returnButton.TabIndex = 6;
            this.returnButton.Text = "Wróć";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 376);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(260, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Wyjdź";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // generateFilesSingleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.annexChangeOfPositionButton);
            this.Controls.Add(this.annexChangeOfSalaryButton);
            this.Controls.Add(this.contractWorkButton);
            this.Controls.Add(this.contractOfMandateButton);
            this.Controls.Add(this.contractOfEmploymentButton);
            this.Controls.Add(this.employeesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "generateFilesSingleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generuj pliki (pojedynczo)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox employeesListBox;
        private System.Windows.Forms.Button contractOfEmploymentButton;
        private System.Windows.Forms.Button contractOfMandateButton;
        private System.Windows.Forms.Button contractWorkButton;
        private System.Windows.Forms.Button annexChangeOfSalaryButton;
        private System.Windows.Forms.Button annexChangeOfPositionButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button exitButton;
    }
}