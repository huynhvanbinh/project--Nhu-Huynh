
namespace demo1
{
    partial class TaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaiKhoan));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.dtgv_ttkh = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMatKhau = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtTaiKhoan = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtmanhanvien = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.Column1,
            this.col_MaNV,
            this.TenNv});
            this.dtgv_ttkh.Location = new System.Drawing.Point(12, 47);
            this.dtgv_ttkh.Name = "dtgv_ttkh";
            this.dtgv_ttkh.ReadOnly = true;
            this.dtgv_ttkh.RowTemplate.Height = 24;
            this.dtgv_ttkh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_ttkh.Size = new System.Drawing.Size(519, 275);
            this.dtgv_ttkh.TabIndex = 22;
            this.dtgv_ttkh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ttkh_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNV";
            this.Column1.HeaderText = "Mã Nhân Viên";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // col_MaNV
            // 
            this.col_MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_MaNV.DataPropertyName = "TaiKhoan";
            this.col_MaNV.FillWeight = 50.76142F;
            this.col_MaNV.HeaderText = "Tài Khoản";
            this.col_MaNV.Name = "col_MaNV";
            this.col_MaNV.ReadOnly = true;
            // 
            // TenNv
            // 
            this.TenNv.DataPropertyName = "MatKhau";
            this.TenNv.FillWeight = 149.2386F;
            this.TenNv.HeaderText = "Mật Khẩu";
            this.TenNv.Name = "TenNv";
            this.TenNv.ReadOnly = true;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.AcceptsReturn = false;
            this.txtMatKhau.AcceptsTab = false;
            this.txtMatKhau.AnimationSpeed = 200;
            this.txtMatKhau.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMatKhau.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.txtMatKhau.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtMatKhau.BackgroundImage")));
            this.txtMatKhau.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtMatKhau.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtMatKhau.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtMatKhau.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtMatKhau.BorderRadius = 1;
            this.txtMatKhau.BorderThickness = 1;
            this.txtMatKhau.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtMatKhau.DefaultText = "";
            this.txtMatKhau.FillColor = System.Drawing.Color.White;
            this.txtMatKhau.ForeColor = System.Drawing.Color.Black;
            this.txtMatKhau.HideSelection = true;
            this.txtMatKhau.IconLeft = null;
            this.txtMatKhau.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.IconPadding = 10;
            this.txtMatKhau.IconRight = null;
            this.txtMatKhau.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.Lines = new string[0];
            this.txtMatKhau.Location = new System.Drawing.Point(103, 145);
            this.txtMatKhau.MaxLength = 32767;
            this.txtMatKhau.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtMatKhau.Modified = false;
            this.txtMatKhau.Multiline = false;
            this.txtMatKhau.Name = "txtMatKhau";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMatKhau.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMatKhau.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMatKhau.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Black;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMatKhau.OnIdleState = stateProperties4;
            this.txtMatKhau.PasswordChar = '\0';
            this.txtMatKhau.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMatKhau.PlaceholderText = "nhập mật khẩu";
            this.txtMatKhau.ReadOnly = false;
            this.txtMatKhau.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.SelectionLength = 0;
            this.txtMatKhau.SelectionStart = 0;
            this.txtMatKhau.ShortcutsEnabled = true;
            this.txtMatKhau.Size = new System.Drawing.Size(200, 35);
            this.txtMatKhau.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtMatKhau.TabIndex = 24;
            this.txtMatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMatKhau.TextMarginBottom = 0;
            this.txtMatKhau.TextMarginLeft = 5;
            this.txtMatKhau.TextMarginTop = 0;
            this.txtMatKhau.TextPlaceholder = "nhập mật khẩu";
            this.txtMatKhau.UseSystemPasswordChar = false;
            this.txtMatKhau.WordWrap = true;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.AcceptsReturn = false;
            this.txtTaiKhoan.AcceptsTab = false;
            this.txtTaiKhoan.AnimationSpeed = 200;
            this.txtTaiKhoan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTaiKhoan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.txtTaiKhoan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTaiKhoan.BackgroundImage")));
            this.txtTaiKhoan.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtTaiKhoan.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtTaiKhoan.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtTaiKhoan.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtTaiKhoan.BorderRadius = 1;
            this.txtTaiKhoan.BorderThickness = 1;
            this.txtTaiKhoan.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaiKhoan.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtTaiKhoan.DefaultText = "";
            this.txtTaiKhoan.FillColor = System.Drawing.Color.White;
            this.txtTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.txtTaiKhoan.HideSelection = true;
            this.txtTaiKhoan.IconLeft = null;
            this.txtTaiKhoan.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaiKhoan.IconPadding = 10;
            this.txtTaiKhoan.IconRight = null;
            this.txtTaiKhoan.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaiKhoan.Lines = new string[0];
            this.txtTaiKhoan.Location = new System.Drawing.Point(103, 89);
            this.txtTaiKhoan.MaxLength = 32767;
            this.txtTaiKhoan.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtTaiKhoan.Modified = false;
            this.txtTaiKhoan.Multiline = false;
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTaiKhoan.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Empty;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTaiKhoan.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTaiKhoan.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Black;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTaiKhoan.OnIdleState = stateProperties8;
            this.txtTaiKhoan.PasswordChar = '\0';
            this.txtTaiKhoan.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTaiKhoan.PlaceholderText = "nhập tài khoản";
            this.txtTaiKhoan.ReadOnly = false;
            this.txtTaiKhoan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTaiKhoan.SelectedText = "";
            this.txtTaiKhoan.SelectionLength = 0;
            this.txtTaiKhoan.SelectionStart = 0;
            this.txtTaiKhoan.ShortcutsEnabled = true;
            this.txtTaiKhoan.Size = new System.Drawing.Size(200, 35);
            this.txtTaiKhoan.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtTaiKhoan.TabIndex = 23;
            this.txtTaiKhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTaiKhoan.TextMarginBottom = 0;
            this.txtTaiKhoan.TextMarginLeft = 5;
            this.txtTaiKhoan.TextMarginTop = 0;
            this.txtTaiKhoan.TextPlaceholder = "nhập tài khoản";
            this.txtTaiKhoan.UseSystemPasswordChar = false;
            this.txtTaiKhoan.WordWrap = true;
            // 
            // txtmanhanvien
            // 
            this.txtmanhanvien.AcceptsReturn = false;
            this.txtmanhanvien.AcceptsTab = false;
            this.txtmanhanvien.AnimationSpeed = 200;
            this.txtmanhanvien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtmanhanvien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtmanhanvien.BackColor = System.Drawing.Color.Transparent;
            this.txtmanhanvien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtmanhanvien.BackgroundImage")));
            this.txtmanhanvien.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtmanhanvien.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtmanhanvien.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtmanhanvien.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtmanhanvien.BorderRadius = 1;
            this.txtmanhanvien.BorderThickness = 1;
            this.txtmanhanvien.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtmanhanvien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmanhanvien.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtmanhanvien.DefaultText = "";
            this.txtmanhanvien.FillColor = System.Drawing.Color.White;
            this.txtmanhanvien.ForeColor = System.Drawing.Color.Black;
            this.txtmanhanvien.HideSelection = true;
            this.txtmanhanvien.IconLeft = null;
            this.txtmanhanvien.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmanhanvien.IconPadding = 10;
            this.txtmanhanvien.IconRight = null;
            this.txtmanhanvien.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmanhanvien.Lines = new string[0];
            this.txtmanhanvien.Location = new System.Drawing.Point(103, 38);
            this.txtmanhanvien.MaxLength = 32767;
            this.txtmanhanvien.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtmanhanvien.Modified = false;
            this.txtmanhanvien.Multiline = false;
            this.txtmanhanvien.Name = "txtmanhanvien";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtmanhanvien.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.Empty;
            stateProperties10.FillColor = System.Drawing.Color.White;
            stateProperties10.ForeColor = System.Drawing.Color.Empty;
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtmanhanvien.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtmanhanvien.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Black;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtmanhanvien.OnIdleState = stateProperties12;
            this.txtmanhanvien.PasswordChar = '\0';
            this.txtmanhanvien.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtmanhanvien.PlaceholderText = "Mã Nhân Viên";
            this.txtmanhanvien.ReadOnly = false;
            this.txtmanhanvien.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtmanhanvien.SelectedText = "";
            this.txtmanhanvien.SelectionLength = 0;
            this.txtmanhanvien.SelectionStart = 0;
            this.txtmanhanvien.ShortcutsEnabled = true;
            this.txtmanhanvien.Size = new System.Drawing.Size(200, 35);
            this.txtmanhanvien.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtmanhanvien.TabIndex = 29;
            this.txtmanhanvien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtmanhanvien.TextMarginBottom = 0;
            this.txtmanhanvien.TextMarginLeft = 5;
            this.txtmanhanvien.TextMarginTop = 0;
            this.txtmanhanvien.TextPlaceholder = "Mã Nhân Viên";
            this.txtmanhanvien.UseSystemPasswordChar = false;
            this.txtmanhanvien.WordWrap = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(240, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "Quản Lý Tài Khoản";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTaiKhoan);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.txtmanhanvien);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(547, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 197);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Mật khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Thài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Mã NV:";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::demo1.Properties.Resources.tải_xuống;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(805, 258);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 64);
            this.button3.TabIndex = 35;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::demo1.Properties.Resources.note_edit;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(719, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 64);
            this.button2.TabIndex = 34;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::demo1.Properties.Resources.delete;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(636, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 64);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnthem
            // 
            this.btnthem.BackgroundImage = global::demo1.Properties.Resources.add;
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(549, 258);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(60, 64);
            this.btnthem.TabIndex = 32;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(877, 340);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgv_ttkh);
            this.Name = "TaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaiKhoan";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ttkh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_ttkh;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtMatKhau;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNv;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtmanhanvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnthem;
    }
}