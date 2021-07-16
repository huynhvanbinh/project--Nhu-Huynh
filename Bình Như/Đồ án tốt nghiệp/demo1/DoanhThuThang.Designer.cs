
namespace demo1
{
    partial class DoanhThuThang
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.danhthuthang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.danhthuthang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // danhthuthang
            // 
            chartArea1.Name = "ChartArea1";
            this.danhthuthang.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.danhthuthang.Legends.Add(legend1);
            this.danhthuthang.Location = new System.Drawing.Point(12, 197);
            this.danhthuthang.Name = "danhthuthang";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "danhthuthang";
            this.danhthuthang.Series.Add(series1);
            this.danhthuthang.Size = new System.Drawing.Size(848, 300);
            this.danhthuthang.TabIndex = 0;
            this.danhthuthang.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title1.ForeColor = System.Drawing.Color.Red;
            title1.Name = "danhthuthang";
            title1.Text = "Danh thu tháng";
            this.danhthuthang.Titles.Add(title1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(848, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // DoanhThuThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 509);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.danhthuthang);
            this.Name = "DoanhThuThang";
            this.Text = "DoanhThuThang";
            ((System.ComponentModel.ISupportInitialize)(this.danhthuthang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart danhthuthang;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}