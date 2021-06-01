
namespace Cases
{
    partial class ReportsControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.RouteReport = new System.Windows.Forms.TabPage();
            this.routeDataGrid = new System.Windows.Forms.DataGridView();
            this.SellReport = new System.Windows.Forms.TabPage();
            this.sellDataGrid = new System.Windows.Forms.DataGridView();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.endTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.RouteReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeDataGrid)).BeginInit();
            this.SellReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.RouteReport);
            this.tabControl1.Controls.Add(this.SellReport);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(4, 99);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1969, 853);
            this.tabControl1.TabIndex = 0;
            // 
            // RouteReport
            // 
            this.RouteReport.AutoScroll = true;
            this.RouteReport.Controls.Add(this.routeDataGrid);
            this.RouteReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RouteReport.Location = new System.Drawing.Point(4, 34);
            this.RouteReport.Name = "RouteReport";
            this.RouteReport.Padding = new System.Windows.Forms.Padding(3);
            this.RouteReport.Size = new System.Drawing.Size(1961, 815);
            this.RouteReport.TabIndex = 1;
            this.RouteReport.Text = "Отчёт  о востребованности рейсов";
            this.RouteReport.UseVisualStyleBackColor = true;
            // 
            // routeDataGrid
            // 
            this.routeDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.routeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.routeDataGrid.Location = new System.Drawing.Point(7, 7);
            this.routeDataGrid.Name = "routeDataGrid";
            this.routeDataGrid.RowHeadersWidth = 51;
            this.routeDataGrid.RowTemplate.Height = 24;
            this.routeDataGrid.Size = new System.Drawing.Size(1948, 805);
            this.routeDataGrid.TabIndex = 0;
            // 
            // SellReport
            // 
            this.SellReport.Controls.Add(this.sellDataGrid);
            this.SellReport.Location = new System.Drawing.Point(4, 34);
            this.SellReport.Name = "SellReport";
            this.SellReport.Padding = new System.Windows.Forms.Padding(3);
            this.SellReport.Size = new System.Drawing.Size(1961, 815);
            this.SellReport.TabIndex = 0;
            this.SellReport.Text = "Отчёт о продаже билетов";
            this.SellReport.UseVisualStyleBackColor = true;
            // 
            // sellDataGrid
            // 
            this.sellDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sellDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellDataGrid.Location = new System.Drawing.Point(6, 6);
            this.sellDataGrid.Name = "sellDataGrid";
            this.sellDataGrid.RowHeadersWidth = 51;
            this.sellDataGrid.RowTemplate.Height = 24;
            this.sellDataGrid.Size = new System.Drawing.Size(1312, 803);
            this.sellDataGrid.TabIndex = 0;
            // 
            // startTime
            // 
            this.startTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startTime.Location = new System.Drawing.Point(75, 44);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(200, 30);
            this.startTime.TabIndex = 1;
            this.startTime.ValueChanged += new System.EventHandler(this.startTime_ValueChanged);
            // 
            // endTime
            // 
            this.endTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endTime.Location = new System.Drawing.Point(347, 44);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(200, 30);
            this.endTime.TabIndex = 2;
            this.endTime.ValueChanged += new System.EventHandler(this.endTime_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Отчёт за перод";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "С";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(304, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "По";
            // 
            // ReportsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.tabControl1);
            this.Name = "ReportsControl";
            this.Size = new System.Drawing.Size(1976, 955);
            this.Load += new System.EventHandler(this.ReportsControl1_Load);
            this.tabControl1.ResumeLayout(false);
            this.RouteReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.routeDataGrid)).EndInit();
            this.SellReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sellDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SellReport;
        private System.Windows.Forms.TabPage RouteReport;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.DateTimePicker endTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView routeDataGrid;
        private System.Windows.Forms.DataGridView sellDataGrid;
    }
}
