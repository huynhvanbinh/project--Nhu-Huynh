
namespace demo1
{
    partial class MauSac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MauSac));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties21 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties22 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties23 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties24 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.dtgv_ttkh = new System.Windows.Forms.DataGridView();
            this.col_MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenChucVu = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtMaChucVu = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
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
            this.dtgv_ttkh.Location = new System.Drawing.Point(12, 51);
            this.dtgv_ttkh.Name = "dtgv_ttkh";
            this.dtgv_ttkh.ReadOnly = true;
            this.dtgv_ttkh.RowTemplate.Height = 24;
            this.dtgv_ttkh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_ttkh.Size = new System.Drawing.Size(447, 275);
            this.dtgv_ttkh.TabIndex = 22;
            this.dtgv_ttkh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ttkh_CellClick);
            // 
            // col_MaNV
            // 
            this.col_MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_MaNV.DataPropertyName = "MaMau";
            this.col_MaNV.HeaderText = "Mã Màu";
            this.col_MaNV.Name = "col_MaNV";
            this.col_MaNV.ReadOnly = true;
            // 
            // TenNv
            // 
            this.TenNv.DataPropertyName = "TenMau";
            this.TenNv.HeaderText = "Tên Màu";
            this.TenNv.Name = "TenNv";
            this.TenNv.ReadOnly = true;
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
            this.txtTenChucVu.Location = new System.Drawing.Point(91, 118);
            this.txtTenChucVu.MaxLength = 32767;
            this.txtTenChucVu.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtTenChucVu.Modified = false;
            this.txtTenChucVu.Multiline = false;
            this.txtTenChucVu.Name = "txtTenChucVu";
            stateProperties17.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTenChucVu.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.Empty;
            stateProperties18.FillColor = System.Drawing.Color.White;
            stateProperties18.ForeColor = System.Drawing.Color.Empty;
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTenChucVu.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTenChucVu.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.Silver;
            stateProperties20.FillColor = System.Drawing.Color.White;
            stateProperties20.ForeColor = System.Drawing.Color.Black;
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTenChucVu.OnIdleState = stateProperties20;
            this.txtTenChucVu.PasswordChar = '\0';
            this.txtTenChucVu.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTenChucVu.PlaceholderText = "Nhập tên màu";
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
            this.txtMaChucVu.Location = new System.Drawing.Point(91, 51);
            this.txtMaChucVu.MaxLength = 32767;
            this.txtMaChucVu.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtMaChucVu.Modified = false;
            this.txtMaChucVu.Multiline = false;
            this.txtMaChucVu.Name = "txtMaChucVu";
            stateProperties21.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties21.FillColor = System.Drawing.Color.Empty;
            stateProperties21.ForeColor = System.Drawing.Color.Empty;
            stateProperties21.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMaChucVu.OnActiveState = stateProperties21;
            stateProperties22.BorderColor = System.Drawing.Color.Empty;
            stateProperties22.FillColor = System.Drawing.Color.White;
            stateProperties22.ForeColor = System.Drawing.Color.Empty;
            stateProperties22.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMaChucVu.OnDisabledState = stateProperties22;
            stateProperties23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties23.FillColor = System.Drawing.Color.Empty;
            stateProperties23.ForeColor = System.Drawing.Color.Empty;
            stateProperties23.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMaChucVu.OnHoverState = stateProperties23;
            stateProperties24.BorderColor = System.Drawing.Color.Silver;
            stateProperties24.FillColor = System.Drawing.Color.White;
            stateProperties24.ForeColor = System.Drawing.Color.Black;
            stateProperties24.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMaChucVu.OnIdleState = stateProperties24;
            this.txtMaChucVu.PasswordChar = '\0';
            this.txtMaChucVu.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMaChucVu.PlaceholderText = "Nhập màu";
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
            this.txtMaChucVu.TextPlaceholder = "Nhập màu";
            this.txtMaChucVu.UseSystemPasswordChar = false;
            this.txtMaChucVu.WordWrap = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 31);
            this.label1.TabIndex = 29;
            this.label1.Text = "Màu Sắc Cuộc Sống";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenChucVu);
            this.groupBox1.Controls.Add(this.txtMaChucVu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(478, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 192);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin màu cuộc sống";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tên Màu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mã Màu:";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::demo1.Properties.Resources.tải_xuống;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(728, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 64);
            this.button3.TabIndex = 34;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::demo1.Properties.Resources.note_edit;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(642, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 64);
            this.button2.TabIndex = 33;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::demo1.Properties.Resources.delete;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(559, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 64);
            this.button1.TabIndex = 32;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackgroundImage = global::demo1.Properties.Resources.add;
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(472, 262);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(60, 64);
            this.btnthem.TabIndex = 31;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // MauSac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(808, 350);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgv_ttkh);
            this.Name = "MauSac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MauSac";
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