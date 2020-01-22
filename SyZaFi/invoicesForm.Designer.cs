namespace SyZaFi
{
    partial class invoicesForm
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
            this.invoicesListBox = new System.Windows.Forms.ListBox();
            this.addInvoiceButton = new System.Windows.Forms.Button();
            this.removeInvoiceButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.openInvoiceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // invoicesListBox
            // 
            this.invoicesListBox.FormattingEnabled = true;
            this.invoicesListBox.Location = new System.Drawing.Point(12, 12);
            this.invoicesListBox.Name = "invoicesListBox";
            this.invoicesListBox.Size = new System.Drawing.Size(260, 95);
            this.invoicesListBox.TabIndex = 0;
            // 
            // addInvoiceButton
            // 
            this.addInvoiceButton.Location = new System.Drawing.Point(12, 289);
            this.addInvoiceButton.Name = "addInvoiceButton";
            this.addInvoiceButton.Size = new System.Drawing.Size(260, 23);
            this.addInvoiceButton.TabIndex = 1;
            this.addInvoiceButton.Text = "Dodaj fakturę";
            this.addInvoiceButton.UseVisualStyleBackColor = true;
            this.addInvoiceButton.Click += new System.EventHandler(this.addInvoiceButton_Click);
            // 
            // removeInvoiceButton
            // 
            this.removeInvoiceButton.Location = new System.Drawing.Point(12, 318);
            this.removeInvoiceButton.Name = "removeInvoiceButton";
            this.removeInvoiceButton.Size = new System.Drawing.Size(260, 23);
            this.removeInvoiceButton.TabIndex = 2;
            this.removeInvoiceButton.Text = "Usuń fakturę";
            this.removeInvoiceButton.UseVisualStyleBackColor = true;
            this.removeInvoiceButton.Click += new System.EventHandler(this.removeInvoiceButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(12, 347);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(260, 23);
            this.returnButton.TabIndex = 3;
            this.returnButton.Text = "Wróć";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 376);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(260, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Wyjdź";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // openInvoiceButton
            // 
            this.openInvoiceButton.Location = new System.Drawing.Point(12, 260);
            this.openInvoiceButton.Name = "openInvoiceButton";
            this.openInvoiceButton.Size = new System.Drawing.Size(260, 23);
            this.openInvoiceButton.TabIndex = 5;
            this.openInvoiceButton.Text = "Otwórz fakturę";
            this.openInvoiceButton.UseVisualStyleBackColor = true;
            this.openInvoiceButton.Click += new System.EventHandler(this.openInvoiceButton_Click);
            // 
            // invoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.openInvoiceButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.removeInvoiceButton);
            this.Controls.Add(this.addInvoiceButton);
            this.Controls.Add(this.invoicesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "invoicesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Faktury";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox invoicesListBox;
        private System.Windows.Forms.Button addInvoiceButton;
        private System.Windows.Forms.Button removeInvoiceButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button openInvoiceButton;
    }
}