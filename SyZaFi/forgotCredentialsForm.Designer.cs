namespace SyZaFi
{
    partial class forgotCredentialsForm
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
            this.forgotLoginButton = new System.Windows.Forms.Button();
            this.forgotPasswordButton = new System.Windows.Forms.Button();
            this.forgotBothButton = new System.Windows.Forms.Button();
            this.returnToLoginButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // forgotLoginButton
            // 
            this.forgotLoginButton.Location = new System.Drawing.Point(12, 12);
            this.forgotLoginButton.Name = "forgotLoginButton";
            this.forgotLoginButton.Size = new System.Drawing.Size(260, 66);
            this.forgotLoginButton.TabIndex = 0;
            this.forgotLoginButton.Text = "Zapomniany login";
            this.forgotLoginButton.UseVisualStyleBackColor = true;
            this.forgotLoginButton.Click += new System.EventHandler(this.forgotLoginButton_Click);
            // 
            // forgotPasswordButton
            // 
            this.forgotPasswordButton.Location = new System.Drawing.Point(12, 84);
            this.forgotPasswordButton.Name = "forgotPasswordButton";
            this.forgotPasswordButton.Size = new System.Drawing.Size(260, 66);
            this.forgotPasswordButton.TabIndex = 1;
            this.forgotPasswordButton.Text = "Zapomniane hasło";
            this.forgotPasswordButton.UseVisualStyleBackColor = true;
            this.forgotPasswordButton.Click += new System.EventHandler(this.forgotPasswordButton_Click);
            // 
            // forgotBothButton
            // 
            this.forgotBothButton.Location = new System.Drawing.Point(12, 156);
            this.forgotBothButton.Name = "forgotBothButton";
            this.forgotBothButton.Size = new System.Drawing.Size(260, 66);
            this.forgotBothButton.TabIndex = 2;
            this.forgotBothButton.Text = "Zapomniany login i hasło";
            this.forgotBothButton.UseVisualStyleBackColor = true;
            this.forgotBothButton.Click += new System.EventHandler(this.forgotBothButton_Click);
            // 
            // returnToLoginButton
            // 
            this.returnToLoginButton.Location = new System.Drawing.Point(12, 347);
            this.returnToLoginButton.Name = "returnToLoginButton";
            this.returnToLoginButton.Size = new System.Drawing.Size(260, 23);
            this.returnToLoginButton.TabIndex = 3;
            this.returnToLoginButton.Text = "Powrót do logowania";
            this.returnToLoginButton.UseVisualStyleBackColor = true;
            this.returnToLoginButton.Click += new System.EventHandler(this.returnToLoginButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 376);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(260, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Wyjście";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // forgotCredentialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.returnToLoginButton);
            this.Controls.Add(this.forgotBothButton);
            this.Controls.Add(this.forgotPasswordButton);
            this.Controls.Add(this.forgotLoginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "forgotCredentialsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Przypomnij dane";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button forgotLoginButton;
        private System.Windows.Forms.Button forgotPasswordButton;
        private System.Windows.Forms.Button forgotBothButton;
        private System.Windows.Forms.Button returnToLoginButton;
        private System.Windows.Forms.Button exitButton;
    }
}