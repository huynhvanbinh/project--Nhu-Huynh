﻿
namespace demo1
{
    partial class LoaiSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaiSanPham));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.dtgv_ttkh = new System.Windows.Forms.DataGridView();
            this.col_MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTen = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtMa = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ttkh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_ttkh
            // 
            this.dtgv_ttkh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_ttkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ttkh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaNV,
            this.TenNv});
            this.dtgv_ttkh.Location = new System.Drawing.Point(12, 58);
            this.dtgv_ttkh.Name = "dtgv_ttkh";
            this.dtgv_ttkh.ReadOnly = true;
            this.dtgv_ttkh.RowTemplate.Height = 24;
            this.dtgv_ttkh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_ttkh.Size = new System.Drawing.Size(403, 251);
            this.dtgv_ttkh.TabIndex = 14;
            this.dtgv_ttkh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ttkh_CellClick);
            // 
            // col_MaNV
            // 
            this.col_MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_MaNV.DataPropertyName = "MaLoai";
            this.col_MaNV.HeaderText = "Mã Sản Phẩm";
            this.col_MaNV.Name = "col_MaNV";
            this.col_MaNV.ReadOnly = true;
            // 
            // TenNv
            // 
            this.TenNv.DataPropertyName = "TenLoai";
            this.TenNv.HeaderText = "Tên Loại Sản Phẩm";
            this.TenNv.Name = "TenNv";
            this.TenNv.ReadOnly = true;
            // 
            // txtTen
            // 
            this.txtTen.AcceptsReturn = false;
            this.txtTen.AcceptsTab = false;
            this.txtTen.AnimationSpeed = 200;
            this.txtTen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTen.BackColor = System.Drawing.Color.Transparent;
            this.txtTen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTen.BackgroundImage")));
            this.txtTen.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtTen.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtTen.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtTen.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtTen.BorderRadius = 1;
            this.txtTen.BorderThickness = 1;
            this.txtTen.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTen.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtTen.DefaultText = "";
            this.txtTen.FillColor = System.Drawing.Color.White;
            this.txtTen.ForeColor = System.Drawing.Color.Black;
            this.txtTen.HideSelection = true;
            this.txtTen.IconLeft = null;
            this.txtTen.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTen.IconPadding = 10;
            this.txtTen.IconRight = null;
            this.txtTen.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTen.Lines = new string[0];
            this.txtTen.Location = new System.Drawing.Point(104, 106);
            this.txtTen.MaxLength = 32767;
            this.txtTen.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtTen.Modified = false;
            this.txtTen.Multiline = false;
            this.txtTen.Name = "txtTen";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTen.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTen.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTen.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Black;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTen.OnIdleState = stateProperties4;
            this.txtTen.PasswordChar = '\0';
            this.txtTen.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTen.PlaceholderText = "Nhập tên sản phẩm";
            this.txtTen.ReadOnly = false;
            this.txtTen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTen.SelectedText = "";
            this.txtTen.SelectionLength = 0;
            this.txtTen.SelectionStart = 0;
            this.txtTen.ShortcutsEnabled = true;
            this.txtTen.Size = new System.Drawing.Size(200, 35);
            this.txtTen.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtTen.TabIndex = 23;
            this.txtTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTen.TextMarginBottom = 0;
            this.txtTen.TextMarginLeft = 5;
            this.txtTen.TextMarginTop = 0;
            this.txtTen.TextPlaceholder = "Nhập tên sản phẩm";
            this.txtTen.UseSystemPasswordChar = false;
            this.txtTen.WordWrap = true;
            // 
            // txtMa
            // 
            this.txtMa.AcceptsReturn = false;
            this.txtMa.AcceptsTab = false;
            this.txtMa.AnimationSpeed = 200;
            this.txtMa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMa.BackColor = System.Drawing.Color.Transparent;
            this.txtMa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtMa.BackgroundImage")));
            this.txtMa.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtMa.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtMa.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtMa.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtMa.BorderRadius = 1;
            this.txtMa.BorderThickness = 1;
            this.txtMa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMa.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtMa.DefaultText = "";
            this.txtMa.FillColor = System.Drawing.Color.White;
            this.txtMa.ForeColor = System.Drawing.Color.Black;
            this.txtMa.HideSelection = true;
            this.txtMa.IconLeft = null;
            this.txtMa.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMa.IconPadding = 10;
            this.txtMa.IconRight = null;
            this.txtMa.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMa.Lines = new string[0];
            this.txtMa.Location = new System.Drawing.Point(104, 36);
            this.txtMa.MaxLength = 32767;
            this.txtMa.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtMa.Modified = false;
            this.txtMa.Multiline = false;
            this.txtMa.Name = "txtMa";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMa.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Empty;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMa.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMa.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Black;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMa.OnIdleState = stateProperties8;
            this.txtMa.PasswordChar = '\0';
            this.txtMa.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMa.PlaceholderText = "Nhập mã sản phẩm";
            this.txtMa.ReadOnly = false;
            this.txtMa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMa.SelectedText = "";
            this.txtMa.SelectionLength = 0;
            this.txtMa.SelectionStart = 0;
            this.txtMa.ShortcutsEnabled = true;
            this.txtMa.Size = new System.Drawing.Size(200, 35);
            this.txtMa.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtMa.TabIndex = 22;
            this.txtMa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMa.TextMarginBottom = 0;
            this.txtMa.TextMarginLeft = 5;
            this.txtMa.TextMarginTop = 0;
            this.txtMa.TextPlaceholder = "Nhập mã sản phẩm";
            this.txtMa.UseSystemPasswordChar = false;
            this.txtMa.WordWrap = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(218, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 31);
            this.label1.TabIndex = 28;
            this.label1.Text = "Loại Sản Phẩm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(421, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 162);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tên Loại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mã Loại:";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::demo1.Properties.Resources.tải_xuống;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(685, 245);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 64);
            this.button3.TabIndex = 33;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::demo1.Properties.Resources.note_edit;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(599, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 64);
            this.button2.TabIndex = 32;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::demo1.Properties.Resources.delete;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(516, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 64);
            this.button1.TabIndex = 31;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackgroundImage = global::demo1.Properties.Resources.add;
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(429, 245);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(60, 64);
            this.btnthem.TabIndex = 30;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // LoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(760, 331);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgv_ttkh);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "LoaiSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoaiSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ttkh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_ttkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNv;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtTen;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnthem;
    }
}