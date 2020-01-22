namespace SyZaFi
{
    partial class financesForm
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
            this.invoicesButton = new System.Windows.Forms.Button();
            this.financialOperationsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // invoicesButton
            // 
            this.invoicesButton.Location = new System.Drawing.Point(12, 12);
            this.invoicesButton.Name = "invoicesButton";
            this.invoicesButton.Size = new System.Drawing.Size(260, 72);
            this.invoicesButton.TabIndex = 0;
            this.invoicesButton.Text = "Faktury";
            this.invoicesButton.UseVisualStyleBackColor = true;
            this.invoicesButton.Click += new System.EventHandler(this.invoicesButton_Click);
            // 
            // financialOperationsButton
            // 
            this.financialOperationsButton.Location = new System.Drawing.Point(12, 90);
            this.financialOperationsButton.Name = "financialOperationsButton";
            this.financialOperationsButton.Size = new System.Drawing.Size(260, 72);
            this.financialOperationsButton.TabIndex = 2;
            this.financialOperationsButton.Text = "Operacje finansowe";
            this.financialOperationsButton.UseVisualStyleBackColor = true;
            this.financialOperationsButton.Click += new System.EventHandler(this.financialOperationsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 327);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(260, 72);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Wyjście";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // financesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.financialOperationsButton);
            this.Controls.Add(this.invoicesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "financesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Finanse - System Zarządzania Firmą";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button invoicesButton;
        private System.Windows.Forms.Button financialOperationsButton;
        private System.Windows.Forms.Button exitButton;
    }
}