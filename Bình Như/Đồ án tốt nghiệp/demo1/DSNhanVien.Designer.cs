
namespace demo1
{
    partial class DSNhanVien
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.NhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoDataSet = new demo1.demoDataSet();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.directoryEntry2 = new System.DirectoryServices.DirectoryEntry();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NhanVienTableAdapter = new demo1.demoDataSetTableAdapters.NhanVienTableAdapter();
            this.directoryEntry3 = new System.DirectoryServices.DirectoryEntry();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // NhanVienBindingSource
            // 
            this.NhanVienBindingSource.DataMember = "NhanVien";
            this.NhanVienBindingSource.DataSource = this.demoDataSet;
            // 
            // demoDataSet
            // 
            this.demoDataSet.DataSetName = "demoDataSet";
            this.demoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.NhanVienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "demo1.DSNhanVien.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 55);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(776, 383);
            this.reportViewer1.TabIndex = 0;
            // 
            // NhanVienTableAdapter
            // 
            this.NhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // DSNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "DSNhanVien";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.DSNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.DirectoryServices.DirectoryEntry directoryEntry2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NhanVienBindingSource;
        private demoDataSet demoDataSet;
        private demoDataSetTableAdapters.NhanVienTableAdapter NhanVienTableAdapter;
        private System.DirectoryServices.DirectoryEntry directoryEntry3;
    }
}