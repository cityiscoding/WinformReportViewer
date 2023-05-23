namespace PhanMemQuanLyKhachSan.Report_Form
{
    partial class DichVu_Report_Form
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pMQLKSDataSet = new PhanMemQuanLyKhachSan.PMQLKSDataSet();
            this.pMQLKSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dichVuDataSet = new PhanMemQuanLyKhachSan.DichVuDataSet();
            this.dichVuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dichVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dichVuTableAdapter = new PhanMemQuanLyKhachSan.DichVuDataSetTableAdapters.DichVuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pMQLKSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMQLKSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.dichVuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PhanMemQuanLyKhachSan.Report_Auth.DichVu_Report_Auth.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1149, 866);
            this.reportViewer1.TabIndex = 0;
            // 
            // pMQLKSDataSet
            // 
            this.pMQLKSDataSet.DataSetName = "PMQLKSDataSet";
            this.pMQLKSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pMQLKSDataSetBindingSource
            // 
            this.pMQLKSDataSetBindingSource.DataSource = this.pMQLKSDataSet;
            this.pMQLKSDataSetBindingSource.Position = 0;
            // 
            // dichVuDataSet
            // 
            this.dichVuDataSet.DataSetName = "DichVuDataSet";
            this.dichVuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dichVuDataSetBindingSource
            // 
            this.dichVuDataSetBindingSource.DataSource = this.dichVuDataSet;
            this.dichVuDataSetBindingSource.Position = 0;
            // 
            // dichVuBindingSource
            // 
            this.dichVuBindingSource.DataMember = "DichVu";
            this.dichVuBindingSource.DataSource = this.dichVuDataSetBindingSource;
            // 
            // dichVuTableAdapter
            // 
            this.dichVuTableAdapter.ClearBeforeFill = true;
            // 
            // DichVu_Report_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 866);
            this.Controls.Add(this.reportViewer1);
            this.Name = "DichVu_Report_Form";
            this.Text = "DichVu_Report_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DichVu_Report_Form_FormClosing);
            this.Load += new System.EventHandler(this.DichVu_Report_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pMQLKSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMQLKSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dichVuDataSetBindingSource;
        private DichVuDataSet dichVuDataSet;
        private PMQLKSDataSet pMQLKSDataSet;
        private System.Windows.Forms.BindingSource pMQLKSDataSetBindingSource;
        private System.Windows.Forms.BindingSource dichVuBindingSource;
        private DichVuDataSetTableAdapters.DichVuTableAdapter dichVuTableAdapter;
    }
}