namespace SyZaFi
{
    partial class configurationForm
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
            this.checkFilesButton = new System.Windows.Forms.Button();
            this.checkDatabaseButton = new System.Windows.Forms.Button();
            this.createNewAccountButton = new System.Windows.Forms.Button();
            this.modifyAccountButton = new System.Windows.Forms.Button();
            this.deleteAccountButton = new System.Windows.Forms.Button();
            this.checkLogsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkFilesButton
            // 
            this.checkFilesButton.Location = new System.Drawing.Point(12, 12);
            this.checkFilesButton.Name = "checkFilesButton";
            this.checkFilesButton.Size = new System.Drawing.Size(127, 86);
            this.checkFilesButton.TabIndex = 0;
            this.checkFilesButton.Text = "Sprawdź pliki";
            this.checkFilesButton.UseVisualStyleBackColor = true;
            this.checkFilesButton.Click += new System.EventHandler(this.checkFilesButton_Click);
            // 
            // checkDatabaseButton
            // 
            this.checkDatabaseButton.Location = new System.Drawing.Point(145, 12);
            this.checkDatabaseButton.Name = "checkDatabaseButton";
            this.checkDatabaseButton.Size = new System.Drawing.Size(127, 86);
            this.checkDatabaseButton.TabIndex = 1;
            this.checkDatabaseButton.Text = "Sprawdź bazę danych";
            this.checkDatabaseButton.UseVisualStyleBackColor = true;
            this.checkDatabaseButton.Click += new System.EventHandler(this.checkDatabaseButton_Click);
            // 
            // createNewAccountButton
            // 
            this.createNewAccountButton.Location = new System.Drawing.Point(12, 104);
            this.createNewAccountButton.Name = "createNewAccountButton";
            this.createNewAccountButton.Size = new System.Drawing.Size(127, 86);
            this.createNewAccountButton.TabIndex = 2;
            this.createNewAccountButton.Text = "Utwórz nowe konto";
            this.createNewAccountButton.UseVisualStyleBackColor = true;
            this.createNewAccountButton.Click += new System.EventHandler(this.createNewAccountButton_Click);
            // 
            // modifyAccountButton
            // 
            this.modifyAccountButton.Location = new System.Drawing.Point(145, 104);
            this.modifyAccountButton.Name = "modifyAccountButton";
            this.modifyAccountButton.Size = new System.Drawing.Size(127, 86);
            this.modifyAccountButton.TabIndex = 3;
            this.modifyAccountButton.Text = "Zmodyfikuj istniejące konto";
            this.modifyAccountButton.UseVisualStyleBackColor = true;
            this.modifyAccountButton.Click += new System.EventHandler(this.modifyAccountButton_Click);
            // 
            // deleteAccountButton
            // 
            this.deleteAccountButton.Location = new System.Drawing.Point(12, 196);
            this.deleteAccountButton.Name = "deleteAccountButton";
            this.deleteAccountButton.Size = new System.Drawing.Size(127, 86);
            this.deleteAccountButton.TabIndex = 4;
            this.deleteAccountButton.Text = "Usuń istniejące konto";
            this.deleteAccountButton.UseVisualStyleBackColor = true;
            this.deleteAccountButton.Click += new System.EventHandler(this.deleteAccountButton_Click);
            // 
            // checkLogsButton
            // 
            this.checkLogsButton.Location = new System.Drawing.Point(145, 196);
            this.checkLogsButton.Name = "checkLogsButton";
            this.checkLogsButton.Size = new System.Drawing.Size(127, 86);
            this.checkLogsButton.TabIndex = 5;
            this.checkLogsButton.Text = "Sprawdź logi";
            this.checkLogsButton.UseVisualStyleBackColor = true;
            this.checkLogsButton.Click += new System.EventHandler(this.checkLogsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 288);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(260, 86);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Wyjdź";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // configurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.checkLogsButton);
            this.Controls.Add(this.deleteAccountButton);
            this.Controls.Add(this.modifyAccountButton);
            this.Controls.Add(this.createNewAccountButton);
            this.Controls.Add(this.checkDatabaseButton);
            this.Controls.Add(this.checkFilesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "configurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Konfiguracyjny - System Zarządzania Firmą";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.configurationForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button checkFilesButton;
        private System.Windows.Forms.Button checkDatabaseButton;
        private System.Windows.Forms.Button createNewAccountButton;
        private System.Windows.Forms.Button modifyAccountButton;
        private System.Windows.Forms.Button deleteAccountButton;
        private System.Windows.Forms.Button checkLogsButton;
        private System.Windows.Forms.Button exitButton;
    }
}