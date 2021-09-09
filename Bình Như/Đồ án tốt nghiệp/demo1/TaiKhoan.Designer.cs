
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
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties21 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties22 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties23 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties24 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
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
            this.dtgv_ttkh.Location = new System.Drawing.Point(13, 65);
            this.dtgv_ttkh.Margin = new System.Windows.Forms.Padding(4);
            this.dtgv_ttkh.Name = "dtgv_ttkh";
            this.dtgv_ttkh.ReadOnly = true;
            this.dtgv_ttkh.RowTemplate.Height = 24;
            this.dtgv_ttkh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_ttkh.Size = new System.Drawing.Size(531, 381);
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
            this.txtMatKhau.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.txtMatKhau.DefaultText = "";
            this.txtMatKhau.FillColor = System.Drawing.Color.White;
            this.txtMatKhau.ForeColor = System.Drawing.Color.Silver;
            this.txtMatKhau.HideSelection = true;
            this.txtMatKhau.IconLeft = null;
            this.txtMatKhau.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.IconPadding = 10;
            this.txtMatKhau.IconRight = null;
            this.txtMatKhau.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.Lines = new string[0];
            this.txtMatKhau.Location = new System.Drawing.Point(126, 203);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.MaxLength = 32767;
            this.txtMatKhau.MinimumSize = new System.Drawing.Size(150, 48);
            this.txtMatKhau.Modified = false;
            this.txtMatKhau.Multiline = false;
            this.txtMatKhau.Name = "txtMatKhau";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMatKhau.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.Empty;
            stateProperties14.FillColor = System.Drawing.Color.White;
            stateProperties14.ForeColor = System.Drawing.Color.Empty;
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMatKhau.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMatKhau.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Silver;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMatKhau.OnIdleState = stateProperties16;
            this.txtMatKhau.PasswordChar = '\0';
            this.txtMatKhau.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMatKhau.PlaceholderText = "";
            this.txtMatKhau.ReadOnly = false;
            this.txtMatKhau.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.SelectionLength = 0;
            this.txtMatKhau.SelectionStart = 0;
            this.txtMatKhau.ShortcutsEnabled = true;
            this.txtMatKhau.Size = new System.Drawing.Size(300, 48);
            this.txtMatKhau.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtMatKhau.TabIndex = 24;
            this.txtMatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMatKhau.TextMarginBottom = 0;
            this.txtMatKhau.TextMarginLeft = 5;
            this.txtMatKhau.TextMarginTop = 0;
            this.txtMatKhau.TextPlaceholder = "";
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
            this.txtTaiKhoan.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.txtTaiKhoan.DefaultText = "";
            this.txtTaiKhoan.FillColor = System.Drawing.Color.White;
            this.txtTaiKhoan.ForeColor = System.Drawing.Color.Silver;
            this.txtTaiKhoan.HideSelection = true;
            this.txtTaiKhoan.IconLeft = null;
            this.txtTaiKhoan.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaiKhoan.IconPadding = 10;
            this.txtTaiKhoan.IconRight = null;
            this.txtTaiKhoan.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaiKhoan.Lines = new string[0];
            this.txtTaiKhoan.Location = new System.Drawing.Point(126, 114);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaiKhoan.MaxLength = 32767;
            this.txtTaiKhoan.MinimumSize = new System.Drawing.Size(150, 48);
            this.txtTaiKhoan.Modified = false;
            this.txtTaiKhoan.Multiline = false;
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            stateProperties17.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTaiKhoan.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.Empty;
            stateProperties18.FillColor = System.Drawing.Color.White;
            stateProperties18.ForeColor = System.Drawing.Color.Empty;
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTaiKhoan.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTaiKhoan.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.Silver;
            stateProperties20.FillColor = System.Drawing.Color.White;
            stateProperties20.ForeColor = System.Drawing.Color.Silver;
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTaiKhoan.OnIdleState = stateProperties20;
            this.txtTaiKhoan.PasswordChar = '\0';
            this.txtTaiKhoan.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTaiKhoan.PlaceholderText = "";
            this.txtTaiKhoan.ReadOnly = false;
            this.txtTaiKhoan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTaiKhoan.SelectedText = "";
            this.txtTaiKhoan.SelectionLength = 0;
            this.txtTaiKhoan.SelectionStart = 0;
            this.txtTaiKhoan.ShortcutsEnabled = true;
            this.txtTaiKhoan.Size = new System.Drawing.Size(300, 48);
            this.txtTaiKhoan.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtTaiKhoan.TabIndex = 23;
            this.txtTaiKhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTaiKhoan.TextMarginBottom = 0;
            this.txtTaiKhoan.TextMarginLeft = 5;
            this.txtTaiKhoan.TextMarginTop = 0;
            this.txtTaiKhoan.TextPlaceholder = "";
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
            this.txtmanhanvien.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.txtmanhanvien.DefaultText = "";
            this.txtmanhanvien.Enabled = false;
            this.txtmanhanvien.FillColor = System.Drawing.Color.White;
            this.txtmanhanvien.ForeColor = System.Drawing.Color.Silver;
            this.txtmanhanvien.HideSelection = true;
            this.txtmanhanvien.IconLeft = null;
            this.txtmanhanvien.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmanhanvien.IconPadding = 10;
            this.txtmanhanvien.IconRight = null;
            this.txtmanhanvien.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmanhanvien.Lines = new string[0];
            this.txtmanhanvien.Location = new System.Drawing.Point(126, 43);
            this.txtmanhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.txtmanhanvien.MaxLength = 32767;
            this.txtmanhanvien.MinimumSize = new System.Drawing.Size(150, 48);
            this.txtmanhanvien.Modified = false;
            this.txtmanhanvien.Multiline = false;
            this.txtmanhanvien.Name = "txtmanhanvien";
            stateProperties21.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties21.FillColor = System.Drawing.Color.Empty;
            stateProperties21.ForeColor = System.Drawing.Color.Empty;
            stateProperties21.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtmanhanvien.OnActiveState = stateProperties21;
            stateProperties22.BorderColor = System.Drawing.Color.Empty;
            stateProperties22.FillColor = System.Drawing.Color.White;
            stateProperties22.ForeColor = System.Drawing.Color.Empty;
            stateProperties22.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtmanhanvien.OnDisabledState = stateProperties22;
            stateProperties23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties23.FillColor = System.Drawing.Color.Empty;
            stateProperties23.ForeColor = System.Drawing.Color.Empty;
            stateProperties23.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtmanhanvien.OnHoverState = stateProperties23;
            stateProperties24.BorderColor = System.Drawing.Color.Silver;
            stateProperties24.FillColor = System.Drawing.Color.White;
            stateProperties24.ForeColor = System.Drawing.Color.Silver;
            stateProperties24.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtmanhanvien.OnIdleState = stateProperties24;
            this.txtmanhanvien.PasswordChar = '\0';
            this.txtmanhanvien.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtmanhanvien.PlaceholderText = "";
            this.txtmanhanvien.ReadOnly = false;
            this.txtmanhanvien.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtmanhanvien.SelectedText = "";
            this.txtmanhanvien.SelectionLength = 0;
            this.txtmanhanvien.SelectionStart = 0;
            this.txtmanhanvien.ShortcutsEnabled = true;
            this.txtmanhanvien.Size = new System.Drawing.Size(300, 48);
            this.txtmanhanvien.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtmanhanvien.TabIndex = 29;
            this.txtmanhanvien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtmanhanvien.TextMarginBottom = 0;
            this.txtmanhanvien.TextMarginLeft = 5;
            this.txtmanhanvien.TextMarginTop = 0;
            this.txtmanhanvien.TextPlaceholder = "";
            this.txtmanhanvien.UseSystemPasswordChar = false;
            this.txtmanhanvien.WordWrap = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(176, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(580, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(451, 273);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "Mật khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 31;
            this.label3.Text = "Tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Mã NV:";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::demo1.Properties.Resources.note_edit;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(916, 369);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 89);
            this.button2.TabIndex = 34;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::demo1.Properties.Resources.delete;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(749, 369);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 89);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnthem
            // 
            this.btnthem.BackgroundImage = global::demo1.Properties.Resources.add;
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(580, 369);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(90, 89);
            this.btnthem.TabIndex = 32;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1043, 471);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgv_ttkh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaiKhoan";
            this.Load += new System.EventHandler(this.TaiKhoan_Load);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnthem;
    }
}