
namespace demo1
{
    partial class Size
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Size));
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
            this.col_MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcannang = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtTenChucVu = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtMaChucVu = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
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
            this.col_MaNV,
            this.TenNv,
            this.Column1});
            this.dtgv_ttkh.Location = new System.Drawing.Point(12, 47);
            this.dtgv_ttkh.Name = "dtgv_ttkh";
            this.dtgv_ttkh.ReadOnly = true;
            this.dtgv_ttkh.RowTemplate.Height = 24;
            this.dtgv_ttkh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_ttkh.Size = new System.Drawing.Size(407, 275);
            this.dtgv_ttkh.TabIndex = 22;
            this.dtgv_ttkh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ttkh_CellClick);
            // 
            // col_MaNV
            // 
            this.col_MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_MaNV.DataPropertyName = "MaSize";
            this.col_MaNV.HeaderText = "Mã Sze";
            this.col_MaNV.Name = "col_MaNV";
            this.col_MaNV.ReadOnly = true;
            // 
            // TenNv
            // 
            this.TenNv.DataPropertyName = "TenSize";
            this.TenNv.HeaderText = "Tên Size";
            this.TenNv.Name = "TenNv";
            this.TenNv.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CanNang";
            this.Column1.HeaderText = "Cân nặng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // txtcannang
            // 
            this.txtcannang.AcceptsReturn = false;
            this.txtcannang.AcceptsTab = false;
            this.txtcannang.AnimationSpeed = 200;
            this.txtcannang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtcannang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtcannang.BackColor = System.Drawing.Color.Transparent;
            this.txtcannang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtcannang.BackgroundImage")));
            this.txtcannang.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtcannang.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtcannang.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtcannang.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtcannang.BorderRadius = 1;
            this.txtcannang.BorderThickness = 1;
            this.txtcannang.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtcannang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcannang.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtcannang.DefaultText = "";
            this.txtcannang.FillColor = System.Drawing.Color.White;
            this.txtcannang.ForeColor = System.Drawing.Color.Black;
            this.txtcannang.HideSelection = true;
            this.txtcannang.IconLeft = null;
            this.txtcannang.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcannang.IconPadding = 10;
            this.txtcannang.IconRight = null;
            this.txtcannang.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcannang.Lines = new string[0];
            this.txtcannang.Location = new System.Drawing.Point(89, 138);
            this.txtcannang.MaxLength = 32767;
            this.txtcannang.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtcannang.Modified = false;
            this.txtcannang.Multiline = false;
            this.txtcannang.Name = "txtcannang";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtcannang.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtcannang.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtcannang.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Black;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtcannang.OnIdleState = stateProperties4;
            this.txtcannang.PasswordChar = '\0';
            this.txtcannang.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtcannang.PlaceholderText = "Nhập cân nặng";
            this.txtcannang.ReadOnly = false;
            this.txtcannang.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcannang.SelectedText = "";
            this.txtcannang.SelectionLength = 0;
            this.txtcannang.SelectionStart = 0;
            this.txtcannang.ShortcutsEnabled = true;
            this.txtcannang.Size = new System.Drawing.Size(200, 35);
            this.txtcannang.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtcannang.TabIndex = 29;
            this.txtcannang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcannang.TextMarginBottom = 0;
            this.txtcannang.TextMarginLeft = 5;
            this.txtcannang.TextMarginTop = 0;
            this.txtcannang.TextPlaceholder = "Nhập cân nặng";
            this.txtcannang.UseSystemPasswordChar = false;
            this.txtcannang.WordWrap = true;
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
            this.txtTenChucVu.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
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
            this.txtTenChucVu.Location = new System.Drawing.Point(89, 88);
            this.txtTenChucVu.MaxLength = 32767;
            this.txtTenChucVu.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtTenChucVu.Modified = false;
            this.txtTenChucVu.Multiline = false;
            this.txtTenChucVu.Name = "txtTenChucVu";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTenChucVu.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Empty;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTenChucVu.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTenChucVu.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Black;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTenChucVu.OnIdleState = stateProperties8;
            this.txtTenChucVu.PasswordChar = '\0';
            this.txtTenChucVu.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTenChucVu.PlaceholderText = "Nhập kích thước";
            this.txtTenChucVu.ReadOnly = false;
            this.txtTenChucVu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenChucVu.SelectedText = "";
            this.txtTenChucVu.SelectionLength = 0;
            this.txtTenChucVu.SelectionStart = 0;
            this.txtTenChucVu.ShortcutsEnabled = true;
            this.txtTenChucVu.Size = new System.Drawing.Size(200, 35);
            this.txtTenChucVu.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtTenChucVu.TabIndex = 24;
            this.txtTenChucVu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenChucVu.TextMarginBottom = 0;
            this.txtTenChucVu.TextMarginLeft = 5;
            this.txtTenChucVu.TextMarginTop = 0;
            this.txtTenChucVu.TextPlaceholder = "Nhập kích thước";
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
            this.txtMaChucVu.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
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
            this.txtMaChucVu.Location = new System.Drawing.Point(89, 38);
            this.txtMaChucVu.MaxLength = 32767;
            this.txtMaChucVu.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtMaChucVu.Modified = false;
            this.txtMaChucVu.Multiline = false;
            this.txtMaChucVu.Name = "txtMaChucVu";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMaChucVu.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.Empty;
            stateProperties10.FillColor = System.Drawing.Color.White;
            stateProperties10.ForeColor = System.Drawing.Color.Empty;
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMaChucVu.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMaChucVu.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Black;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMaChucVu.OnIdleState = stateProperties12;
            this.txtMaChucVu.PasswordChar = '\0';
            this.txtMaChucVu.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMaChucVu.PlaceholderText = "Nhập kích thước";
            this.txtMaChucVu.ReadOnly = false;
            this.txtMaChucVu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaChucVu.SelectedText = "";
            this.txtMaChucVu.SelectionLength = 0;
            this.txtMaChucVu.SelectionStart = 0;
            this.txtMaChucVu.ShortcutsEnabled = true;
            this.txtMaChucVu.Size = new System.Drawing.Size(200, 35);
            this.txtMaChucVu.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtMaChucVu.TabIndex = 23;
            this.txtMaChucVu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaChucVu.TextMarginBottom = 0;
            this.txtMaChucVu.TextMarginLeft = 5;
            this.txtMaChucVu.TextMarginTop = 0;
            this.txtMaChucVu.TextPlaceholder = "Nhập kích thước";
            this.txtMaChucVu.UseSystemPasswordChar = false;
            this.txtMaChucVu.WordWrap = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(221, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "Kích Thước Sản Phẩm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaChucVu);
            this.groupBox1.Controls.Add(this.txtTenChucVu);
            this.groupBox1.Controls.Add(this.txtcannang);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(425, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 201);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Cân Nặng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Tên Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Mã Size:";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::demo1.Properties.Resources.tải_xuống;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(674, 258);
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
            this.button2.Location = new System.Drawing.Point(593, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 64);
            this.button2.TabIndex = 34;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::demo1.Properties.Resources.delete;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(505, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 64);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackgroundImage = global::demo1.Properties.Resources.add;
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(425, 258);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(60, 64);
            this.btnthem.TabIndex = 32;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // Size
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(764, 346);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgv_ttkh);
            this.Name = "Size";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Size";
            this.Load += new System.EventHandler(this.Size_Load);
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
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtcannang;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
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