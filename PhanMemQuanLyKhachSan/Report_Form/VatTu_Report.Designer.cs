namespace PhanMemQuanLyKhachSan
{
    partial class frmVatTuRP
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
            this.vatTuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pMQLKSDataSet = new PhanMemQuanLyKhachSan.PMQLKSDataSet();
            this.EXITRPvattu = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vatTuTableAdapter = new PhanMemQuanLyKhachSan.PMQLKSDataSetTableAdapters.VatTuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vatTuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMQLKSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // vatTuBindingSource
            // 
            this.vatTuBindingSource.DataMember = "VatTu";
            this.vatTuBindingSource.DataSource = this.pMQLKSDataSet;
            // 
            // pMQLKSDataSet
            // 
            this.pMQLKSDataSet.DataSetName = "PMQLKSDataSet";
            this.pMQLKSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EXITRPvattu
            // 
            this.EXITRPvattu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EXITRPvattu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vatTuBindingSource;
            this.EXITRPvattu.LocalReport.DataSources.Add(reportDataSource1);
            this.EXITRPvattu.LocalReport.ReportEmbeddedResource = "PhanMemQuanLyKhachSan.Report_Auth.VatTu_Report_Auth.rdlc";
            this.EXITRPvattu.Location = new System.Drawing.Point(1, 1);
            this.EXITRPvattu.Name = "EXITRPvattu";
            this.EXITRPvattu.ServerReport.BearerToken = null;
            this.EXITRPvattu.Size = new System.Drawing.Size(1153, 654);
            this.EXITRPvattu.TabIndex = 0;
            // 
            // vatTuTableAdapter
            // 
            this.vatTuTableAdapter.ClearBeforeFill = true;
            // 
            // frmVatTuRP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 866);
            this.Controls.Add(this.EXITRPvattu);
            this.Name = "frmVatTuRP";
            this.Text = "VatTu_Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVatTuRP_FormClosing);
            this.Load += new System.EventHandler(this.VatTu_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vatTuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMQLKSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer EXITRPvattu;
        private PMQLKSDataSet pMQLKSDataSet;
        private System.Windows.Forms.BindingSource vatTuBindingSource;
        private PMQLKSDataSetTableAdapters.VatTuTableAdapter vatTuTableAdapter;
    }
}