namespace SyZaFi
{
    partial class productionPlanForm
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
            this.planListBox = new System.Windows.Forms.ListBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteProductionButton = new System.Windows.Forms.Button();
            this.modifyProductionButton = new System.Windows.Forms.Button();
            this.addNewProductionButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // planListBox
            // 
            this.planListBox.FormattingEnabled = true;
            this.planListBox.Location = new System.Drawing.Point(12, 12);
            this.planListBox.Name = "planListBox";
            this.planListBox.Size = new System.Drawing.Size(260, 95);
            this.planListBox.TabIndex = 0;
            this.planListBox.SelectedIndexChanged += new System.EventHandler(this.planListBox_SelectedIndexChanged);
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(172, 191);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateTextBox.TabIndex = 1;
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(172, 165);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(100, 20);
            this.positionTextBox.TabIndex = 2;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(172, 139);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 3;
            // 
            // itemTextBox
            // 
            this.itemTextBox.Location = new System.Drawing.Point(172, 113);
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Przedmiot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kiedy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gdzie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ilość";
            // 
            // deleteProductionButton
            // 
            this.deleteProductionButton.Location = new System.Drawing.Point(116, 275);
            this.deleteProductionButton.Name = "deleteProductionButton";
            this.deleteProductionButton.Size = new System.Drawing.Size(156, 23);
            this.deleteProductionButton.TabIndex = 9;
            this.deleteProductionButton.Text = "Usuń pozycję";
            this.deleteProductionButton.UseVisualStyleBackColor = true;
            this.deleteProductionButton.Click += new System.EventHandler(this.deleteProductionButton_Click);
            // 
            // modifyProductionButton
            // 
            this.modifyProductionButton.Location = new System.Drawing.Point(116, 246);
            this.modifyProductionButton.Name = "modifyProductionButton";
            this.modifyProductionButton.Size = new System.Drawing.Size(156, 23);
            this.modifyProductionButton.TabIndex = 10;
            this.modifyProductionButton.Text = "Modyfikuj pozycję";
            this.modifyProductionButton.UseVisualStyleBackColor = true;
            this.modifyProductionButton.Click += new System.EventHandler(this.modifyProductionButton_Click);
            // 
            // addNewProductionButton
            // 
            this.addNewProductionButton.Location = new System.Drawing.Point(116, 217);
            this.addNewProductionButton.Name = "addNewProductionButton";
            this.addNewProductionButton.Size = new System.Drawing.Size(156, 23);
            this.addNewProductionButton.TabIndex = 11;
            this.addNewProductionButton.Text = "Dodaj nową pozycję";
            this.addNewProductionButton.UseVisualStyleBackColor = true;
            this.addNewProductionButton.Click += new System.EventHandler(this.addNewProductionButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(12, 347);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(260, 23);
            this.returnButton.TabIndex = 12;
            this.returnButton.Text = "Wróć";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 376);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(260, 23);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Wyjdź";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // productionPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.addNewProductionButton);
            this.Controls.Add(this.modifyProductionButton);
            this.Controls.Add(this.deleteProductionButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.planListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "productionPlanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Plan produkcji";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox planListBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deleteProductionButton;
        private System.Windows.Forms.Button modifyProductionButton;
        private System.Windows.Forms.Button addNewProductionButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button exitButton;
    }
}