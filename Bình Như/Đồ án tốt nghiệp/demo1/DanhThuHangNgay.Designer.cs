
namespace demo1
{
    partial class DanhThuHangNgay
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartcot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chartcot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartcot
            // 
            chartArea2.Name = "ChartArea1";
            this.chartcot.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartcot.Legends.Add(legend2);
            this.chartcot.Location = new System.Drawing.Point(92, 138);
            this.chartcot.Name = "chartcot";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "thang";
            this.chartcot.Series.Add(series2);
            this.chartcot.Size = new System.Drawing.Size(582, 300);
            this.chartcot.TabIndex = 0;
            this.chartcot.Text = "chart1";
            title2.Name = "thang";
            title2.Text = "Doanh thu hàng ngày";
            this.chartcot.Titles.Add(title2);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(848, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // DanhThuHangNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chartcot);
            this.Name = "DanhThuHangNgay";
            this.Text = "DanhThuHangNgay";
            this.Load += new System.EventHandler(this.DanhThuHangNgay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartcot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartcot;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}