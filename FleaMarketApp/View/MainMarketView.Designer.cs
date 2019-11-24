namespace FleaMarketApp
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
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnNewItem = new System.Windows.Forms.Button();
            this.btnShowList = new System.Windows.Forms.Button();
            this.lblMainMarketTitle = new System.Windows.Forms.Label();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtFilterItemName = new System.Windows.Forms.TextBox();
            this.lblFilterItemName = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFilterItemId = new System.Windows.Forms.TextBox();
            this.lblFilterItemId = new System.Windows.Forms.Label();
            this.listItems = new System.Windows.Forms.ListBox();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblDetailCategory = new System.Windows.Forms.Label();
            this.lblDetailItemPrice = new System.Windows.Forms.Label();
            this.lblDetailItemDescription = new System.Windows.Forms.Label();
            this.lblDetailItemName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDetailItemStatus = new System.Windows.Forms.Label();
            this.lblDetailItemId = new System.Windows.Forms.Label();
            this.txtFilterPriceMin = new System.Windows.Forms.TextBox();
            this.txtFilterPriceMax = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPriceMin = new System.Windows.Forms.Label();
            this.lblPriceMax = new System.Windows.Forms.Label();
            this.lblDetailCreatedAt = new System.Windows.Forms.Label();
            this.lblDetailModifiedAt = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelFilters.SuspendLayout();
            this.panelDetails.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDetails.Location = new System.Drawing.Point(666, 30);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(208, 20);
            this.lblDetails.TabIndex = 7;
            this.lblDetails.Text = "Részletek";
            this.lblDetails.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblDetails.Visible = false;
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblList.Location = new System.Drawing.Point(438, 30);
            this.lblList.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(208, 20);
            this.lblList.TabIndex = 6;
            this.lblList.Text = "Tárgylista";
            this.lblList.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFilter.Location = new System.Drawing.Point(210, 30);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(208, 20);
            this.lblFilter.TabIndex = 5;
            this.lblFilter.Text = "Szűrés";
            this.lblFilter.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.White;
            this.panelSidebar.Controls.Add(this.btnNewItem);
            this.panelSidebar.Controls.Add(this.btnShowList);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(0);
            this.panelSidebar.Name = "panelSidebar";
            this.tableLayoutPanel1.SetRowSpan(this.panelSidebar, 3);
            this.panelSidebar.Size = new System.Drawing.Size(200, 411);
            this.panelSidebar.TabIndex = 1;
            // 
            // btnNewItem
            // 
            this.btnNewItem.Location = new System.Drawing.Point(10, 59);
            this.btnNewItem.Margin = new System.Windows.Forms.Padding(10);
            this.btnNewItem.Name = "btnNewItem";
            this.btnNewItem.Size = new System.Drawing.Size(180, 40);
            this.btnNewItem.TabIndex = 1;
            this.btnNewItem.Text = "Új Tárgy";
            this.btnNewItem.UseVisualStyleBackColor = true;
            this.btnNewItem.Click += new System.EventHandler(this.btnNewItem_Click);
            // 
            // btnShowList
            // 
            this.btnShowList.Location = new System.Drawing.Point(10, 10);
            this.btnShowList.Margin = new System.Windows.Forms.Padding(10);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(180, 40);
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
            // panelFilters
            // 
            this.panelFilters.Controls.Add(this.lblPriceMax);
            this.panelFilters.Controls.Add(this.lblPriceMin);
            this.panelFilters.Controls.Add(this.lblPrice);
            this.panelFilters.Controls.Add(this.txtFilterPriceMax);
            this.panelFilters.Controls.Add(this.txtFilterPriceMin);
            this.panelFilters.Controls.Add(this.comboStatus);
            this.panelFilters.Controls.Add(this.lblStatus);
            this.panelFilters.Controls.Add(this.comboCategory);
            this.panelFilters.Controls.Add(this.lblCategory);
            this.panelFilters.Controls.Add(this.txtFilterItemName);
            this.panelFilters.Controls.Add(this.lblFilterItemName);
            this.panelFilters.Controls.Add(this.btnFilter);
            this.panelFilters.Controls.Add(this.txtFilterItemId);
            this.panelFilters.Controls.Add(this.lblFilterItemId);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFilters.Location = new System.Drawing.Point(210, 60);
            this.panelFilters.Margin = new System.Windows.Forms.Padding(10);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(208, 341);
            this.panelFilters.TabIndex = 3;
            // 
            // comboStatus
            // 
            this.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Location = new System.Drawing.Point(3, 188);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(200, 21);
            this.comboStatus.TabIndex = 9;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatus.Location = new System.Drawing.Point(2, 173);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 13);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Státusz";
            // 
            // comboCategory
            // 
            this.comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(3, 149);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(200, 21);
            this.comboCategory.TabIndex = 7;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCategory.Location = new System.Drawing.Point(2, 132);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(61, 13);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Kategória";
            // 
            // txtFilterItemName
            // 
            this.txtFilterItemName.Location = new System.Drawing.Point(3, 58);
            this.txtFilterItemName.Name = "txtFilterItemName";
            this.txtFilterItemName.Size = new System.Drawing.Size(201, 20);
            this.txtFilterItemName.TabIndex = 5;
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
            // btnFilter
            // 
            this.btnFilter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFilter.Location = new System.Drawing.Point(0, 318);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(208, 23);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Szűrés";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtFilterItemId
            // 
            this.txtFilterItemId.Location = new System.Drawing.Point(3, 19);
            this.txtFilterItemId.Name = "txtFilterItemId";
            this.txtFilterItemId.Size = new System.Drawing.Size(201, 20);
            this.txtFilterItemId.TabIndex = 1;
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
            // listItems
            // 
            this.listItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listItems.FormattingEnabled = true;
            this.listItems.Location = new System.Drawing.Point(438, 60);
            this.listItems.Margin = new System.Windows.Forms.Padding(10);
            this.listItems.Name = "listItems";
            this.listItems.Size = new System.Drawing.Size(208, 341);
            this.listItems.TabIndex = 2;
            this.listItems.SelectedIndexChanged += new System.EventHandler(this.listItems_SelectedIndexChanged);
            // 
            // panelDetails
            // 
            this.panelDetails.Controls.Add(this.lblDetailModifiedAt);
            this.panelDetails.Controls.Add(this.lblDetailCreatedAt);
            this.panelDetails.Controls.Add(this.btnEdit);
            this.panelDetails.Controls.Add(this.lblDetailCategory);
            this.panelDetails.Controls.Add(this.lblDetailItemPrice);
            this.panelDetails.Controls.Add(this.lblDetailItemDescription);
            this.panelDetails.Controls.Add(this.lblDetailItemName);
            this.panelDetails.Controls.Add(this.panel1);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetails.Location = new System.Drawing.Point(666, 60);
            this.panelDetails.Margin = new System.Windows.Forms.Padding(10);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(208, 341);
            this.panelDetails.TabIndex = 1;
            this.panelDetails.Visible = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(0, 318);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Szerkesztés";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblDetailCategory
            // 
            this.lblDetailCategory.Location = new System.Drawing.Point(0, 167);
            this.lblDetailCategory.Name = "lblDetailCategory";
            this.lblDetailCategory.Size = new System.Drawing.Size(208, 17);
            this.lblDetailCategory.TabIndex = 8;
            this.lblDetailCategory.Text = "Kategória";
            this.lblDetailCategory.UseMnemonic = false;
            // 
            // lblDetailItemPrice
            // 
            this.lblDetailItemPrice.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDetailItemPrice.Location = new System.Drawing.Point(-3, 137);
            this.lblDetailItemPrice.Margin = new System.Windows.Forms.Padding(0);
            this.lblDetailItemPrice.Name = "lblDetailItemPrice";
            this.lblDetailItemPrice.Size = new System.Drawing.Size(211, 30);
            this.lblDetailItemPrice.TabIndex = 7;
            this.lblDetailItemPrice.Text = "Ár";
            // 
            // lblDetailItemDescription
            // 
            this.lblDetailItemDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDetailItemDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDetailItemDescription.Location = new System.Drawing.Point(0, 52);
            this.lblDetailItemDescription.Margin = new System.Windows.Forms.Padding(0);
            this.lblDetailItemDescription.Name = "lblDetailItemDescription";
            this.lblDetailItemDescription.Size = new System.Drawing.Size(208, 85);
            this.lblDetailItemDescription.TabIndex = 6;
            this.lblDetailItemDescription.Text = "Leírás";
            // 
            // lblDetailItemName
            // 
            this.lblDetailItemName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDetailItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDetailItemName.Location = new System.Drawing.Point(0, 23);
            this.lblDetailItemName.Margin = new System.Windows.Forms.Padding(0);
            this.lblDetailItemName.Name = "lblDetailItemName";
            this.lblDetailItemName.Size = new System.Drawing.Size(208, 29);
            this.lblDetailItemName.TabIndex = 5;
            this.lblDetailItemName.Text = "Termék megnevezés";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDetailItemStatus);
            this.panel1.Controls.Add(this.lblDetailItemId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 23);
            this.panel1.TabIndex = 4;
            // 
            // lblDetailItemStatus
            // 
            this.lblDetailItemStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDetailItemStatus.Location = new System.Drawing.Point(69, 0);
            this.lblDetailItemStatus.Margin = new System.Windows.Forms.Padding(0);
            this.lblDetailItemStatus.Name = "lblDetailItemStatus";
            this.lblDetailItemStatus.Size = new System.Drawing.Size(139, 16);
            this.lblDetailItemStatus.TabIndex = 5;
            this.lblDetailItemStatus.Text = "Státusz";
            this.lblDetailItemStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDetailItemId
            // 
            this.lblDetailItemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDetailItemId.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDetailItemId.Location = new System.Drawing.Point(0, 0);
            this.lblDetailItemId.Margin = new System.Windows.Forms.Padding(0);
            this.lblDetailItemId.Name = "lblDetailItemId";
            this.lblDetailItemId.Size = new System.Drawing.Size(69, 16);
            this.lblDetailItemId.TabIndex = 4;
            this.lblDetailItemId.Text = "Azonosító";
            // 
            // txtFilterPriceMin
            // 
            this.txtFilterPriceMin.Location = new System.Drawing.Point(3, 109);
            this.txtFilterPriceMin.Name = "txtFilterPriceMin";
            this.txtFilterPriceMin.Size = new System.Drawing.Size(95, 20);
            this.txtFilterPriceMin.TabIndex = 10;
            // 
            // txtFilterPriceMax
            // 
            this.txtFilterPriceMax.Location = new System.Drawing.Point(108, 109);
            this.txtFilterPriceMax.Name = "txtFilterPriceMax";
            this.txtFilterPriceMax.Size = new System.Drawing.Size(95, 20);
            this.txtFilterPriceMax.TabIndex = 11;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrice.Location = new System.Drawing.Point(2, 80);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(19, 13);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Ár";
            // 
            // lblPriceMin
            // 
            this.lblPriceMin.AutoSize = true;
            this.lblPriceMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPriceMin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPriceMin.Location = new System.Drawing.Point(2, 93);
            this.lblPriceMin.Name = "lblPriceMin";
            this.lblPriceMin.Size = new System.Drawing.Size(31, 13);
            this.lblPriceMin.TabIndex = 13;
            this.lblPriceMin.Text = "Min.";
            // 
            // lblPriceMax
            // 
            this.lblPriceMax.AutoSize = true;
            this.lblPriceMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPriceMax.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPriceMax.Location = new System.Drawing.Point(105, 93);
            this.lblPriceMax.Name = "lblPriceMax";
            this.lblPriceMax.Size = new System.Drawing.Size(34, 13);
            this.lblPriceMax.TabIndex = 14;
            this.lblPriceMax.Text = "Max.";
            // 
            // lblDetailCreatedAt
            // 
            this.lblDetailCreatedAt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDetailCreatedAt.Location = new System.Drawing.Point(0, 184);
            this.lblDetailCreatedAt.Name = "lblDetailCreatedAt";
            this.lblDetailCreatedAt.Size = new System.Drawing.Size(208, 17);
            this.lblDetailCreatedAt.TabIndex = 10;
            this.lblDetailCreatedAt.Text = "Hozzáadva";
            this.lblDetailCreatedAt.UseMnemonic = false;
            // 
            // lblDetailModifiedAt
            // 
            this.lblDetailModifiedAt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDetailModifiedAt.Location = new System.Drawing.Point(0, 201);
            this.lblDetailModifiedAt.Name = "lblDetailModifiedAt";
            this.lblDetailModifiedAt.Size = new System.Drawing.Size(208, 17);
            this.lblDetailModifiedAt.TabIndex = 11;
            this.lblDetailModifiedAt.Text = "Utoljára módosítva";
            this.lblDetailModifiedAt.UseMnemonic = false;
            // 
            // MainMarketView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainMarketView";
            this.Text = "Bolhapiac";
            this.EnabledChanged += new System.EventHandler(this.MainMarketView_EnabledChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            this.panelDetails.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDetailCategory;
        private System.Windows.Forms.Button btnNewItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDetailItemStatus;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblPriceMax;
        private System.Windows.Forms.Label lblPriceMin;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtFilterPriceMax;
        private System.Windows.Forms.TextBox txtFilterPriceMin;
        private System.Windows.Forms.Label lblDetailModifiedAt;
        private System.Windows.Forms.Label lblDetailCreatedAt;
    }
}

