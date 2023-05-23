namespace PhanMemQuanLyKhachSan
{
    partial class frmQLTK
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
            this.dgvQuanLyTK = new System.Windows.Forms.DataGridView();
            this.cccd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDichVuKhachSan = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtCccd = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoatCapNhatDichVu = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyTK)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQuanLyTK
            // 
            this.dgvQuanLyTK.AllowUserToAddRows = false;
            this.dgvQuanLyTK.AllowUserToDeleteRows = false;
            this.dgvQuanLyTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanLyTK.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvQuanLyTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cccd,
            this.username,
            this.password});
            this.dgvQuanLyTK.Location = new System.Drawing.Point(35, 93);
            this.dgvQuanLyTK.Margin = new System.Windows.Forms.Padding(4);
            this.dgvQuanLyTK.Name = "dgvQuanLyTK";
            this.dgvQuanLyTK.ReadOnly = true;
            this.dgvQuanLyTK.RowHeadersWidth = 51;
            this.dgvQuanLyTK.Size = new System.Drawing.Size(723, 726);
            this.dgvQuanLyTK.TabIndex = 97;
            this.dgvQuanLyTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyTK_CellClick);
            // 
            // cccd
            // 
            this.cccd.DataPropertyName = "cccd";
            this.cccd.FillWeight = 38.07107F;
            this.cccd.HeaderText = "cccd";
            this.cccd.MinimumWidth = 6;
            this.cccd.Name = "cccd";
            this.cccd.ReadOnly = true;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Tên tài khoản";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.FillWeight = 130.9645F;
            this.password.HeaderText = "Mật khẩu";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 92;
            // 
            // lblDichVuKhachSan
            // 
            this.lblDichVuKhachSan.AutoSize = true;
            this.lblDichVuKhachSan.BackColor = System.Drawing.Color.Transparent;
            this.lblDichVuKhachSan.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDichVuKhachSan.Location = new System.Drawing.Point(431, 13);
            this.lblDichVuKhachSan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDichVuKhachSan.Name = "lblDichVuKhachSan";
            this.lblDichVuKhachSan.Size = new System.Drawing.Size(476, 60);
            this.lblDichVuKhachSan.TabIndex = 91;
            this.lblDichVuKhachSan.Text = "Tài khoản người dùng";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(791, 201);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(511, 50);
            this.txtPassword.TabIndex = 98;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(792, 148);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(511, 45);
            this.txtUsername.TabIndex = 99;
            // 
            // txtCccd
            // 
            this.txtCccd.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCccd.Location = new System.Drawing.Point(791, 93);
            this.txtCccd.Margin = new System.Windows.Forms.Padding(4);
            this.txtCccd.Multiline = true;
            this.txtCccd.Name = "txtCccd";
            this.txtCccd.Size = new System.Drawing.Size(511, 45);
            this.txtCccd.TabIndex = 101;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Pink;
            this.btnXoa.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconDelete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(992, 270);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(191, 55);
            this.btnXoa.TabIndex = 96;
            this.btnXoa.Text = "Xóa TK";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Pink;
            this.btnThem.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconThem;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(781, 270);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(203, 55);
            this.btnThem.TabIndex = 95;
            this.btnThem.Text = "Them TK";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Pink;
            this.btnSua.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconLuu;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(1191, 270);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 55);
            this.btnSua.TabIndex = 94;
            this.btnSua.Text = "Lưu";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoatCapNhatDichVu
            // 
            this.btnThoatCapNhatDichVu.BackColor = System.Drawing.Color.Pink;
            this.btnThoatCapNhatDichVu.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatCapNhatDichVu.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconBack;
            this.btnThoatCapNhatDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatCapNhatDichVu.Location = new System.Drawing.Point(16, 16);
            this.btnThoatCapNhatDichVu.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoatCapNhatDichVu.Name = "btnThoatCapNhatDichVu";
            this.btnThoatCapNhatDichVu.Size = new System.Drawing.Size(135, 55);
            this.btnThoatCapNhatDichVu.TabIndex = 93;
            this.btnThoatCapNhatDichVu.Text = "Trở Về";
            this.btnThoatCapNhatDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoatCapNhatDichVu.UseVisualStyleBackColor = false;
            this.btnThoatCapNhatDichVu.Click += new System.EventHandler(this.btnThoatCapNhatDichVu_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.Pink;
            this.btnIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIn.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.btnIn.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconIn;
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(992, 360);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(191, 55);
            this.btnIn.TabIndex = 100;
            this.btnIn.Text = "in báo cáo";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // frmQLTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 832);
            this.ControlBox = false;
            this.Controls.Add(this.txtCccd);
            this.Controls.Add(this.dgvQuanLyTK);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThoatCapNhatDichVu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDichVuKhachSan);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "frmQLTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quanlytaikhoan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQLTK_FormClosing);
            this.Load += new System.EventHandler(this.Quanlytaikhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQuanLyTK;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoatCapNhatDichVu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDichVuKhachSan;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtCccd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cccd;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
    }
}