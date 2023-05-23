namespace PhanMemQuanLyKhachSan.Report_Form
{
    partial class QuanLyNhanVien_Report_Form
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pMQLKSDataSet2 = new PhanMemQuanLyKhachSan.PMQLKSDataSet2();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new PhanMemQuanLyKhachSan.PMQLKSDataSet2TableAdapters.NhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pMQLKSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetNhanVIen";
            reportDataSource1.Value = this.nhanVienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PhanMemQuanLyKhachSan.Report_Auth.ThongTinNhanVIen.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1319, 832);
            this.reportViewer1.TabIndex = 0;
            // 
            // pMQLKSDataSet2
            // 
            this.pMQLKSDataSet2.DataSetName = "PMQLKSDataSet2";
            this.pMQLKSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.pMQLKSDataSet2;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // QuanLyNhanVien_Report_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 832);
            this.Controls.Add(this.reportViewer1);
            this.Name = "QuanLyNhanVien_Report_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyNhanVien_Report_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuanLyNhanVien_Report_Form_FormClosing);
            this.Load += new System.EventHandler(this.QuanLyNhanVien_Report_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pMQLKSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private PMQLKSDataSet2 pMQLKSDataSet2;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private PMQLKSDataSet2TableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
    }
}