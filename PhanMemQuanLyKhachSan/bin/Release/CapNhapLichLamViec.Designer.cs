namespace PhanMemQuanLyKhachSan
{
    partial class frmCapNhatLichLamViec
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
            this.lblLichLamViec = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.btnSuaLichLamViec = new System.Windows.Forms.Button();
            this.btnXoaLichLamViec = new System.Windows.Forms.Button();
            this.btnThemLichLamViec = new System.Windows.Forms.Button();
            this.btnTroVeCuaCapNhatLichLamViec = new System.Windows.Forms.Button();
            this.dgvCapNhatLichLamViec = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnXemLai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCa = new System.Windows.Forms.ComboBox();
            this.dtpNgayLamViec = new System.Windows.Forms.DateTimePicker();
            this.cbxTenNV = new System.Windows.Forms.ComboBox();
            this.btnInCuaCTPP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatLichLamViec)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLichLamViec
            // 
            this.lblLichLamViec.AutoSize = true;
            this.lblLichLamViec.BackColor = System.Drawing.Color.Transparent;
            this.lblLichLamViec.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLichLamViec.Location = new System.Drawing.Point(411, 20);
            this.lblLichLamViec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLichLamViec.Name = "lblLichLamViec";
            this.lblLichLamViec.Size = new System.Drawing.Size(653, 55);
            this.lblLichLamViec.TabIndex = 0;
            this.lblLichLamViec.Text = "Lịch Làm Việc Toàn Bộ Nhân Viên";
            this.lblLichLamViec.Click += new System.EventHandler(this.LblLichLamViec_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(1944, 314);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(324, 358);
            this.txtGhiChu.TabIndex = 14;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhiChu.Location = new System.Drawing.Point(2060, 272);
            this.lblGhiChu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(88, 27);
            this.lblGhiChu.TabIndex = 15;
            this.lblGhiChu.Text = "Ghi Chú";
            // 
            // btnSuaLichLamViec
            // 
            this.btnSuaLichLamViec.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnSuaLichLamViec.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLichLamViec.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconSuaaaaa;
            this.btnSuaLichLamViec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaLichLamViec.Location = new System.Drawing.Point(761, 174);
            this.btnSuaLichLamViec.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaLichLamViec.Name = "btnSuaLichLamViec";
            this.btnSuaLichLamViec.Size = new System.Drawing.Size(112, 55);
            this.btnSuaLichLamViec.TabIndex = 13;
            this.btnSuaLichLamViec.Text = "Sửa ";
            this.btnSuaLichLamViec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaLichLamViec.UseVisualStyleBackColor = false;
            this.btnSuaLichLamViec.Click += new System.EventHandler(this.btnSuaLichLamViec_Click);
            // 
            // btnXoaLichLamViec
            // 
            this.btnXoaLichLamViec.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnXoaLichLamViec.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLichLamViec.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconDelete;
            this.btnXoaLichLamViec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaLichLamViec.Location = new System.Drawing.Point(545, 174);
            this.btnXoaLichLamViec.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaLichLamViec.Name = "btnXoaLichLamViec";
            this.btnXoaLichLamViec.Size = new System.Drawing.Size(111, 55);
            this.btnXoaLichLamViec.TabIndex = 12;
            this.btnXoaLichLamViec.Text = "Xóa ";
            this.btnXoaLichLamViec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaLichLamViec.UseVisualStyleBackColor = false;
            this.btnXoaLichLamViec.Click += new System.EventHandler(this.btnXoaLichLamViec_Click);
            // 
            // btnThemLichLamViec
            // 
            this.btnThemLichLamViec.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnThemLichLamViec.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLichLamViec.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconThem;
            this.btnThemLichLamViec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemLichLamViec.Location = new System.Drawing.Point(999, 174);
            this.btnThemLichLamViec.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemLichLamViec.Name = "btnThemLichLamViec";
            this.btnThemLichLamViec.Size = new System.Drawing.Size(124, 55);
            this.btnThemLichLamViec.TabIndex = 11;
            this.btnThemLichLamViec.Text = "Thêm ";
            this.btnThemLichLamViec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemLichLamViec.UseVisualStyleBackColor = false;
            this.btnThemLichLamViec.Click += new System.EventHandler(this.btnThemLichLamViec_Click);
            // 
            // btnTroVeCuaCapNhatLichLamViec
            // 
            this.btnTroVeCuaCapNhatLichLamViec.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnTroVeCuaCapNhatLichLamViec.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVeCuaCapNhatLichLamViec.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconBack;
            this.btnTroVeCuaCapNhatLichLamViec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroVeCuaCapNhatLichLamViec.Location = new System.Drawing.Point(16, 18);
            this.btnTroVeCuaCapNhatLichLamViec.Margin = new System.Windows.Forms.Padding(4);
            this.btnTroVeCuaCapNhatLichLamViec.Name = "btnTroVeCuaCapNhatLichLamViec";
            this.btnTroVeCuaCapNhatLichLamViec.Size = new System.Drawing.Size(135, 55);
            this.btnTroVeCuaCapNhatLichLamViec.TabIndex = 10;
            this.btnTroVeCuaCapNhatLichLamViec.Text = "Trở về";
            this.btnTroVeCuaCapNhatLichLamViec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTroVeCuaCapNhatLichLamViec.UseVisualStyleBackColor = false;
            this.btnTroVeCuaCapNhatLichLamViec.Click += new System.EventHandler(this.BtnTroVeCuaCapNhatLichLamViec_Click);
            // 
            // dgvCapNhatLichLamViec
            // 
            this.dgvCapNhatLichLamViec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCapNhatLichLamViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapNhatLichLamViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.tenNV,
            this.ca,
            this.ngay,
            this.id});
            this.dgvCapNhatLichLamViec.Location = new System.Drawing.Point(39, 255);
            this.dgvCapNhatLichLamViec.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCapNhatLichLamViec.Name = "dgvCapNhatLichLamViec";
            this.dgvCapNhatLichLamViec.RowHeadersWidth = 51;
            this.dgvCapNhatLichLamViec.Size = new System.Drawing.Size(1084, 546);
            this.dgvCapNhatLichLamViec.TabIndex = 16;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            // 
            // tenNV
            // 
            this.tenNV.HeaderText = "Tên Nhân Viên";
            this.tenNV.MinimumWidth = 6;
            this.tenNV.Name = "tenNV";
            // 
            // ca
            // 
            this.ca.HeaderText = "Ca";
            this.ca.MinimumWidth = 6;
            this.ca.Name = "ca";
            // 
            // ngay
            // 
            this.ngay.HeaderText = "Ngày Làm Việc";
            this.ngay.MinimumWidth = 6;
            this.ngay.Name = "ngay";
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 191);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 37);
            this.textBox1.TabIndex = 17;
            // 
            // btnXemLai
            // 
            this.btnXemLai.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnXemLai.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemLai.Location = new System.Drawing.Point(319, 191);
            this.btnXemLai.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemLai.Name = "btnXemLai";
            this.btnXemLai.Size = new System.Drawing.Size(100, 39);
            this.btnXemLai.TabIndex = 18;
            this.btnXemLai.Text = "Xem Lại";
            this.btnXemLai.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 27);
            this.label1.TabIndex = 19;
            this.label1.Text = "Xem Lại Lịch Làm Việc Theo Ngày";
            // 
            // cbxCa
            // 
            this.cbxCa.FormattingEnabled = true;
            this.cbxCa.Location = new System.Drawing.Point(1176, 320);
            this.cbxCa.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCa.Name = "cbxCa";
            this.cbxCa.Size = new System.Drawing.Size(296, 24);
            this.cbxCa.TabIndex = 21;
            // 
            // dtpNgayLamViec
            // 
            this.dtpNgayLamViec.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLamViec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLamViec.Location = new System.Drawing.Point(1176, 398);
            this.dtpNgayLamViec.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayLamViec.Name = "dtpNgayLamViec";
            this.dtpNgayLamViec.Size = new System.Drawing.Size(296, 22);
            this.dtpNgayLamViec.TabIndex = 22;
            // 
            // cbxTenNV
            // 
            this.cbxTenNV.FormattingEnabled = true;
            this.cbxTenNV.Location = new System.Drawing.Point(1176, 244);
            this.cbxTenNV.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTenNV.Name = "cbxTenNV";
            this.cbxTenNV.Size = new System.Drawing.Size(296, 24);
            this.cbxTenNV.TabIndex = 23;
            // 
            // btnInCuaCTPP
            // 
            this.btnInCuaCTPP.BackColor = System.Drawing.Color.Pink;
            this.btnInCuaCTPP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInCuaCTPP.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.btnInCuaCTPP.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconIn;
            this.btnInCuaCTPP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInCuaCTPP.Location = new System.Drawing.Point(1160, 172);
            this.btnInCuaCTPP.Name = "btnInCuaCTPP";
            this.btnInCuaCTPP.Size = new System.Drawing.Size(191, 55);
            this.btnInCuaCTPP.TabIndex = 92;
            this.btnInCuaCTPP.Text = "in báo cáo";
            this.btnInCuaCTPP.UseVisualStyleBackColor = false;
            // 
            // frmCapNhatLichLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhanMemQuanLyKhachSan.Properties.Resources.b13;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1511, 838);
            this.Controls.Add(this.btnInCuaCTPP);
            this.Controls.Add(this.cbxTenNV);
            this.Controls.Add(this.dtpNgayLamViec);
            this.Controls.Add(this.cbxCa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXemLai);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvCapNhatLichLamViec);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.btnSuaLichLamViec);
            this.Controls.Add(this.btnXoaLichLamViec);
            this.Controls.Add(this.btnThemLichLamViec);
            this.Controls.Add(this.btnTroVeCuaCapNhatLichLamViec);
            this.Controls.Add(this.lblLichLamViec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCapNhatLichLamViec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhât lịch làm việc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCapNhatLichLamViec_FormClosing);
            this.Load += new System.EventHandler(this.frmCapNhatLichLamViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatLichLamViec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLichLamViec;
        private System.Windows.Forms.Button btnTroVeCuaCapNhatLichLamViec;
        private System.Windows.Forms.Button btnThemLichLamViec;
        private System.Windows.Forms.Button btnSuaLichLamViec;
        private System.Windows.Forms.Button btnXoaLichLamViec;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.DataGridView dgvCapNhatLichLamViec;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnXemLai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCa;
        private System.Windows.Forms.DateTimePicker dtpNgayLamViec;
        private System.Windows.Forms.ComboBox cbxTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Button btnInCuaCTPP;
    }
}