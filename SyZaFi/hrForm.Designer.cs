namespace SyZaFi
{
    partial class hrForm
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
            this.newEmployeeButton = new System.Windows.Forms.Button();
            this.deleteEmployeeButton = new System.Windows.Forms.Button();
            this.editEmployeeButton = new System.Windows.Forms.Button();
            this.exitApplicationButton = new System.Windows.Forms.Button();
            this.generateFilesSingleButton = new System.Windows.Forms.Button();
            this.generateNewEmployeeFiles = new System.Windows.Forms.Button();
            this.generateTerminationOfEmployment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newEmployeeButton
            // 
            this.newEmployeeButton.Location = new System.Drawing.Point(12, 18);
            this.newEmployeeButton.Name = "newEmployeeButton";
            this.newEmployeeButton.Size = new System.Drawing.Size(127, 86);
            this.newEmployeeButton.TabIndex = 0;
            this.newEmployeeButton.Text = "Dodaj nowego pracownika";
            this.newEmployeeButton.UseVisualStyleBackColor = true;
            this.newEmployeeButton.Click += new System.EventHandler(this.newEmployeeButton_Click);
            // 
            // deleteEmployeeButton
            // 
            this.deleteEmployeeButton.Location = new System.Drawing.Point(12, 202);
            this.deleteEmployeeButton.Name = "deleteEmployeeButton";
            this.deleteEmployeeButton.Size = new System.Drawing.Size(127, 86);
            this.deleteEmployeeButton.TabIndex = 1;
            this.deleteEmployeeButton.Text = "Usuń istniejącego pracownika";
            this.deleteEmployeeButton.UseVisualStyleBackColor = true;
            this.deleteEmployeeButton.Click += new System.EventHandler(this.deleteEmployeeButton_Click);
            // 
            // editEmployeeButton
            // 
            this.editEmployeeButton.Location = new System.Drawing.Point(12, 110);
            this.editEmployeeButton.Name = "editEmployeeButton";
            this.editEmployeeButton.Size = new System.Drawing.Size(127, 86);
            this.editEmployeeButton.TabIndex = 2;
            this.editEmployeeButton.Text = "Edytuj istniejącego pracownika";
            this.editEmployeeButton.UseVisualStyleBackColor = true;
            this.editEmployeeButton.Click += new System.EventHandler(this.editEmployeeButton_Click);
            // 
            // exitApplicationButton
            // 
            this.exitApplicationButton.Location = new System.Drawing.Point(12, 321);
            this.exitApplicationButton.Name = "exitApplicationButton";
            this.exitApplicationButton.Size = new System.Drawing.Size(260, 78);
            this.exitApplicationButton.TabIndex = 3;
            this.exitApplicationButton.Text = "Wyjdź";
            this.exitApplicationButton.UseVisualStyleBackColor = true;
            this.exitApplicationButton.Click += new System.EventHandler(this.exitApplicationButton_Click);
            // 
            // generateFilesSingleButton
            // 
            this.generateFilesSingleButton.Location = new System.Drawing.Point(145, 18);
            this.generateFilesSingleButton.Name = "generateFilesSingleButton";
            this.generateFilesSingleButton.Size = new System.Drawing.Size(127, 86);
            this.generateFilesSingleButton.TabIndex = 4;
            this.generateFilesSingleButton.Text = "Generuj pliki";
            this.generateFilesSingleButton.UseVisualStyleBackColor = true;
            this.generateFilesSingleButton.Click += new System.EventHandler(this.generateFilesSingleButton_Click);
            // 
            // generateNewEmployeeFiles
            // 
            this.generateNewEmployeeFiles.Location = new System.Drawing.Point(145, 110);
            this.generateNewEmployeeFiles.Name = "generateNewEmployeeFiles";
            this.generateNewEmployeeFiles.Size = new System.Drawing.Size(127, 86);
            this.generateNewEmployeeFiles.TabIndex = 5;
            this.generateNewEmployeeFiles.Text = "Generuj pakiet nowego pracownika";
            this.generateNewEmployeeFiles.UseVisualStyleBackColor = true;
            this.generateNewEmployeeFiles.Click += new System.EventHandler(this.generateNewEmployeeFiles_Click);
            // 
            // generateTerminationOfEmployment
            // 
            this.generateTerminationOfEmployment.Location = new System.Drawing.Point(145, 202);
            this.generateTerminationOfEmployment.Name = "generateTerminationOfEmployment";
            this.generateTerminationOfEmployment.Size = new System.Drawing.Size(127, 86);
            this.generateTerminationOfEmployment.TabIndex = 6;
            this.generateTerminationOfEmployment.Text = "Generuj wypowiedzenie";
            this.generateTerminationOfEmployment.UseVisualStyleBackColor = true;
            // 
            // hrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.generateTerminationOfEmployment);
            this.Controls.Add(this.generateNewEmployeeFiles);
            this.Controls.Add(this.generateFilesSingleButton);
            this.Controls.Add(this.exitApplicationButton);
            this.Controls.Add(this.editEmployeeButton);
            this.Controls.Add(this.deleteEmployeeButton);
            this.Controls.Add(this.newEmployeeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "hrForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zasoby ludzkie";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newEmployeeButton;
        private System.Windows.Forms.Button deleteEmployeeButton;
        private System.Windows.Forms.Button editEmployeeButton;
        private System.Windows.Forms.Button exitApplicationButton;
        private System.Windows.Forms.Button generateFilesSingleButton;
        private System.Windows.Forms.Button generateNewEmployeeFiles;
        private System.Windows.Forms.Button generateTerminationOfEmployment;
    }
}