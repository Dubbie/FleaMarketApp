namespace FleaMarketApp.View
{
    partial class IncomeView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.splitStatisticsContainer = new System.Windows.Forms.SplitContainer();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.chartIncome = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.splitStatisticsContainer)).BeginInit();
            this.splitStatisticsContainer.Panel1.SuspendLayout();
            this.splitStatisticsContainer.Panel2.SuspendLayout();
            this.splitStatisticsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // splitStatisticsContainer
            // 
            this.splitStatisticsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitStatisticsContainer.Location = new System.Drawing.Point(0, 0);
            this.splitStatisticsContainer.Name = "splitStatisticsContainer";
            // 
            // splitStatisticsContainer.Panel1
            // 
            this.splitStatisticsContainer.Panel1.BackColor = System.Drawing.Color.White;
            this.splitStatisticsContainer.Panel1.Controls.Add(this.btnUpdate);
            this.splitStatisticsContainer.Panel1.Controls.Add(this.dateTo);
            this.splitStatisticsContainer.Panel1.Controls.Add(this.lblTo);
            this.splitStatisticsContainer.Panel1.Controls.Add(this.dateFrom);
            this.splitStatisticsContainer.Panel1.Controls.Add(this.lblFrom);
            this.splitStatisticsContainer.Panel1.Padding = new System.Windows.Forms.Padding(10);
            this.splitStatisticsContainer.Panel1MinSize = 200;
            // 
            // splitStatisticsContainer.Panel2
            // 
            this.splitStatisticsContainer.Panel2.Controls.Add(this.chartIncome);
            this.splitStatisticsContainer.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitStatisticsContainer.Size = new System.Drawing.Size(624, 441);
            this.splitStatisticsContainer.SplitterDistance = 200;
            this.splitStatisticsContainer.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUpdate.Location = new System.Drawing.Point(10, 408);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Szűrés";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dateTo
            // 
            this.dateTo.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTo.Location = new System.Drawing.Point(10, 70);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(180, 20);
            this.dateTo.TabIndex = 3;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTo.Location = new System.Drawing.Point(10, 45);
            this.lblTo.Name = "lblTo";
            this.lblTo.Padding = new System.Windows.Forms.Padding(0, 10, 0, 2);
            this.lblTo.Size = new System.Drawing.Size(32, 25);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "Vége";
            // 
            // dateFrom
            // 
            this.dateFrom.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateFrom.Location = new System.Drawing.Point(10, 25);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(180, 20);
            this.dateFrom.TabIndex = 1;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFrom.Location = new System.Drawing.Point(10, 10);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.lblFrom.Size = new System.Drawing.Size(43, 15);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "Kezdve";
            // 
            // chartIncome
            // 
            this.chartIncome.BackColor = System.Drawing.SystemColors.Control;
            chartArea4.Name = "ChartArea1";
            this.chartIncome.ChartAreas.Add(chartArea4);
            this.chartIncome.Location = new System.Drawing.Point(14, 13);
            this.chartIncome.Name = "chartIncome";
            this.chartIncome.Size = new System.Drawing.Size(393, 415);
            this.chartIncome.TabIndex = 0;
            this.chartIncome.Text = "Bevétel alakulása";
            title4.Name = "ChartTitle";
            title4.Text = "Bevétel alakulása";
            this.chartIncome.Titles.Add(title4);
            // 
            // IncomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.splitStatisticsContainer);
            this.Name = "IncomeView";
            this.ShowIcon = false;
            this.Text = "Bevétel alakulása";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IncomeView_FormClosed);
            this.splitStatisticsContainer.Panel1.ResumeLayout(false);
            this.splitStatisticsContainer.Panel1.PerformLayout();
            this.splitStatisticsContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitStatisticsContainer)).EndInit();
            this.splitStatisticsContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartIncome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitStatisticsContainer;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIncome;
    }
}