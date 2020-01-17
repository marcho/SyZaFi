namespace SyZaFi
{
    partial class deleteAccountForm
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
            this.existingAccountsListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.deleteAccountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // existingAccountsListBox
            // 
            this.existingAccountsListBox.FormattingEnabled = true;
            this.existingAccountsListBox.Location = new System.Drawing.Point(12, 12);
            this.existingAccountsListBox.Name = "existingAccountsListBox";
            this.existingAccountsListBox.Size = new System.Drawing.Size(260, 108);
            this.existingAccountsListBox.TabIndex = 4;
            this.existingAccountsListBox.SelectedIndexChanged += new System.EventHandler(this.existingAccountsListBox_SelectedIndexChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 376);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(260, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Wyjdź";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
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
            // deleteAccountButton
            // 
            this.deleteAccountButton.Location = new System.Drawing.Point(12, 318);
            this.deleteAccountButton.Name = "deleteAccountButton";
            this.deleteAccountButton.Size = new System.Drawing.Size(260, 23);
            this.deleteAccountButton.TabIndex = 7;
            this.deleteAccountButton.Text = "Usuń konto";
            this.deleteAccountButton.UseVisualStyleBackColor = true;
            this.deleteAccountButton.Click += new System.EventHandler(this.deleteAccountButton_Click);
            // 
            // deleteAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.deleteAccountButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.existingAccountsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "deleteAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Usuń istniejące konto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox existingAccountsListBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button deleteAccountButton;
    }
}