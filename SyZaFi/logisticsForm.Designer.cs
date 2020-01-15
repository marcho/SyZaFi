namespace SyZaFi
{
    partial class logisticsForm
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
            this.inventoryButton = new System.Windows.Forms.Button();
            this.ordersButton = new System.Windows.Forms.Button();
            this.exitApplicationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inventoryButton
            // 
            this.inventoryButton.Location = new System.Drawing.Point(12, 12);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(260, 107);
            this.inventoryButton.TabIndex = 0;
            this.inventoryButton.Text = "Magazyny";
            this.inventoryButton.UseVisualStyleBackColor = true;
            this.inventoryButton.Click += new System.EventHandler(this.inventoryButton_Click);
            // 
            // ordersButton
            // 
            this.ordersButton.Location = new System.Drawing.Point(12, 125);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(260, 107);
            this.ordersButton.TabIndex = 1;
            this.ordersButton.Text = "Zamówienia";
            this.ordersButton.UseVisualStyleBackColor = true;
            this.ordersButton.Click += new System.EventHandler(this.ordersButton_Click);
            // 
            // exitApplicationButton
            // 
            this.exitApplicationButton.Location = new System.Drawing.Point(12, 292);
            this.exitApplicationButton.Name = "exitApplicationButton";
            this.exitApplicationButton.Size = new System.Drawing.Size(260, 107);
            this.exitApplicationButton.TabIndex = 2;
            this.exitApplicationButton.Text = "Wyjdź";
            this.exitApplicationButton.UseVisualStyleBackColor = true;
            this.exitApplicationButton.Click += new System.EventHandler(this.exitApplicationButton_Click);
            // 
            // logisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.exitApplicationButton);
            this.Controls.Add(this.ordersButton);
            this.Controls.Add(this.inventoryButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "logisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logistyka";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button inventoryButton;
        private System.Windows.Forms.Button ordersButton;
        private System.Windows.Forms.Button exitApplicationButton;
    }
}