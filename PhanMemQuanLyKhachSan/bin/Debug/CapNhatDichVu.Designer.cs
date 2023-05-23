namespace PhanMemQuanLyKhachSan
{
    partial class frmCapNhatDichVu
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
            this.lblDichVuKhachSan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoatCapNhatDichVu = new System.Windows.Forms.Button();
            this.btnLuuCapNhatDichVu = new System.Windows.Forms.Button();
            this.btnThemDichVu = new System.Windows.Forms.Button();
            this.btnXoaDichVu = new System.Windows.Forms.Button();
            this.dgvCapNhatDichVu = new System.Windows.Forms.DataGridView();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.txtGiaGV = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.DichVuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDichVuID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDichVuKhachSan
            // 
            this.lblDichVuKhachSan.AutoSize = true;
            this.lblDichVuKhachSan.BackColor = System.Drawing.Color.Transparent;
            this.lblDichVuKhachSan.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDichVuKhachSan.Location = new System.Drawing.Point(431, 11);
            this.lblDichVuKhachSan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDichVuKhachSan.Name = "lblDichVuKhachSan";
            this.lblDichVuKhachSan.Size = new System.Drawing.Size(424, 60);
            this.lblDichVuKhachSan.TabIndex = 0;
            this.lblDichVuKhachSan.Text = "Dịch Vụ Khách Sạn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // btnThoatCapNhatDichVu
            // 
            this.btnThoatCapNhatDichVu.BackColor = System.Drawing.Color.Pink;
            this.btnThoatCapNhatDichVu.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatCapNhatDichVu.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconBack;
            this.btnThoatCapNhatDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatCapNhatDichVu.Location = new System.Drawing.Point(16, 14);
            this.btnThoatCapNhatDichVu.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoatCapNhatDichVu.Name = "btnThoatCapNhatDichVu";
            this.btnThoatCapNhatDichVu.Size = new System.Drawing.Size(135, 55);
            this.btnThoatCapNhatDichVu.TabIndex = 2;
            this.btnThoatCapNhatDichVu.Text = "Trở Về";
            this.btnThoatCapNhatDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoatCapNhatDichVu.UseVisualStyleBackColor = false;
            this.btnThoatCapNhatDichVu.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnLuuCapNhatDichVu
            // 
            this.btnLuuCapNhatDichVu.BackColor = System.Drawing.Color.Pink;
            this.btnLuuCapNhatDichVu.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuCapNhatDichVu.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconLuu;
            this.btnLuuCapNhatDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuCapNhatDichVu.Location = new System.Drawing.Point(1191, 268);
            this.btnLuuCapNhatDichVu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuuCapNhatDichVu.Name = "btnLuuCapNhatDichVu";
            this.btnLuuCapNhatDichVu.Size = new System.Drawing.Size(112, 55);
            this.btnLuuCapNhatDichVu.TabIndex = 3;
            this.btnLuuCapNhatDichVu.Text = "Lưu";
            this.btnLuuCapNhatDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuCapNhatDichVu.UseVisualStyleBackColor = false;
            this.btnLuuCapNhatDichVu.Click += new System.EventHandler(this.btnLuuCapNhatDichVu_Click);
            // 
            // btnThemDichVu
            // 
            this.btnThemDichVu.BackColor = System.Drawing.Color.Pink;
            this.btnThemDichVu.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDichVu.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconThem;
            this.btnThemDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDichVu.Location = new System.Drawing.Point(781, 268);
            this.btnThemDichVu.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemDichVu.Name = "btnThemDichVu";
            this.btnThemDichVu.Size = new System.Drawing.Size(203, 55);
            this.btnThemDichVu.TabIndex = 4;
            this.btnThemDichVu.Text = "Thêm Dịch Vụ";
            this.btnThemDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemDichVu.UseVisualStyleBackColor = false;
            this.btnThemDichVu.Click += new System.EventHandler(this.btnThemDichVu_Click);
            // 
            // btnXoaDichVu
            // 
            this.btnXoaDichVu.BackColor = System.Drawing.Color.Pink;
            this.btnXoaDichVu.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDichVu.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconDelete;
            this.btnXoaDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDichVu.Location = new System.Drawing.Point(992, 268);
            this.btnXoaDichVu.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaDichVu.Name = "btnXoaDichVu";
            this.btnXoaDichVu.Size = new System.Drawing.Size(191, 55);
            this.btnXoaDichVu.TabIndex = 5;
            this.btnXoaDichVu.Text = "Xóa Dịch Vụ";
            this.btnXoaDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaDichVu.UseVisualStyleBackColor = false;
            this.btnXoaDichVu.Click += new System.EventHandler(this.btnXoaDichVu_Click);
            // 
            // dgvCapNhatDichVu
            // 
            this.dgvCapNhatDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCapNhatDichVu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCapNhatDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapNhatDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DichVuID,
            this.TenDichVu,
            this.GiaDV});
            this.dgvCapNhatDichVu.Location = new System.Drawing.Point(35, 91);
            this.dgvCapNhatDichVu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCapNhatDichVu.Name = "dgvCapNhatDichVu";
            this.dgvCapNhatDichVu.ReadOnly = true;
            this.dgvCapNhatDichVu.RowHeadersWidth = 51;
            this.dgvCapNhatDichVu.Size = new System.Drawing.Size(723, 726);
            this.dgvCapNhatDichVu.TabIndex = 6;
            this.dgvCapNhatDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cell_Click);
            this.dgvCapNhatDichVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCapNhatDichVu_CellContentClick);
            // 
            // txtTenDV
            // 
            this.txtTenDV.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDV.Location = new System.Drawing.Point(791, 133);
            this.txtTenDV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDV.Multiline = true;
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(511, 45);
            this.txtTenDV.TabIndex = 7;
            // 
            // txtGiaGV
            // 
            this.txtGiaGV.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaGV.Location = new System.Drawing.Point(791, 186);
            this.txtGiaGV.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaGV.Multiline = true;
            this.txtGiaGV.Name = "txtGiaGV";
            this.txtGiaGV.Size = new System.Drawing.Size(511, 50);
            this.txtGiaGV.TabIndex = 7;
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.Pink;
            this.btnIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIn.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.btnIn.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconIn;
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(992, 358);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(191, 55);
            this.btnIn.TabIndex = 90;
            this.btnIn.Text = "in báo cáo";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // DichVuID
            // 
            this.DichVuID.DataPropertyName = "DichVuID";
            this.DichVuID.FillWeight = 38.07107F;
            this.DichVuID.HeaderText = "DichVuID";
            this.DichVuID.MinimumWidth = 6;
            this.DichVuID.Name = "DichVuID";
            this.DichVuID.ReadOnly = true;
            // 
            // TenDichVu
            // 
            this.TenDichVu.DataPropertyName = "TenDV";
            this.TenDichVu.FillWeight = 130.9645F;
            this.TenDichVu.HeaderText = "Tên Dịch Vụ";
            this.TenDichVu.MinimumWidth = 6;
            this.TenDichVu.Name = "TenDichVu";
            this.TenDichVu.ReadOnly = true;
            // 
            // GiaDV
            // 
            this.GiaDV.DataPropertyName = "GiaDV";
            this.GiaDV.FillWeight = 130.9645F;
            this.GiaDV.HeaderText = "Giá Dịch Vụ";
            this.GiaDV.MinimumWidth = 6;
            this.GiaDV.Name = "GiaDV";
            this.GiaDV.ReadOnly = true;
            // 
            // txtDichVuID
            // 
            this.txtDichVuID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDichVuID.Location = new System.Drawing.Point(791, 80);
            this.txtDichVuID.Margin = new System.Windows.Forms.Padding(4);
            this.txtDichVuID.Multiline = true;
            this.txtDichVuID.Name = "txtDichVuID";
            this.txtDichVuID.Size = new System.Drawing.Size(511, 45);
            this.txtDichVuID.TabIndex = 91;
            // 
            // frmCapNhatDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhanMemQuanLyKhachSan.Properties.Resources.b14;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1319, 832);
            this.Controls.Add(this.txtDichVuID);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txtGiaGV);
            this.Controls.Add(this.txtTenDV);
            this.Controls.Add(this.dgvCapNhatDichVu);
            this.Controls.Add(this.btnXoaDichVu);
            this.Controls.Add(this.btnThemDichVu);
            this.Controls.Add(this.btnLuuCapNhatDichVu);
            this.Controls.Add(this.btnThoatCapNhatDichVu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDichVuKhachSan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCapNhatDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Dịch Vụ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCapNhatDichVu_FormClosing);
            this.Load += new System.EventHandler(this.frmCapNhatDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDichVuKhachSan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoatCapNhatDichVu;
        private System.Windows.Forms.Button btnLuuCapNhatDichVu;
        private System.Windows.Forms.Button btnThemDichVu;
        private System.Windows.Forms.Button btnXoaDichVu;
        private System.Windows.Forms.DataGridView dgvCapNhatDichVu;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.TextBox txtGiaGV;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DichVuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaDV;
        private System.Windows.Forms.TextBox txtDichVuID;
    }
}