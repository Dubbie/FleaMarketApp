﻿namespace FleaMarketApp
{
    partial class MainMarketView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.lblDetailItemPrice = new System.Windows.Forms.Label();
            this.lblDetailItemDescription = new System.Windows.Forms.Label();
            this.lblDetailItemName = new System.Windows.Forms.Label();
            this.lblDetailItemId = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnShowList = new System.Windows.Forms.Button();
            this.lblMainMarketTitle = new System.Windows.Forms.Label();
            this.listItems = new System.Windows.Forms.ListBox();
            this.lblFilterItemId = new System.Windows.Forms.Label();
            this.txtFilterItemId = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblFilterItemName = new System.Windows.Forms.Label();
            this.txtFilterItemName = new System.Windows.Forms.TextBox();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelDetails.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.lblDetails, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblList, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFilter, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelSidebar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMainMarketTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelFilters, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.listItems, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelDetails, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 411);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelDetails
            // 
            this.panelDetails.Controls.Add(this.lblDetailItemPrice);
            this.panelDetails.Controls.Add(this.lblDetailItemDescription);
            this.panelDetails.Controls.Add(this.lblDetailItemName);
            this.panelDetails.Controls.Add(this.lblDetailItemId);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetails.Location = new System.Drawing.Point(664, 60);
            this.panelDetails.Margin = new System.Windows.Forms.Padding(10);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(210, 341);
            this.panelDetails.TabIndex = 1;
            this.panelDetails.Visible = false;
            // 
            // lblDetailItemPrice
            // 
            this.lblDetailItemPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDetailItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDetailItemPrice.Location = new System.Drawing.Point(0, 130);
            this.lblDetailItemPrice.Margin = new System.Windows.Forms.Padding(0);
            this.lblDetailItemPrice.Name = "lblDetailItemPrice";
            this.lblDetailItemPrice.Size = new System.Drawing.Size(210, 30);
            this.lblDetailItemPrice.TabIndex = 7;
            this.lblDetailItemPrice.Text = "Ár";
            // 
            // lblDetailItemDescription
            // 
            this.lblDetailItemDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDetailItemDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDetailItemDescription.Location = new System.Drawing.Point(0, 45);
            this.lblDetailItemDescription.Margin = new System.Windows.Forms.Padding(0);
            this.lblDetailItemDescription.Name = "lblDetailItemDescription";
            this.lblDetailItemDescription.Size = new System.Drawing.Size(210, 85);
            this.lblDetailItemDescription.TabIndex = 6;
            this.lblDetailItemDescription.Text = "Leírás";
            // 
            // lblDetailItemName
            // 
            this.lblDetailItemName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDetailItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDetailItemName.Location = new System.Drawing.Point(0, 16);
            this.lblDetailItemName.Margin = new System.Windows.Forms.Padding(0);
            this.lblDetailItemName.Name = "lblDetailItemName";
            this.lblDetailItemName.Size = new System.Drawing.Size(210, 29);
            this.lblDetailItemName.TabIndex = 5;
            this.lblDetailItemName.Text = "Termék megnevezés";
            // 
            // lblDetailItemId
            // 
            this.lblDetailItemId.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDetailItemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDetailItemId.Location = new System.Drawing.Point(0, 0);
            this.lblDetailItemId.Margin = new System.Windows.Forms.Padding(0);
            this.lblDetailItemId.Name = "lblDetailItemId";
            this.lblDetailItemId.Size = new System.Drawing.Size(210, 16);
            this.lblDetailItemId.TabIndex = 4;
            this.lblDetailItemId.Text = "Azonosító";
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.White;
            this.panelSidebar.Controls.Add(this.btnShowList);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(0);
            this.panelSidebar.Name = "panelSidebar";
            this.tableLayoutPanel1.SetRowSpan(this.panelSidebar, 3);
            this.panelSidebar.Size = new System.Drawing.Size(200, 411);
            this.panelSidebar.TabIndex = 1;
            // 
            // btnShowList
            // 
            this.btnShowList.Location = new System.Drawing.Point(3, 3);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(194, 33);
            this.btnShowList.TabIndex = 0;
            this.btnShowList.Text = "Tárgyak";
            this.btnShowList.UseVisualStyleBackColor = true;
            // 
            // lblMainMarketTitle
            // 
            this.lblMainMarketTitle.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblMainMarketTitle, 3);
            this.lblMainMarketTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMainMarketTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMainMarketTitle.Location = new System.Drawing.Point(205, 0);
            this.lblMainMarketTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMainMarketTitle.Name = "lblMainMarketTitle";
            this.lblMainMarketTitle.Size = new System.Drawing.Size(674, 30);
            this.lblMainMarketTitle.TabIndex = 4;
            this.lblMainMarketTitle.Text = "Tárgyak";
            this.lblMainMarketTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listItems
            // 
            this.listItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listItems.FormattingEnabled = true;
            this.listItems.Location = new System.Drawing.Point(437, 60);
            this.listItems.Margin = new System.Windows.Forms.Padding(10);
            this.listItems.Name = "listItems";
            this.listItems.Size = new System.Drawing.Size(207, 341);
            this.listItems.TabIndex = 2;
            this.listItems.SelectedIndexChanged += new System.EventHandler(this.listItems_SelectedIndexChanged);
            // 
            // lblFilterItemId
            // 
            this.lblFilterItemId.AutoSize = true;
            this.lblFilterItemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFilterItemId.Location = new System.Drawing.Point(3, 3);
            this.lblFilterItemId.Name = "lblFilterItemId";
            this.lblFilterItemId.Size = new System.Drawing.Size(64, 13);
            this.lblFilterItemId.TabIndex = 0;
            this.lblFilterItemId.Text = "Azonosító";
            // 
            // txtFilterItemId
            // 
            this.txtFilterItemId.Location = new System.Drawing.Point(3, 19);
            this.txtFilterItemId.Name = "txtFilterItemId";
            this.txtFilterItemId.Size = new System.Drawing.Size(201, 20);
            this.txtFilterItemId.TabIndex = 1;
            // 
            // btnFilter
            // 
            this.btnFilter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFilter.Location = new System.Drawing.Point(0, 318);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(207, 23);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Szűrés";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblFilterItemName
            // 
            this.lblFilterItemName.AutoSize = true;
            this.lblFilterItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFilterItemName.Location = new System.Drawing.Point(3, 42);
            this.lblFilterItemName.Name = "lblFilterItemName";
            this.lblFilterItemName.Size = new System.Drawing.Size(78, 13);
            this.lblFilterItemName.TabIndex = 4;
            this.lblFilterItemName.Text = "Megnevezés";
            // 
            // txtFilterItemName
            // 
            this.txtFilterItemName.Location = new System.Drawing.Point(3, 58);
            this.txtFilterItemName.Name = "txtFilterItemName";
            this.txtFilterItemName.Size = new System.Drawing.Size(201, 20);
            this.txtFilterItemName.TabIndex = 5;
            // 
            // panelFilters
            // 
            this.panelFilters.Controls.Add(this.txtFilterItemName);
            this.panelFilters.Controls.Add(this.lblFilterItemName);
            this.panelFilters.Controls.Add(this.btnFilter);
            this.panelFilters.Controls.Add(this.txtFilterItemId);
            this.panelFilters.Controls.Add(this.lblFilterItemId);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFilters.Location = new System.Drawing.Point(210, 60);
            this.panelFilters.Margin = new System.Windows.Forms.Padding(10);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(207, 341);
            this.panelFilters.TabIndex = 3;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFilter.Location = new System.Drawing.Point(210, 30);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(207, 20);
            this.lblFilter.TabIndex = 5;
            this.lblFilter.Text = "Szűrés";
            this.lblFilter.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblList.Location = new System.Drawing.Point(437, 30);
            this.lblList.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(207, 20);
            this.lblList.TabIndex = 6;
            this.lblList.Text = "Tárgylista";
            this.lblList.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDetails.Location = new System.Drawing.Point(664, 30);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(210, 20);
            this.lblDetails.TabIndex = 7;
            this.lblDetails.Text = "Részletek";
            this.lblDetails.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblDetails.Visible = false;
            // 
            // MainMarketView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainMarketView";
            this.Text = "Bolhapiac";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelDetails.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Label lblDetailItemDescription;
        private System.Windows.Forms.Label lblDetailItemName;
        private System.Windows.Forms.Label lblDetailItemId;
        private System.Windows.Forms.Label lblDetailItemPrice;
        private System.Windows.Forms.Label lblMainMarketTitle;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.TextBox txtFilterItemName;
        private System.Windows.Forms.Label lblFilterItemName;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtFilterItemId;
        private System.Windows.Forms.Label lblFilterItemId;
        private System.Windows.Forms.ListBox listItems;
    }
}
