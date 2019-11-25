namespace FleaMarketApp.View
{
    partial class ItemOrdersView
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
            this.listItemOrders = new System.Windows.Forms.ListBox();
            this.lblTItle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listItemOrders
            // 
            this.listItemOrders.FormattingEnabled = true;
            this.listItemOrders.Location = new System.Drawing.Point(19, 62);
            this.listItemOrders.Name = "listItemOrders";
            this.listItemOrders.Size = new System.Drawing.Size(536, 303);
            this.listItemOrders.TabIndex = 0;
            this.listItemOrders.SelectedIndexChanged += new System.EventHandler(this.ListItemOrders_SelectedIndexChanged);
            // 
            // lblTItle
            // 
            this.lblTItle.AutoSize = true;
            this.lblTItle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTItle.Location = new System.Drawing.Point(12, 9);
            this.lblTItle.Name = "lblTItle";
            this.lblTItle.Size = new System.Drawing.Size(245, 37);
            this.lblTItle.TabIndex = 1;
            this.lblTItle.Text = "Megrendelések";
            // 
            // ItemOrdersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 382);
            this.Controls.Add(this.lblTItle);
            this.Controls.Add(this.listItemOrders);
            this.Name = "ItemOrdersView";
            this.Text = "Megrendelések";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ItemOrdersView_FormClosed);
            this.EnabledChanged += new System.EventHandler(this.ItemOrdersView_EnabledChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listItemOrders;
        private System.Windows.Forms.Label lblTItle;
    }
}