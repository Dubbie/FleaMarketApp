namespace FleaMarketApp.View
{
    partial class OrderSearchView
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
            this.lblInputLabel = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInputLabel
            // 
            this.lblInputLabel.AutoSize = true;
            this.lblInputLabel.Location = new System.Drawing.Point(13, 10);
            this.lblInputLabel.Name = "lblInputLabel";
            this.lblInputLabel.Size = new System.Drawing.Size(118, 13);
            this.lblInputLabel.TabIndex = 0;
            this.lblInputLabel.Text = "Megrendelés azonosító";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(13, 26);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(148, 20);
            this.txtOrderId.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(167, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Keresés";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // OrderSearchView
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 58);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.lblInputLabel);
            this.Name = "OrderSearchView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.Text = "Megrendelés keresése";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderSearchView_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputLabel;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Button btnSearch;
    }
}