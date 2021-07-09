
namespace demo1
{
    partial class KhuyenMai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhuyenMai));
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenChucVu = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtMaChucVu = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.dtpngay = new System.Windows.Forms.DateTimePicker();
            this.dtpngayketthuc = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.TenNv,
            this.Column1,
            this.Column2});
            this.dtgv_ttkh.Location = new System.Drawing.Point(18, 60);
            this.dtgv_ttkh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgv_ttkh.Name = "dtgv_ttkh";
            this.dtgv_ttkh.ReadOnly = true;
            this.dtgv_ttkh.RowTemplate.Height = 24;
            this.dtgv_ttkh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_ttkh.Size = new System.Drawing.Size(591, 439);
            this.dtgv_ttkh.TabIndex = 29;
            this.dtgv_ttkh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ttkh_CellClick);
            // 
            // col_MaNV
            // 
            this.col_MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_MaNV.DataPropertyName = "MaKM";
            this.col_MaNV.HeaderText = "Mã Khuyến Mãi";
            this.col_MaNV.Name = "col_MaNV";
            this.col_MaNV.ReadOnly = true;
            // 
            // TenNv
            // 
            this.TenNv.DataPropertyName = "TenKM";
            this.TenNv.HeaderText = "Tên Khuyến Mãi";
            this.TenNv.Name = "TenNv";
            this.TenNv.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "NgayBatDau";
            this.Column1.HeaderText = "Ngày Bắt đầu";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NgayKetThuc";
            this.Column2.HeaderText = "Ngày kết thúc";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // txtTenChucVu
            // 
            this.txtTenChucVu.AcceptsReturn = false;
            this.txtTenChucVu.AcceptsTab = false;
            this.txtTenChucVu.AnimationSpeed = 200;
            this.txtTenChucVu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTenChucVu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTenChucVu.BackColor = System.Drawing.Color.Transparent;
            this.txtTenChucVu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTenChucVu.BackgroundImage")));
            this.txtTenChucVu.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtTenChucVu.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtTenChucVu.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtTenChucVu.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtTenChucVu.BorderRadius = 1;
            this.txtTenChucVu.BorderThickness = 1;
            this.txtTenChucVu.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTenChucVu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenChucVu.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.txtTenChucVu.DefaultText = "";
            this.txtTenChucVu.FillColor = System.Drawing.Color.White;
            this.txtTenChucVu.ForeColor = System.Drawing.Color.Black;
            this.txtTenChucVu.HideSelection = true;
            this.txtTenChucVu.IconLeft = null;
            this.txtTenChucVu.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenChucVu.IconPadding = 10;
            this.txtTenChucVu.IconRight = null;
            this.txtTenChucVu.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenChucVu.Lines = new string[0];
            this.txtTenChucVu.Location = new System.Drawing.Point(183, 126);
            this.txtTenChucVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenChucVu.MaxLength = 32767;
            this.txtTenChucVu.MinimumSize = new System.Drawing.Size(150, 48);
            this.txtTenChucVu.Modified = false;
            this.txtTenChucVu.Multiline = false;
            this.txtTenChucVu.Name = "txtTenChucVu";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTenChucVu.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTenChucVu.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTenChucVu.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Black;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTenChucVu.OnIdleState = stateProperties4;
            this.txtTenChucVu.PasswordChar = '\0';
            this.txtTenChucVu.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTenChucVu.PlaceholderText = "Nhập tên màu";
            this.txtTenChucVu.ReadOnly = false;
            this.txtTenChucVu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenChucVu.SelectedText = "";
            this.txtTenChucVu.SelectionLength = 0;
            this.txtTenChucVu.SelectionStart = 0;
            this.txtTenChucVu.ShortcutsEnabled = true;
            this.txtTenChucVu.Size = new System.Drawing.Size(262, 48);
            this.txtTenChucVu.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtTenChucVu.TabIndex = 31;
            this.txtTenChucVu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenChucVu.TextMarginBottom = 0;
            this.txtTenChucVu.TextMarginLeft = 5;
            this.txtTenChucVu.TextMarginTop = 0;
            this.txtTenChucVu.TextPlaceholder = "Nhập tên màu";
            this.txtTenChucVu.UseSystemPasswordChar = false;
            this.txtTenChucVu.WordWrap = true;
            // 
            // txtMaChucVu
            // 
            this.txtMaChucVu.AcceptsReturn = false;
            this.txtMaChucVu.AcceptsTab = false;
            this.txtMaChucVu.AnimationSpeed = 200;
            this.txtMaChucVu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMaChucVu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMaChucVu.BackColor = System.Drawing.Color.Transparent;
            this.txtMaChucVu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtMaChucVu.BackgroundImage")));
            this.txtMaChucVu.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtMaChucVu.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtMaChucVu.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtMaChucVu.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtMaChucVu.BorderRadius = 1;
            this.txtMaChucVu.BorderThickness = 1;
            this.txtMaChucVu.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaChucVu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaChucVu.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.txtMaChucVu.DefaultText = "";
            this.txtMaChucVu.FillColor = System.Drawing.Color.White;
            this.txtMaChucVu.ForeColor = System.Drawing.Color.Black;
            this.txtMaChucVu.HideSelection = true;
            this.txtMaChucVu.IconLeft = null;
            this.txtMaChucVu.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaChucVu.IconPadding = 10;
            this.txtMaChucVu.IconRight = null;
            this.txtMaChucVu.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaChucVu.Lines = new string[0];
            this.txtMaChucVu.Location = new System.Drawing.Point(183, 61);
            this.txtMaChucVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaChucVu.MaxLength = 32767;
            this.txtMaChucVu.MinimumSize = new System.Drawing.Size(150, 48);
            this.txtMaChucVu.Modified = false;
            this.txtMaChucVu.Multiline = false;
            this.txtMaChucVu.Name = "txtMaChucVu";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMaChucVu.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Empty;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMaChucVu.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMaChucVu.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Black;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMaChucVu.OnIdleState = stateProperties8;
            this.txtMaChucVu.PasswordChar = '\0';
            this.txtMaChucVu.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMaChucVu.PlaceholderText = "Nhập màu";
            this.txtMaChucVu.ReadOnly = false;
            this.txtMaChucVu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaChucVu.SelectedText = "";
            this.txtMaChucVu.SelectionLength = 0;
            this.txtMaChucVu.SelectionStart = 0;
            this.txtMaChucVu.ShortcutsEnabled = true;
            this.txtMaChucVu.Size = new System.Drawing.Size(262, 48);
            this.txtMaChucVu.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtMaChucVu.TabIndex = 30;
            this.txtMaChucVu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaChucVu.TextMarginBottom = 0;
            this.txtMaChucVu.TextMarginLeft = 5;
            this.txtMaChucVu.TextMarginTop = 0;
            this.txtMaChucVu.TextPlaceholder = "Nhập màu";
            this.txtMaChucVu.UseSystemPasswordChar = false;
            this.txtMaChucVu.WordWrap = true;
            // 
            // dtpngay
            // 
            this.dtpngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngay.Location = new System.Drawing.Point(183, 199);
            this.dtpngay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpngay.MaxDate = new System.DateTime(2024, 7, 16, 0, 0, 0, 0);
            this.dtpngay.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtpngay.Name = "dtpngay";
            this.dtpngay.Size = new System.Drawing.Size(262, 27);
            this.dtpngay.TabIndex = 62;
            this.dtpngay.Value = new System.DateTime(2020, 7, 15, 0, 0, 0, 0);
            // 
            // dtpngayketthuc
            // 
            this.dtpngayketthuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpngayketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngayketthuc.Location = new System.Drawing.Point(183, 257);
            this.dtpngayketthuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpngayketthuc.MaxDate = new System.DateTime(2024, 2, 23, 0, 0, 0, 0);
            this.dtpngayketthuc.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtpngayketthuc.Name = "dtpngayketthuc";
            this.dtpngayketthuc.Size = new System.Drawing.Size(262, 27);
            this.dtpngayketthuc.TabIndex = 63;
            this.dtpngayketthuc.Value = new System.DateTime(2020, 7, 15, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(456, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 31);
            this.label1.TabIndex = 64;
            this.label1.Text = "Khuyến Mãi Sản Phẩm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaChucVu);
            this.groupBox1.Controls.Add(this.txtTenChucVu);
            this.groupBox1.Controls.Add(this.dtpngayketthuc);
            this.groupBox1.Controls.Add(this.dtpngay);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(631, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(481, 342);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khuyến mãi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 257);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 67;
            this.label5.Text = "Ngày Kết Thúc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 205);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 66;
            this.label4.Text = "Ngày Bắt Đầu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 65;
            this.label3.Text = "Tên Khuyến Mãi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 64;
            this.label2.Text = "Mã Khuyến Mãi:";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::demo1.Properties.Resources.tải_xuống;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(986, 410);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 89);
            this.button3.TabIndex = 69;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::demo1.Properties.Resources.note_edit;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(859, 410);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 89);
            this.button2.TabIndex = 68;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::demo1.Properties.Resources.delete;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(740, 410);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 89);
            this.button1.TabIndex = 67;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackgroundImage = global::demo1.Properties.Resources.add;
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(631, 410);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(90, 89);
            this.btnthem.TabIndex = 66;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // KhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1119, 532);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgv_ttkh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KhuyenMai";
            this.Text = "KhuyenMai";
            this.Load += new System.EventHandler(this.KhuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ttkh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_ttkh;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtTenChucVu;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtMaChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DateTimePicker dtpngay;
        private System.Windows.Forms.DateTimePicker dtpngayketthuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnthem;
    }
}