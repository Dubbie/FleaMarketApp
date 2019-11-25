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
            ((System.ComponentModel.ISupportInitialize)(this.splitDetailsMain)).BeginInit();
            this.splitDetailsMain.Panel1.SuspendLayout();
            this.splitDetailsMain.Panel2.SuspendLayout();
            this.splitDetailsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(15, 9);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(55, 13);
            this.lblOrderId.TabIndex = 0;
            this.lblOrderId.Text = "Azonosító";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblItemName.Location = new System.Drawing.Point(15, 39);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(227, 25);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "Megrendelt tárgy neve";
            // 
            // lblOrderedAt
            // 
            this.lblOrderedAt.AutoSize = true;
            this.lblOrderedAt.Location = new System.Drawing.Point(17, 82);
            this.lblOrderedAt.Name = "lblOrderedAt";
            this.lblOrderedAt.Size = new System.Drawing.Size(106, 13);
            this.lblOrderedAt.TabIndex = 2;
            this.lblOrderedAt.Text = "Megrendelés dátuma";
            // 
            // splitDetailsMain
            // 
            this.splitDetailsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitDetailsMain.Location = new System.Drawing.Point(0, 0);
            this.splitDetailsMain.Name = "splitDetailsMain";
            // 
            // splitDetailsMain.Panel1
            // 
            this.splitDetailsMain.Panel1.Controls.Add(this.btnCancel);
            // 
            // splitDetailsMain.Panel2
            // 
            this.splitDetailsMain.Panel2.Controls.Add(this.lblOrderId);
            this.splitDetailsMain.Panel2.Controls.Add(this.lblOrderedAt);
            this.splitDetailsMain.Panel2.Controls.Add(this.lblItemName);
            this.splitDetailsMain.Size = new System.Drawing.Size(624, 441);
            this.splitDetailsMain.SplitterDistance = 156;
            this.splitDetailsMain.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancel.Location = new System.Drawing.Point(0, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(156, 28);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Megrendelés törlése";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // OrderDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
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
    }
}