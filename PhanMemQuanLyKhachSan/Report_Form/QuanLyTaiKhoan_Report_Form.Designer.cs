namespace PhanMemQuanLyKhachSan.Report_Form
{
    partial class frmRPQLTK
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.frm = new Microsoft.Reporting.WinForms.ReportViewer();
            this.matKhauBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matKhauBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pMQLKSDataSet1 = new PhanMemQuanLyKhachSan.PMQLKSDataSet1();
            this.matKhauBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.matKhauTableAdapter = new PhanMemQuanLyKhachSan.PMQLKSDataSet1TableAdapters.MatKhauTableAdapter();
            this.matKhauBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.matKhauBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matKhauBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMQLKSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matKhauBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matKhauBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // frm
            // 
            this.frm.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "MatKhauDataSet";
            reportDataSource3.Value = this.matKhauBindingSource;
            reportDataSource4.Name = "DataSetMatKhau";
            reportDataSource4.Value = this.matKhauBindingSource3;
            this.frm.LocalReport.DataSources.Add(reportDataSource3);
            this.frm.LocalReport.DataSources.Add(reportDataSource4);
            this.frm.LocalReport.ReportEmbeddedResource = "PhanMemQuanLyKhachSan.Report_Auth.QLTK_Report_Auth.rdlc";
            this.frm.Location = new System.Drawing.Point(0, 0);
            this.frm.Name = "frm";
            this.frm.ServerReport.BearerToken = null;
            this.frm.Size = new System.Drawing.Size(1319, 832);
            this.frm.TabIndex = 0;
            // 
            // matKhauBindingSource
            // 
            this.matKhauBindingSource.DataSource = typeof(PhanMemQuanLyKhachSan.Linq.MatKhau);
            // 
            // matKhauBindingSource1
            // 
            this.matKhauBindingSource1.DataSource = typeof(PhanMemQuanLyKhachSan.Linq.MatKhau);
            // 
            // pMQLKSDataSet1
            // 
            this.pMQLKSDataSet1.DataSetName = "PMQLKSDataSet1";
            this.pMQLKSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // matKhauBindingSource2
            // 
            this.matKhauBindingSource2.DataMember = "MatKhau";
            this.matKhauBindingSource2.DataSource = this.pMQLKSDataSet1;
            // 
            // matKhauTableAdapter
            // 
            this.matKhauTableAdapter.ClearBeforeFill = true;
            // 
            // matKhauBindingSource3
            // 
            this.matKhauBindingSource3.DataMember = "MatKhau";
            this.matKhauBindingSource3.DataSource = this.pMQLKSDataSet1;
            // 
            // frmRPQLTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 832);
            this.Controls.Add(this.frm);
            this.MaximizeBox = false;
            this.Name = "frmRPQLTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyTaiKhoan_Report_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRPQLTK_FormClosing);
            this.Load += new System.EventHandler(this.frmRPQLTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matKhauBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matKhauBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMQLKSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matKhauBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matKhauBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer frm;
        private System.Windows.Forms.BindingSource matKhauBindingSource;
        private System.Windows.Forms.BindingSource matKhauBindingSource1;
        private PMQLKSDataSet1 pMQLKSDataSet1;
        private System.Windows.Forms.BindingSource matKhauBindingSource2;
        private PMQLKSDataSet1TableAdapters.MatKhauTableAdapter matKhauTableAdapter;
        private System.Windows.Forms.BindingSource matKhauBindingSource3;
    }
}