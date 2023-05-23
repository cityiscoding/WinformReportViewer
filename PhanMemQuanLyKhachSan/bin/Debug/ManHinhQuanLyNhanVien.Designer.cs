namespace PhanMemQuanLyKhachSan
{
    partial class frmQuanLyNhanVien
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
            this.pnlQuanLyNhanVien = new System.Windows.Forms.Panel();
            this.btnCapNhatLichLamViecNV = new System.Windows.Forms.Button();
            this.btnCapNhatThongTinNV = new System.Windows.Forms.Button();
            this.lblQuanLyNhanVien = new System.Windows.Forms.Label();
            this.cdrQLNV = new System.Windows.Forms.MonthCalendar();
            this.pnlQLNV = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLichLamViec = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaTruc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTroVeCuaQLNV = new System.Windows.Forms.Button();
            this.btnInCuaCTPP = new System.Windows.Forms.Button();
            this.pnlQuanLyNhanVien.SuspendLayout();
            this.pnlQLNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichLamViec)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlQuanLyNhanVien
            // 
            this.pnlQuanLyNhanVien.BackColor = System.Drawing.Color.MistyRose;
            this.pnlQuanLyNhanVien.Controls.Add(this.btnInCuaCTPP);
            this.pnlQuanLyNhanVien.Controls.Add(this.btnCapNhatLichLamViecNV);
            this.pnlQuanLyNhanVien.Controls.Add(this.btnCapNhatThongTinNV);
            this.pnlQuanLyNhanVien.Location = new System.Drawing.Point(24, 83);
            this.pnlQuanLyNhanVien.Name = "pnlQuanLyNhanVien";
            this.pnlQuanLyNhanVien.Size = new System.Drawing.Size(225, 231);
            this.pnlQuanLyNhanVien.TabIndex = 0;
            // 
            // btnCapNhatLichLamViecNV
            // 
            this.btnCapNhatLichLamViecNV.BackColor = System.Drawing.Color.Turquoise;
            this.btnCapNhatLichLamViecNV.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatLichLamViecNV.Location = new System.Drawing.Point(3, 89);
            this.btnCapNhatLichLamViecNV.Name = "btnCapNhatLichLamViecNV";
            this.btnCapNhatLichLamViecNV.Size = new System.Drawing.Size(219, 46);
            this.btnCapNhatLichLamViecNV.TabIndex = 2;
            this.btnCapNhatLichLamViecNV.Text = "Cập nhật lịch làm việc";
            this.btnCapNhatLichLamViecNV.UseVisualStyleBackColor = false;
            this.btnCapNhatLichLamViecNV.Click += new System.EventHandler(this.BtnCapnhatlichlvnv_Click);
            // 
            // btnCapNhatThongTinNV
            // 
            this.btnCapNhatThongTinNV.BackColor = System.Drawing.Color.Turquoise;
            this.btnCapNhatThongTinNV.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatThongTinNV.Location = new System.Drawing.Point(3, 15);
            this.btnCapNhatThongTinNV.Name = "btnCapNhatThongTinNV";
            this.btnCapNhatThongTinNV.Size = new System.Drawing.Size(219, 46);
            this.btnCapNhatThongTinNV.TabIndex = 0;
            this.btnCapNhatThongTinNV.Text = "Cập nhật thông tin nhân viên";
            this.btnCapNhatThongTinNV.UseVisualStyleBackColor = false;
            this.btnCapNhatThongTinNV.Click += new System.EventHandler(this.btnCapnhatthongtinnv_Click);
            // 
            // lblQuanLyNhanVien
            // 
            this.lblQuanLyNhanVien.AutoSize = true;
            this.lblQuanLyNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.lblQuanLyNhanVien.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyNhanVien.Location = new System.Drawing.Point(539, 31);
            this.lblQuanLyNhanVien.Name = "lblQuanLyNhanVien";
            this.lblQuanLyNhanVien.Size = new System.Drawing.Size(434, 50);
            this.lblQuanLyNhanVien.TabIndex = 1;
            this.lblQuanLyNhanVien.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // cdrQLNV
            // 
            this.cdrQLNV.Location = new System.Drawing.Point(2, 380);
            this.cdrQLNV.Name = "cdrQLNV";
            this.cdrQLNV.TabIndex = 2;
            // 
            // pnlQLNV
            // 
            this.pnlQLNV.BackColor = System.Drawing.Color.MistyRose;
            this.pnlQLNV.Controls.Add(this.label2);
            this.pnlQLNV.Controls.Add(this.dgvLichLamViec);
            this.pnlQLNV.Location = new System.Drawing.Point(290, 84);
            this.pnlQLNV.Name = "pnlQLNV";
            this.pnlQLNV.Size = new System.Drawing.Size(898, 521);
            this.pnlQLNV.TabIndex = 3;
            this.pnlQLNV.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlQLNV_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(560, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lịch Làm Việc Toàn Bộ Nhân Viên";
            // 
            // dgvLichLamViec
            // 
            this.dgvLichLamViec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichLamViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichLamViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.TenNV,
            this.CaTruc,
            this.Ngay,
            this.id});
            this.dgvLichLamViec.Location = new System.Drawing.Point(15, 55);
            this.dgvLichLamViec.Name = "dgvLichLamViec";
            this.dgvLichLamViec.ReadOnly = true;
            this.dgvLichLamViec.RowHeadersWidth = 51;
            this.dgvLichLamViec.RowTemplate.Height = 24;
            this.dgvLichLamViec.Size = new System.Drawing.Size(860, 448);
            this.dgvLichLamViec.TabIndex = 0;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // CaTruc
            // 
            this.CaTruc.HeaderText = "Ca Trực";
            this.CaTruc.MinimumWidth = 6;
            this.CaTruc.Name = "CaTruc";
            this.CaTruc.ReadOnly = true;
            // 
            // Ngay
            // 
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.MinimumWidth = 6;
            this.Ngay.Name = "Ngay";
            this.Ngay.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // btnTroVeCuaQLNV
            // 
            this.btnTroVeCuaQLNV.BackColor = System.Drawing.Color.Turquoise;
            this.btnTroVeCuaQLNV.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVeCuaQLNV.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconBack;
            this.btnTroVeCuaQLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroVeCuaQLNV.Location = new System.Drawing.Point(12, 12);
            this.btnTroVeCuaQLNV.Name = "btnTroVeCuaQLNV";
            this.btnTroVeCuaQLNV.Size = new System.Drawing.Size(94, 32);
            this.btnTroVeCuaQLNV.TabIndex = 4;
            this.btnTroVeCuaQLNV.Text = "Trở về";
            this.btnTroVeCuaQLNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTroVeCuaQLNV.UseVisualStyleBackColor = false;
            this.btnTroVeCuaQLNV.Click += new System.EventHandler(this.btnTrovecuaqlnv_Click);
            // 
            // btnInCuaCTPP
            // 
            this.btnInCuaCTPP.BackColor = System.Drawing.Color.Pink;
            this.btnInCuaCTPP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInCuaCTPP.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.btnInCuaCTPP.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconIn;
            this.btnInCuaCTPP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInCuaCTPP.Location = new System.Drawing.Point(16, 154);
            this.btnInCuaCTPP.Name = "btnInCuaCTPP";
            this.btnInCuaCTPP.Size = new System.Drawing.Size(191, 55);
            this.btnInCuaCTPP.TabIndex = 91;
            this.btnInCuaCTPP.Text = "in báo cáo";
            this.btnInCuaCTPP.UseVisualStyleBackColor = false;
            // 
            // frmQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhanMemQuanLyKhachSan.Properties.Resources.b1;
            this.ClientSize = new System.Drawing.Size(1200, 622);
            this.ControlBox = false;
            this.Controls.Add(this.btnTroVeCuaQLNV);
            this.Controls.Add(this.pnlQLNV);
            this.Controls.Add(this.cdrQLNV);
            this.Controls.Add(this.lblQuanLyNhanVien);
            this.Controls.Add(this.pnlQuanLyNhanVien);
            this.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmQuanLyNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn hình quản lý nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLyNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.frmQuanLyNhanVien_Load);
            this.pnlQuanLyNhanVien.ResumeLayout(false);
            this.pnlQLNV.ResumeLayout(false);
            this.pnlQLNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichLamViec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlQuanLyNhanVien;
        private System.Windows.Forms.Button btnCapNhatThongTinNV;
        private System.Windows.Forms.Label lblQuanLyNhanVien;
        private System.Windows.Forms.MonthCalendar cdrQLNV;
        private System.Windows.Forms.Panel pnlQLNV;
        private System.Windows.Forms.DataGridView dgvLichLamViec;
        private System.Windows.Forms.Button btnCapNhatLichLamViecNV;
        private System.Windows.Forms.Button btnTroVeCuaQLNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaTruc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Button btnInCuaCTPP;
    }
}