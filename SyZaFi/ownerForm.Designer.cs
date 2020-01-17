namespace SyZaFi
{
    partial class ownerForm
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
            this.financesButton = new System.Windows.Forms.Button();
            this.hrButton = new System.Windows.Forms.Button();
            this.logisticsButton = new System.Windows.Forms.Button();
            this.productionButton = new System.Windows.Forms.Button();
            this.exitApplicationButton = new System.Windows.Forms.Button();
            this.restoreEmployeeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // financesButton
            // 
            this.financesButton.Location = new System.Drawing.Point(12, 12);
            this.financesButton.Name = "financesButton";
            this.financesButton.Size = new System.Drawing.Size(260, 45);
            this.financesButton.TabIndex = 0;
            this.financesButton.Text = "Finanse";
            this.financesButton.UseVisualStyleBackColor = true;
            this.financesButton.Click += new System.EventHandler(this.financesButton_Click);
            // 
            // hrButton
            // 
            this.hrButton.Location = new System.Drawing.Point(12, 63);
            this.hrButton.Name = "hrButton";
            this.hrButton.Size = new System.Drawing.Size(260, 45);
            this.hrButton.TabIndex = 1;
            this.hrButton.Text = "HR";
            this.hrButton.UseVisualStyleBackColor = true;
            this.hrButton.Click += new System.EventHandler(this.hrButton_Click);
            // 
            // logisticsButton
            // 
            this.logisticsButton.Location = new System.Drawing.Point(12, 114);
            this.logisticsButton.Name = "logisticsButton";
            this.logisticsButton.Size = new System.Drawing.Size(260, 45);
            this.logisticsButton.TabIndex = 2;
            this.logisticsButton.Text = "Logistyka";
            this.logisticsButton.UseVisualStyleBackColor = true;
            this.logisticsButton.Click += new System.EventHandler(this.logisticsButton_Click);
            // 
            // productionButton
            // 
            this.productionButton.Location = new System.Drawing.Point(12, 165);
            this.productionButton.Name = "productionButton";
            this.productionButton.Size = new System.Drawing.Size(260, 45);
            this.productionButton.TabIndex = 3;
            this.productionButton.Text = "Produkcja";
            this.productionButton.UseVisualStyleBackColor = true;
            this.productionButton.Click += new System.EventHandler(this.productionButton_Click);
            // 
            // exitApplicationButton
            // 
            this.exitApplicationButton.Location = new System.Drawing.Point(12, 338);
            this.exitApplicationButton.Name = "exitApplicationButton";
            this.exitApplicationButton.Size = new System.Drawing.Size(260, 61);
            this.exitApplicationButton.TabIndex = 4;
            this.exitApplicationButton.Text = "Wyjdź";
            this.exitApplicationButton.UseVisualStyleBackColor = true;
            this.exitApplicationButton.Click += new System.EventHandler(this.exitApplicationButton_Click);
            // 
            // restoreEmployeeButton
            // 
            this.restoreEmployeeButton.Location = new System.Drawing.Point(12, 216);
            this.restoreEmployeeButton.Name = "restoreEmployeeButton";
            this.restoreEmployeeButton.Size = new System.Drawing.Size(260, 45);
            this.restoreEmployeeButton.TabIndex = 5;
            this.restoreEmployeeButton.Text = "Przywróć usuniętego pracownika";
            this.restoreEmployeeButton.UseVisualStyleBackColor = true;
            this.restoreEmployeeButton.Click += new System.EventHandler(this.restoreEmployeeButton_Click);
            // 
            // ownerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.restoreEmployeeButton);
            this.Controls.Add(this.exitApplicationButton);
            this.Controls.Add(this.productionButton);
            this.Controls.Add(this.logisticsButton);
            this.Controls.Add(this.hrButton);
            this.Controls.Add(this.financesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ownerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Panel właściciela";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button financesButton;
        private System.Windows.Forms.Button hrButton;
        private System.Windows.Forms.Button logisticsButton;
        private System.Windows.Forms.Button productionButton;
        private System.Windows.Forms.Button exitApplicationButton;
        private System.Windows.Forms.Button restoreEmployeeButton;
    }
}