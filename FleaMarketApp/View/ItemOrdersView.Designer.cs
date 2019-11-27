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
            this.lblTItle = new System.Windows.Forms.Label();
            this.gridItemOrders = new System.Windows.Forms.DataGridView();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orderer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridItemOrders)).BeginInit();
            this.SuspendLayout();
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
            // gridItemOrders
            // 
            this.gridItemOrders.AllowUserToAddRows = false;
            this.gridItemOrders.AllowUserToDeleteRows = false;
            this.gridItemOrders.AllowUserToResizeColumns = false;
            this.gridItemOrders.AllowUserToResizeRows = false;
            this.gridItemOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridItemOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItemOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.ItemName,
            this.OrderedAt,
            this.Orderer,
            this.Sold});
            this.gridItemOrders.Location = new System.Drawing.Point(12, 49);
            this.gridItemOrders.MultiSelect = false;
            this.gridItemOrders.Name = "gridItemOrders";
            this.gridItemOrders.ReadOnly = true;
            this.gridItemOrders.RowHeadersVisible = false;
            this.gridItemOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridItemOrders.Size = new System.Drawing.Size(552, 321);
            this.gridItemOrders.TabIndex = 2;
            this.gridItemOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridItemOrders_CellClick);
            // 
            // OrderId
            // 
            this.OrderId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.OrderId.HeaderText = "Azonosító";
            this.OrderId.Name = "OrderId";
            this.OrderId.ReadOnly = true;
            this.OrderId.Width = 80;
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemName.HeaderText = "Termék neve";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // OrderedAt
            // 
            this.OrderedAt.HeaderText = "Megrendelve";
            this.OrderedAt.Name = "OrderedAt";
            this.OrderedAt.ReadOnly = true;
            this.OrderedAt.Width = 94;
            // 
            // Orderer
            // 
            this.Orderer.HeaderText = "Megrendelő";
            this.Orderer.Name = "Orderer";
            this.Orderer.ReadOnly = true;
            this.Orderer.Width = 88;
            // 
            // Sold
            // 
            this.Sold.HeaderText = "Eladva";
            this.Sold.Name = "Sold";
            this.Sold.ReadOnly = true;
            this.Sold.Width = 65;
            // 
            // ItemOrdersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 382);
            this.Controls.Add(this.gridItemOrders);
            this.Controls.Add(this.lblTItle);
            this.Name = "ItemOrdersView";
            this.ShowIcon = false;
            this.Text = "Megrendelések";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ItemOrdersView_FormClosed);
            this.EnabledChanged += new System.EventHandler(this.ItemOrdersView_EnabledChanged);
            ((System.ComponentModel.ISupportInitialize)(this.gridItemOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTItle;
        private System.Windows.Forms.DataGridView gridItemOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orderer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sold;
    }
}