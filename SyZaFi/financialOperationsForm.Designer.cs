namespace SyZaFi
{
    partial class financialOperationsForm
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
            this.financialOperationsListBox = new System.Windows.Forms.ListBox();
            this.receiverTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.removeOperationButton = new System.Windows.Forms.Button();
            this.addOperationButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // financialOperationsListBox
            // 
            this.financialOperationsListBox.FormattingEnabled = true;
            this.financialOperationsListBox.Location = new System.Drawing.Point(12, 12);
            this.financialOperationsListBox.Name = "financialOperationsListBox";
            this.financialOperationsListBox.Size = new System.Drawing.Size(208, 147);
            this.financialOperationsListBox.TabIndex = 0;
            this.financialOperationsListBox.SelectedIndexChanged += new System.EventHandler(this.financialOperationsListBox_SelectedIndexChanged);
            // 
            // receiverTextBox
            // 
            this.receiverTextBox.Location = new System.Drawing.Point(472, 12);
            this.receiverTextBox.Name = "receiverTextBox";
            this.receiverTextBox.Size = new System.Drawing.Size(100, 20);
            this.receiverTextBox.TabIndex = 1;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(472, 64);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.categoryTextBox.TabIndex = 2;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(472, 38);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Odbiorca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kategoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wartość";
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(12, 347);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(560, 23);
            this.returnButton.TabIndex = 7;
            this.returnButton.Text = "Wróć";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // removeOperationButton
            // 
            this.removeOperationButton.Location = new System.Drawing.Point(12, 318);
            this.removeOperationButton.Name = "removeOperationButton";
            this.removeOperationButton.Size = new System.Drawing.Size(560, 23);
            this.removeOperationButton.TabIndex = 8;
            this.removeOperationButton.Text = "Usuń operację";
            this.removeOperationButton.UseVisualStyleBackColor = true;
            this.removeOperationButton.Click += new System.EventHandler(this.removeOperationButton_Click);
            // 
            // addOperationButton
            // 
            this.addOperationButton.Location = new System.Drawing.Point(12, 289);
            this.addOperationButton.Name = "addOperationButton";
            this.addOperationButton.Size = new System.Drawing.Size(560, 23);
            this.addOperationButton.TabIndex = 9;
            this.addOperationButton.Text = "Dodaj operację";
            this.addOperationButton.UseVisualStyleBackColor = true;
            this.addOperationButton.Click += new System.EventHandler(this.addOperationButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 376);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(560, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Wyjdź";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // financialOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addOperationButton);
            this.Controls.Add(this.removeOperationButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.receiverTextBox);
            this.Controls.Add(this.financialOperationsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "financialOperationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Operacje finansowe";
            this.Activated += new System.EventHandler(this.financialOperationsForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox financialOperationsListBox;
        private System.Windows.Forms.TextBox receiverTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button removeOperationButton;
        private System.Windows.Forms.Button addOperationButton;
        private System.Windows.Forms.Button exitButton;
    }
}