
namespace demo1
{
    partial class SPBanNhieuNhat
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
            this.cmbloaisanpham = new Bunifu.Framework.UI.BunifuDropdown();
            this.dtgv_ttsp = new System.Windows.Forms.DataGridView();
            this.col_MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ttsp)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbloaisanpham
            // 
            this.cmbloaisanpham.BackColor = System.Drawing.Color.Transparent;
            this.cmbloaisanpham.BorderRadius = 3;
            this.cmbloaisanpham.DisabledColor = System.Drawing.Color.Gray;
            this.cmbloaisanpham.ForeColor = System.Drawing.Color.White;
            this.cmbloaisanpham.items = new string[] {
        "Bán nhiều nhất",
        "Bán chậm nhất"};
            this.cmbloaisanpham.Location = new System.Drawing.Point(352, 16);
            this.cmbloaisanpham.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cmbloaisanpham.Name = "cmbloaisanpham";
            this.cmbloaisanpham.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmbloaisanpham.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cmbloaisanpham.selectedIndex = -1;
            this.cmbloaisanpham.Size = new System.Drawing.Size(262, 36);
            this.cmbloaisanpham.TabIndex = 41;
            this.cmbloaisanpham.onItemSelected += new System.EventHandler(this.cmbloaisanpham_onItemSelected);
            // 
            // dtgv_ttsp
            // 
            this.dtgv_ttsp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_ttsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ttsp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaNV,
            this.TenNv,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtgv_ttsp.Location = new System.Drawing.Point(13, 63);
            this.dtgv_ttsp.Margin = new System.Windows.Forms.Padding(4);
            this.dtgv_ttsp.Name = "dtgv_ttsp";
            this.dtgv_ttsp.ReadOnly = true;
            this.dtgv_ttsp.RowTemplate.Height = 24;
            this.dtgv_ttsp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_ttsp.Size = new System.Drawing.Size(914, 370);
            this.dtgv_ttsp.TabIndex = 42;
            // 
            // col_MaNV
            // 
            this.col_MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_MaNV.DataPropertyName = "MaSP";
            this.col_MaNV.HeaderText = "Mã Sản Phẩm";
            this.col_MaNV.Name = "col_MaNV";
            this.col_MaNV.ReadOnly = true;
            // 
            // TenNv
            // 
            this.TenNv.DataPropertyName = "TenSP";
            this.TenNv.HeaderText = "Tên Sản Phẩm";
            this.TenNv.Name = "TenNv";
            this.TenNv.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DonGia";
            this.Column1.HeaderText = "Đơn Giá";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaLoai";
            this.Column2.HeaderText = "Mã Loại";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GiaNhap";
            this.Column3.HeaderText = "Giá Nhập";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SoLuongTon";
            this.Column4.HeaderText = "Số Lượng Tồn";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MoTa";
            this.Column5.HeaderText = "Mô tả";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // SPBanNhieuNhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.dtgv_ttsp);
            this.Controls.Add(this.cmbloaisanpham);
            this.Name = "SPBanNhieuNhat";
            this.Text = "SPBanNhieuNhat";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ttsp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDropdown cmbloaisanpham;
        private System.Windows.Forms.DataGridView dtgv_ttsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}