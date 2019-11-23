namespace FleaMarketApp.View
{
    partial class NewItemView
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
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.lblItemDescription = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(9, 9);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(68, 13);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "Megnevezés";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(12, 25);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(264, 20);
            this.txtItemName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(108, 259);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Mentés";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Location = new System.Drawing.Point(12, 64);
            this.txtItemDescription.Multiline = true;
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(264, 75);
            this.txtItemDescription.TabIndex = 2;
            // 
            // lblItemDescription
            // 
            this.lblItemDescription.AutoSize = true;
            this.lblItemDescription.Location = new System.Drawing.Point(9, 48);
            this.lblItemDescription.Name = "lblItemDescription";
            this.lblItemDescription.Size = new System.Drawing.Size(37, 13);
            this.lblItemDescription.TabIndex = 3;
            this.lblItemDescription.Text = "Leírás";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrice.Location = new System.Drawing.Point(12, 198);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(212, 44);
            this.txtPrice.TabIndex = 4;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 182);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(17, 13);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Ár";
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCurrency.Location = new System.Drawing.Point(230, 201);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(46, 37);
            this.lblCurrency.TabIndex = 7;
            this.lblCurrency.Text = "Ft";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(9, 142);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Kategória";
            // 
            // comboCategory
            // 
            this.comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(12, 158);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(264, 21);
            this.comboCategory.TabIndex = 3;
            // 
            // NewItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 294);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtItemDescription);
            this.Controls.Add(this.lblItemDescription);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.lblItemName);
            this.Name = "NewItemView";
            this.Text = "Új tárgy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewItemView_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.Label lblItemDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox comboCategory;
    }
}