namespace FleaMarketApp.View
{
    partial class OfferItemView
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
            this.btnOffer = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblInputLabel = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOffer
            // 
            this.btnOffer.Location = new System.Drawing.Point(207, 31);
            this.btnOffer.Name = "btnOffer";
            this.btnOffer.Size = new System.Drawing.Size(113, 23);
            this.btnOffer.TabIndex = 5;
            this.btnOffer.Text = "Eladásra bocsájtom";
            this.btnOffer.UseVisualStyleBackColor = true;
            this.btnOffer.Click += new System.EventHandler(this.BtnOffer_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrice.Location = new System.Drawing.Point(13, 26);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(151, 31);
            this.txtPrice.TabIndex = 4;
            // 
            // lblInputLabel
            // 
            this.lblInputLabel.AutoSize = true;
            this.lblInputLabel.Location = new System.Drawing.Point(13, 10);
            this.lblInputLabel.Name = "lblInputLabel";
            this.lblInputLabel.Size = new System.Drawing.Size(61, 13);
            this.lblInputLabel.TabIndex = 3;
            this.lblInputLabel.Text = "Termék ára";
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCurrency.Location = new System.Drawing.Point(170, 29);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(31, 25);
            this.lblCurrency.TabIndex = 6;
            this.lblCurrency.Text = "Ft";
            // 
            // OfferItemView
            // 
            this.AcceptButton = this.btnOffer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 67);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.btnOffer);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblInputLabel);
            this.Name = "OfferItemView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.Text = "Termék eladásra bocsájtása";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OfferItemView_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOffer;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblInputLabel;
        private System.Windows.Forms.Label lblCurrency;
    }
}