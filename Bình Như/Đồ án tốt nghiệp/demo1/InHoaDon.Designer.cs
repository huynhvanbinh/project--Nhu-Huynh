
namespace demo1
{
    partial class InHoaDon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InHoaDon));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CTHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoDataSet = new demo1.demoDataSet();
            this.HoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CTHoaDonTableAdapter = new demo1.demoDataSetTableAdapters.CTHoaDonTableAdapter();
            this.HoaDonTableAdapter = new demo1.demoDataSetTableAdapters.HoaDonTableAdapter();
            this.txtMaChucVu = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.Them = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.NhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NhanVienTableAdapter = new demo1.demoDataSetTableAdapters.NhanVienTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SanPhamTableAdapter = new demo1.demoDataSetTableAdapters.SanPhamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CTHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CTHoaDonBindingSource
            // 
            this.CTHoaDonBindingSource.DataMember = "CTHoaDon";
            this.CTHoaDonBindingSource.DataSource = this.demoDataSet;
            // 
            // demoDataSet
            // 
            this.demoDataSet.DataSetName = "demoDataSet";
            this.demoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HoaDonBindingSource
            // 
            this.HoaDonBindingSource.DataMember = "HoaDon";
            this.HoaDonBindingSource.DataSource = this.demoDataSet;
            // 
            // CTHoaDonTableAdapter
            // 
            this.CTHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // HoaDonTableAdapter
            // 
            this.HoaDonTableAdapter.ClearBeforeFill = true;
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
            this.txtMaChucVu.HideSelection = true;
            this.txtMaChucVu.IconLeft = null;
            this.txtMaChucVu.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaChucVu.IconPadding = 10;
            this.txtMaChucVu.IconRight = null;
            this.txtMaChucVu.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaChucVu.Lines = new string[0];
            this.txtMaChucVu.Location = new System.Drawing.Point(129, 39);
            this.txtMaChucVu.MaxLength = 32767;
            this.txtMaChucVu.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtMaChucVu.Modified = false;
            this.txtMaChucVu.Multiline = false;
            this.txtMaChucVu.Name = "txtMaChucVu";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMaChucVu.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMaChucVu.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMaChucVu.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMaChucVu.OnIdleState = stateProperties4;
            this.txtMaChucVu.PasswordChar = '\0';
            this.txtMaChucVu.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMaChucVu.PlaceholderText = "Nhập mã hóa đơn";
            this.txtMaChucVu.ReadOnly = false;
            this.txtMaChucVu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaChucVu.SelectedText = "";
            this.txtMaChucVu.SelectionLength = 0;
            this.txtMaChucVu.SelectionStart = 0;
            this.txtMaChucVu.ShortcutsEnabled = true;
            this.txtMaChucVu.Size = new System.Drawing.Size(200, 35);
            this.txtMaChucVu.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtMaChucVu.TabIndex = 15;
            this.txtMaChucVu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaChucVu.TextMarginBottom = 0;
            this.txtMaChucVu.TextMarginLeft = 5;
            this.txtMaChucVu.TextMarginTop = 0;
            this.txtMaChucVu.TextPlaceholder = "Nhập mã hóa đơn";
            this.txtMaChucVu.UseSystemPasswordChar = false;
            this.txtMaChucVu.WordWrap = true;
            // 
            // Them
            // 
            this.Them.AllowToggling = false;
            this.Them.AnimationSpeed = 200;
            this.Them.AutoGenerateColors = false;
            this.Them.BackColor = System.Drawing.Color.Transparent;
            this.Them.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.Them.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Them.BackgroundImage")));
            this.Them.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Them.ButtonText = "Xem";
            this.Them.ButtonTextMarginLeft = 0;
            this.Them.ColorContrastOnClick = 45;
            this.Them.ColorContrastOnHover = 45;
            this.Them.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.Them.CustomizableEdges = borderEdges1;
            this.Them.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Them.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Them.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Them.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Them.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Them.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.Them.ForeColor = System.Drawing.Color.White;
            this.Them.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.Them.IconMarginLeft = 11;
            this.Them.IconPadding = 10;
            this.Them.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.Them.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.Them.IdleBorderRadius = 3;
            this.Them.IdleBorderThickness = 1;
            this.Them.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.Them.IdleIconLeftImage = null;
            this.Them.IdleIconRightImage = null;
            this.Them.IndicateFocus = false;
            this.Them.Location = new System.Drawing.Point(351, 39);
            this.Them.Name = "Them";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.BorderRadius = 3;
            stateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties5.BorderThickness = 1;
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.ForeColor = System.Drawing.Color.White;
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.Them.onHoverState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.BorderRadius = 3;
            stateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties6.BorderThickness = 1;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.ForeColor = System.Drawing.Color.White;
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.Them.OnPressedState = stateProperties6;
            this.Them.Size = new System.Drawing.Size(65, 35);
            this.Them.TabIndex = 17;
            this.Them.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Them.TextMarginLeft = 0;
            this.Them.UseDefaultRadiusAndThickness = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // NhanVienBindingSource
            // 
            this.NhanVienBindingSource.DataMember = "NhanVien";
            this.NhanVienBindingSource.DataSource = this.demoDataSet;
            // 
            // NhanVienTableAdapter
            // 
            this.NhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CTHoaDonBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.HoaDonBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.SanPhamBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "demo1.InHoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 109);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(865, 426);
            this.reportViewer1.TabIndex = 18;
            // 
            // SanPhamBindingSource
            // 
            this.SanPhamBindingSource.DataMember = "SanPham";
            this.SanPhamBindingSource.DataSource = this.demoDataSet;
            // 
            // SanPhamTableAdapter
            // 
            this.SanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // InHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::demo1.Properties.Resources.anhnen1;
            this.ClientSize = new System.Drawing.Size(900, 547);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.txtMaChucVu);
            this.Name = "InHoaDon";
            this.Text = "InHoaDon";
            this.Load += new System.EventHandler(this.InHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CTHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource CTHoaDonBindingSource;
        private demoDataSet demoDataSet;
        private demoDataSetTableAdapters.CTHoaDonTableAdapter CTHoaDonTableAdapter;
        private System.Windows.Forms.BindingSource HoaDonBindingSource;
        private demoDataSetTableAdapters.HoaDonTableAdapter HoaDonTableAdapter;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtMaChucVu;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Them;
        private System.Windows.Forms.BindingSource NhanVienBindingSource;
        private demoDataSetTableAdapters.NhanVienTableAdapter NhanVienTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SanPhamBindingSource;
        private demoDataSetTableAdapters.SanPhamTableAdapter SanPhamTableAdapter;
    }
}