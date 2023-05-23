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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vatTuTableAdapter = new PhanMemQuanLyKhachSan.PMQLKSDataSetTableAdapters.VatTuTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vatTuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PhanMemQuanLyKhachSan.Report_Auth.VatTu_Report_Auth.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 100);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1412, 555);
            this.reportViewer1.TabIndex = 0;
            // 
            // vatTuTableAdapter
            // 
            this.vatTuTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("JetBrains Mono NL", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(377, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(649, 57);
            this.label7.TabIndex = 1;
            this.label7.Text = "Báo cáo vật tư khách sạn";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono NL", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(871, 689);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ngày....Tháng....Năm...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono NL", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(915, 742);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Người làm báo cáo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono NL", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(946, 806);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trần Thành Phố";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmVatTuRP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 866);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmVatTuRP";
            this.Text = "VatTu_Report";
            this.Load += new System.EventHandler(this.VatTu_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vatTuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMQLKSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private PMQLKSDataSet pMQLKSDataSet;
        private System.Windows.Forms.BindingSource vatTuBindingSource;
        private PMQLKSDataSetTableAdapters.VatTuTableAdapter vatTuTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}