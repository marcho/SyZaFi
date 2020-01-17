namespace SyZaFi
{
    partial class productionForm
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
            this.ordersButton = new System.Windows.Forms.Button();
            this.productionPlanButton = new System.Windows.Forms.Button();
            this.exitApplicationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ordersButton
            // 
            this.ordersButton.Location = new System.Drawing.Point(12, 12);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(260, 101);
            this.ordersButton.TabIndex = 0;
            this.ordersButton.Text = "Zamówienia";
            this.ordersButton.UseVisualStyleBackColor = true;
            this.ordersButton.Click += new System.EventHandler(this.ordersButton_Click);
            // 
            // productionPlanButton
            // 
            this.productionPlanButton.Location = new System.Drawing.Point(12, 119);
            this.productionPlanButton.Name = "productionPlanButton";
            this.productionPlanButton.Size = new System.Drawing.Size(260, 101);
            this.productionPlanButton.TabIndex = 1;
            this.productionPlanButton.Text = "Plan produkcji";
            this.productionPlanButton.UseVisualStyleBackColor = true;
            this.productionPlanButton.Click += new System.EventHandler(this.productionPlanButton_Click);
            // 
            // exitApplicationButton
            // 
            this.exitApplicationButton.Location = new System.Drawing.Point(12, 298);
            this.exitApplicationButton.Name = "exitApplicationButton";
            this.exitApplicationButton.Size = new System.Drawing.Size(260, 101);
            this.exitApplicationButton.TabIndex = 2;
            this.exitApplicationButton.Text = "Wyjdź";
            this.exitApplicationButton.UseVisualStyleBackColor = true;
            this.exitApplicationButton.Click += new System.EventHandler(this.exitApplicationButton_Click);
            // 
            // productionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.exitApplicationButton);
            this.Controls.Add(this.productionPlanButton);
            this.Controls.Add(this.ordersButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "productionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Produkcja";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ordersButton;
        private System.Windows.Forms.Button productionPlanButton;
        private System.Windows.Forms.Button exitApplicationButton;
    }
}