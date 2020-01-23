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
            this.createNewAccountButton = new System.Windows.Forms.Button();
            this.modifyAccountButton = new System.Windows.Forms.Button();
            this.deleteAccountButton = new System.Windows.Forms.Button();
            this.checkLogsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.modifyCompanyDetailsButton = new System.Windows.Forms.Button();
            this.modifyFilesServerLocalisationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createNewAccountButton
            // 
            this.createNewAccountButton.Location = new System.Drawing.Point(12, 12);
            this.createNewAccountButton.Name = "createNewAccountButton";
            this.createNewAccountButton.Size = new System.Drawing.Size(127, 86);
            this.createNewAccountButton.TabIndex = 2;
            this.createNewAccountButton.Text = "Utwórz nowe konto";
            this.createNewAccountButton.UseVisualStyleBackColor = true;
            this.createNewAccountButton.Click += new System.EventHandler(this.createNewAccountButton_Click);
            // 
            // modifyAccountButton
            // 
            this.modifyAccountButton.Location = new System.Drawing.Point(145, 12);
            this.modifyAccountButton.Name = "modifyAccountButton";
            this.modifyAccountButton.Size = new System.Drawing.Size(127, 86);
            this.modifyAccountButton.TabIndex = 3;
            this.modifyAccountButton.Text = "Zmodyfikuj istniejące konto";
            this.modifyAccountButton.UseVisualStyleBackColor = true;
            this.modifyAccountButton.Click += new System.EventHandler(this.modifyAccountButton_Click);
            // 
            // deleteAccountButton
            // 
            this.deleteAccountButton.Location = new System.Drawing.Point(12, 104);
            this.deleteAccountButton.Name = "deleteAccountButton";
            this.deleteAccountButton.Size = new System.Drawing.Size(127, 86);
            this.deleteAccountButton.TabIndex = 4;
            this.deleteAccountButton.Text = "Usuń istniejące konto";
            this.deleteAccountButton.UseVisualStyleBackColor = true;
            this.deleteAccountButton.Click += new System.EventHandler(this.deleteAccountButton_Click);
            // 
            // checkLogsButton
            // 
            this.checkLogsButton.Location = new System.Drawing.Point(145, 104);
            this.checkLogsButton.Name = "checkLogsButton";
            this.checkLogsButton.Size = new System.Drawing.Size(127, 86);
            this.checkLogsButton.TabIndex = 5;
            this.checkLogsButton.Text = "Sprawdź logi";
            this.checkLogsButton.UseVisualStyleBackColor = true;
            this.checkLogsButton.Click += new System.EventHandler(this.checkLogsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 313);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(260, 86);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Wyjdź";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // modifyCompanyDetailsButton
            // 
            this.modifyCompanyDetailsButton.Location = new System.Drawing.Point(12, 196);
            this.modifyCompanyDetailsButton.Name = "modifyCompanyDetailsButton";
            this.modifyCompanyDetailsButton.Size = new System.Drawing.Size(127, 86);
            this.modifyCompanyDetailsButton.TabIndex = 8;
            this.modifyCompanyDetailsButton.Text = "Zmodyfikuj informacje o firmie";
            this.modifyCompanyDetailsButton.UseVisualStyleBackColor = true;
            this.modifyCompanyDetailsButton.Click += new System.EventHandler(this.modifyCompanyDetailsButton_Click);
            // 
            // modifyFilesServerLocalisationButton
            // 
            this.modifyFilesServerLocalisationButton.Location = new System.Drawing.Point(145, 196);
            this.modifyFilesServerLocalisationButton.Name = "modifyFilesServerLocalisationButton";
            this.modifyFilesServerLocalisationButton.Size = new System.Drawing.Size(127, 86);
            this.modifyFilesServerLocalisationButton.TabIndex = 9;
            this.modifyFilesServerLocalisationButton.Text = "Zmień lokalizację serwera plików";
            this.modifyFilesServerLocalisationButton.UseVisualStyleBackColor = true;
            // 
            // configurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.modifyFilesServerLocalisationButton);
            this.Controls.Add(this.modifyCompanyDetailsButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.checkLogsButton);
            this.Controls.Add(this.deleteAccountButton);
            this.Controls.Add(this.modifyAccountButton);
            this.Controls.Add(this.createNewAccountButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "configurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Konfiguracyjny - System Zarządzania Firmą";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.configurationForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button createNewAccountButton;
        private System.Windows.Forms.Button modifyAccountButton;
        private System.Windows.Forms.Button deleteAccountButton;
        private System.Windows.Forms.Button checkLogsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button modifyCompanyDetailsButton;
        private System.Windows.Forms.Button modifyFilesServerLocalisationButton;
    }
}