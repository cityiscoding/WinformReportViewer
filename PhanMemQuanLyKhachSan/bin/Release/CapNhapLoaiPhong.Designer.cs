﻿namespace PhanMemQuanLyKhachSan
{
    partial class frmCapNhatLoaiPhong
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
            this.lblCapNhatLoaiPhong = new System.Windows.Forms.Label();
            this.lblChonSoPhong = new System.Windows.Forms.Label();
            this.cmbChonSoPhong = new System.Windows.Forms.ComboBox();
            this.lblChonLoaiPhong = new System.Windows.Forms.Label();
            this.rdoStandard = new System.Windows.Forms.RadioButton();
            this.rdoSuperior = new System.Windows.Forms.RadioButton();
            this.rdoDeluxe = new System.Windows.Forms.RadioButton();
            this.btnLuuCapNhatLoaiPhong = new System.Windows.Forms.Button();
            this.btnHuyCapNhatLoaiPhong = new System.Windows.Forms.Button();
            this.btnTroVeCuaQLNV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCapNhatLoaiPhong
            // 
            this.lblCapNhatLoaiPhong.AutoSize = true;
            this.lblCapNhatLoaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblCapNhatLoaiPhong.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapNhatLoaiPhong.Location = new System.Drawing.Point(251, 11);
            this.lblCapNhatLoaiPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapNhatLoaiPhong.Name = "lblCapNhatLoaiPhong";
            this.lblCapNhatLoaiPhong.Size = new System.Drawing.Size(312, 41);
            this.lblCapNhatLoaiPhong.TabIndex = 0;
            this.lblCapNhatLoaiPhong.Text = "Cập Nhật Loại Phòng";
            // 
            // lblChonSoPhong
            // 
            this.lblChonSoPhong.AutoSize = true;
            this.lblChonSoPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblChonSoPhong.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonSoPhong.Location = new System.Drawing.Point(71, 100);
            this.lblChonSoPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChonSoPhong.Name = "lblChonSoPhong";
            this.lblChonSoPhong.Size = new System.Drawing.Size(180, 32);
            this.lblChonSoPhong.TabIndex = 1;
            this.lblChonSoPhong.Text = "Chọn số phòng:";
            // 
            // cmbChonSoPhong
            // 
            this.cmbChonSoPhong.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChonSoPhong.FormattingEnabled = true;
            this.cmbChonSoPhong.Location = new System.Drawing.Point(317, 107);
            this.cmbChonSoPhong.Margin = new System.Windows.Forms.Padding(4);
            this.cmbChonSoPhong.Name = "cmbChonSoPhong";
            this.cmbChonSoPhong.Size = new System.Drawing.Size(241, 28);
            this.cmbChonSoPhong.TabIndex = 2;
            this.cmbChonSoPhong.SelectedIndexChanged += new System.EventHandler(this.cmbChonSoPhong_SelectedIndexChanged);
            // 
            // lblChonLoaiPhong
            // 
            this.lblChonLoaiPhong.AutoSize = true;
            this.lblChonLoaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblChonLoaiPhong.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonLoaiPhong.Location = new System.Drawing.Point(71, 180);
            this.lblChonLoaiPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChonLoaiPhong.Name = "lblChonLoaiPhong";
            this.lblChonLoaiPhong.Size = new System.Drawing.Size(285, 32);
            this.lblChonLoaiPhong.TabIndex = 3;
            this.lblChonLoaiPhong.Text = "Chọn loại phòng thay đổi:";
            this.lblChonLoaiPhong.Click += new System.EventHandler(this.lblChonLoaiPhong_Click);
            // 
            // rdoStandard
            // 
            this.rdoStandard.AutoSize = true;
            this.rdoStandard.BackColor = System.Drawing.Color.Transparent;
            this.rdoStandard.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoStandard.Location = new System.Drawing.Point(77, 245);
            this.rdoStandard.Margin = new System.Windows.Forms.Padding(4);
            this.rdoStandard.Name = "rdoStandard";
            this.rdoStandard.Size = new System.Drawing.Size(138, 31);
            this.rdoStandard.TabIndex = 4;
            this.rdoStandard.TabStop = true;
            this.rdoStandard.Text = "Tiêu Chuẩn";
            this.rdoStandard.UseVisualStyleBackColor = false;
            // 
            // rdoSuperior
            // 
            this.rdoSuperior.AutoSize = true;
            this.rdoSuperior.BackColor = System.Drawing.Color.Transparent;
            this.rdoSuperior.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSuperior.Location = new System.Drawing.Point(291, 245);
            this.rdoSuperior.Margin = new System.Windows.Forms.Padding(4);
            this.rdoSuperior.Name = "rdoSuperior";
            this.rdoSuperior.Size = new System.Drawing.Size(176, 31);
            this.rdoSuperior.TabIndex = 5;
            this.rdoSuperior.TabStop = true;
            this.rdoSuperior.Text = "Chất Lượng Tốt";
            this.rdoSuperior.UseVisualStyleBackColor = false;
            this.rdoSuperior.CheckedChanged += new System.EventHandler(this.rdoSuperior_CheckedChanged);
            // 
            // rdoDeluxe
            // 
            this.rdoDeluxe.AutoSize = true;
            this.rdoDeluxe.BackColor = System.Drawing.Color.Transparent;
            this.rdoDeluxe.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDeluxe.Location = new System.Drawing.Point(525, 245);
            this.rdoDeluxe.Margin = new System.Windows.Forms.Padding(4);
            this.rdoDeluxe.Name = "rdoDeluxe";
            this.rdoDeluxe.Size = new System.Drawing.Size(101, 31);
            this.rdoDeluxe.TabIndex = 6;
            this.rdoDeluxe.TabStop = true;
            this.rdoDeluxe.Text = "Vip Pro";
            this.rdoDeluxe.UseVisualStyleBackColor = false;
            // 
            // btnLuuCapNhatLoaiPhong
            // 
            this.btnLuuCapNhatLoaiPhong.BackColor = System.Drawing.Color.LightPink;
            this.btnLuuCapNhatLoaiPhong.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuCapNhatLoaiPhong.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconLuu;
            this.btnLuuCapNhatLoaiPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuCapNhatLoaiPhong.Location = new System.Drawing.Point(168, 423);
            this.btnLuuCapNhatLoaiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuuCapNhatLoaiPhong.Name = "btnLuuCapNhatLoaiPhong";
            this.btnLuuCapNhatLoaiPhong.Size = new System.Drawing.Size(113, 49);
            this.btnLuuCapNhatLoaiPhong.TabIndex = 7;
            this.btnLuuCapNhatLoaiPhong.Text = "Lưu";
            this.btnLuuCapNhatLoaiPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuCapNhatLoaiPhong.UseVisualStyleBackColor = false;
            this.btnLuuCapNhatLoaiPhong.Click += new System.EventHandler(this.btnLuuCapNhatLoaiPhong_Click);
            // 
            // btnHuyCapNhatLoaiPhong
            // 
            this.btnHuyCapNhatLoaiPhong.BackColor = System.Drawing.Color.LightPink;
            this.btnHuyCapNhatLoaiPhong.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyCapNhatLoaiPhong.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconHuy;
            this.btnHuyCapNhatLoaiPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyCapNhatLoaiPhong.Location = new System.Drawing.Point(440, 423);
            this.btnHuyCapNhatLoaiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuyCapNhatLoaiPhong.Name = "btnHuyCapNhatLoaiPhong";
            this.btnHuyCapNhatLoaiPhong.Size = new System.Drawing.Size(113, 49);
            this.btnHuyCapNhatLoaiPhong.TabIndex = 8;
            this.btnHuyCapNhatLoaiPhong.Text = "Hủy";
            this.btnHuyCapNhatLoaiPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyCapNhatLoaiPhong.UseVisualStyleBackColor = false;
            // 
            // btnTroVeCuaQLNV
            // 
            this.btnTroVeCuaQLNV.BackColor = System.Drawing.Color.LightPink;
            this.btnTroVeCuaQLNV.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVeCuaQLNV.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconBack;
            this.btnTroVeCuaQLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroVeCuaQLNV.Location = new System.Drawing.Point(16, 11);
            this.btnTroVeCuaQLNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnTroVeCuaQLNV.Name = "btnTroVeCuaQLNV";
            this.btnTroVeCuaQLNV.Size = new System.Drawing.Size(125, 41);
            this.btnTroVeCuaQLNV.TabIndex = 9;
            this.btnTroVeCuaQLNV.Text = "Trở về";
            this.btnTroVeCuaQLNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTroVeCuaQLNV.UseVisualStyleBackColor = false;
            this.btnTroVeCuaQLNV.Click += new System.EventHandler(this.BtnTroVeCuaQLNV_Click);
            // 
            // frmCapNhatLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhanMemQuanLyKhachSan.Properties.Resources.b18;
            this.ClientSize = new System.Drawing.Size(691, 604);
            this.Controls.Add(this.btnTroVeCuaQLNV);
            this.Controls.Add(this.btnHuyCapNhatLoaiPhong);
            this.Controls.Add(this.btnLuuCapNhatLoaiPhong);
            this.Controls.Add(this.rdoDeluxe);
            this.Controls.Add(this.rdoSuperior);
            this.Controls.Add(this.rdoStandard);
            this.Controls.Add(this.lblChonLoaiPhong);
            this.Controls.Add(this.cmbChonSoPhong);
            this.Controls.Add(this.lblChonSoPhong);
            this.Controls.Add(this.lblCapNhatLoaiPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCapNhatLoaiPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Loại Phòng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCapNhatLoaiPhong_FormClosing);
            this.Load += new System.EventHandler(this.frmCapNhatLoaiPhong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCapNhatLoaiPhong;
        private System.Windows.Forms.Label lblChonSoPhong;
        private System.Windows.Forms.ComboBox cmbChonSoPhong;
        private System.Windows.Forms.Label lblChonLoaiPhong;
        private System.Windows.Forms.RadioButton rdoStandard;
        private System.Windows.Forms.RadioButton rdoSuperior;
        private System.Windows.Forms.RadioButton rdoDeluxe;
        private System.Windows.Forms.Button btnLuuCapNhatLoaiPhong;
        private System.Windows.Forms.Button btnHuyCapNhatLoaiPhong;
        private System.Windows.Forms.Button btnTroVeCuaQLNV;
    }
}