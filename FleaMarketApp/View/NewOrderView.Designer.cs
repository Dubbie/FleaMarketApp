namespace FleaMarketApp.View
{
    partial class NewOrderView
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.groupPersonalData = new System.Windows.Forms.GroupBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.groupPersonalData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(27, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Név";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(9, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 20);
            this.txtName.TabIndex = 1;
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.Location = new System.Drawing.Point(63, 198);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(97, 23);
            this.btnSaveOrder.TabIndex = 2;
            this.btnSaveOrder.Text = "Megrendelem";
            this.btnSaveOrder.UseVisualStyleBackColor = true;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // groupPersonalData
            // 
            this.groupPersonalData.Controls.Add(this.lblPhone);
            this.groupPersonalData.Controls.Add(this.txtPhone);
            this.groupPersonalData.Controls.Add(this.lblEmail);
            this.groupPersonalData.Controls.Add(this.txtEmail);
            this.groupPersonalData.Controls.Add(this.lblAddress);
            this.groupPersonalData.Controls.Add(this.txtAddress);
            this.groupPersonalData.Controls.Add(this.lblName);
            this.groupPersonalData.Controls.Add(this.txtName);
            this.groupPersonalData.Location = new System.Drawing.Point(13, 13);
            this.groupPersonalData.Name = "groupPersonalData";
            this.groupPersonalData.Size = new System.Drawing.Size(203, 179);
            this.groupPersonalData.TabIndex = 3;
            this.groupPersonalData.TabStop = false;
            this.groupPersonalData.Text = "Személyes Adatok";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(6, 55);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(43, 13);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Lakcím";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(9, 71);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(185, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 94);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(9, 110);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(185, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(6, 133);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(67, 13);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Telefonszám";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(9, 149);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(185, 20);
            this.txtPhone.TabIndex = 7;
            // 
            // NewOrderView
            // 
            this.AcceptButton = this.btnSaveOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 230);
            this.Controls.Add(this.groupPersonalData);
            this.Controls.Add(this.btnSaveOrder);
            this.Name = "NewOrderView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.Text = "Új megrendelés";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewOrderView_FormClosed);
            this.groupPersonalData.ResumeLayout(false);
            this.groupPersonalData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.GroupBox groupPersonalData;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
    }
}