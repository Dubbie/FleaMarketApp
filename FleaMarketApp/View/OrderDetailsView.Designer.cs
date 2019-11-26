namespace FleaMarketApp.View
{
    partial class OrderDetailsView
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
            this.lblOrderId = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblOrderedAt = new System.Windows.Forms.Label();
            this.splitDetailsMain = new System.Windows.Forms.SplitContainer();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSellItem = new System.Windows.Forms.Button();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.lblOrderDatePrefix = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitDetailsMain)).BeginInit();
            this.splitDetailsMain.Panel1.SuspendLayout();
            this.splitDetailsMain.Panel2.SuspendLayout();
            this.splitDetailsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOrderId.Location = new System.Drawing.Point(13, 10);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(89, 20);
            this.lblOrderId.TabIndex = 0;
            this.lblOrderId.Text = "Azonosító";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblItemName.Location = new System.Drawing.Point(12, 30);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(227, 25);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "Megrendelt tárgy neve";
            // 
            // lblOrderedAt
            // 
            this.lblOrderedAt.AutoSize = true;
            this.lblOrderedAt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblOrderedAt.Location = new System.Drawing.Point(96, 137);
            this.lblOrderedAt.Name = "lblOrderedAt";
            this.lblOrderedAt.Size = new System.Drawing.Size(106, 13);
            this.lblOrderedAt.TabIndex = 2;
            this.lblOrderedAt.Text = "Megrendelés dátuma";
            // 
            // splitDetailsMain
            // 
            this.splitDetailsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitDetailsMain.IsSplitterFixed = true;
            this.splitDetailsMain.Location = new System.Drawing.Point(0, 0);
            this.splitDetailsMain.Name = "splitDetailsMain";
            // 
            // splitDetailsMain.Panel1
            // 
            this.splitDetailsMain.Panel1.BackColor = System.Drawing.Color.White;
            this.splitDetailsMain.Panel1.Controls.Add(this.btnSellItem);
            this.splitDetailsMain.Panel1.Controls.Add(this.btnCancel);
            this.splitDetailsMain.Panel1.Padding = new System.Windows.Forms.Padding(10);
            this.splitDetailsMain.Panel1MinSize = 150;
            // 
            // splitDetailsMain.Panel2
            // 
            this.splitDetailsMain.Panel2.Controls.Add(this.lblOrderDatePrefix);
            this.splitDetailsMain.Panel2.Controls.Add(this.lblItemPrice);
            this.splitDetailsMain.Panel2.Controls.Add(this.lblOrderId);
            this.splitDetailsMain.Panel2.Controls.Add(this.lblOrderedAt);
            this.splitDetailsMain.Panel2.Controls.Add(this.lblItemName);
            this.splitDetailsMain.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitDetailsMain.Size = new System.Drawing.Size(624, 159);
            this.splitDetailsMain.SplitterDistance = 150;
            this.splitDetailsMain.SplitterWidth = 1;
            this.splitDetailsMain.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancel.Location = new System.Drawing.Point(10, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 28);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Megrendelés törlése";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSellItem
            // 
            this.btnSellItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSellItem.Location = new System.Drawing.Point(10, 38);
            this.btnSellItem.Name = "btnSellItem";
            this.btnSellItem.Size = new System.Drawing.Size(130, 28);
            this.btnSellItem.TabIndex = 1;
            this.btnSellItem.Text = "Tárgy eladása";
            this.btnSellItem.UseVisualStyleBackColor = true;
            this.btnSellItem.Click += new System.EventHandler(this.btnSellItem_Click);
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.AutoSize = true;
            this.lblItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblItemPrice.Location = new System.Drawing.Point(13, 55);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(175, 20);
            this.lblItemPrice.TabIndex = 3;
            this.lblItemPrice.Text = "Megrendelt tárgy ára";
            // 
            // lblOrderDatePrefix
            // 
            this.lblOrderDatePrefix.AutoSize = true;
            this.lblOrderDatePrefix.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblOrderDatePrefix.Location = new System.Drawing.Point(15, 137);
            this.lblOrderDatePrefix.Name = "lblOrderDatePrefix";
            this.lblOrderDatePrefix.Size = new System.Drawing.Size(75, 13);
            this.lblOrderDatePrefix.TabIndex = 4;
            this.lblOrderDatePrefix.Text = "Megrendelve: ";
            // 
            // OrderDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 159);
            this.Controls.Add(this.splitDetailsMain);
            this.Name = "OrderDetailsView";
            this.Text = "Megrendelés adatai";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderDetailsView_FormClosed);
            this.splitDetailsMain.Panel1.ResumeLayout(false);
            this.splitDetailsMain.Panel2.ResumeLayout(false);
            this.splitDetailsMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitDetailsMain)).EndInit();
            this.splitDetailsMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblOrderedAt;
        private System.Windows.Forms.SplitContainer splitDetailsMain;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSellItem;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.Label lblOrderDatePrefix;
    }
}