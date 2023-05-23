﻿using PhanMemQuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyKhachSan
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTroVeCuaThongKe_Click(object sender, EventArgs e)
        {
            frmManHinhChinh frmManHinhChinh = new frmManHinhChinh();
            frmManHinhChinh.Show();
            this.Hide();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            List<HoaDon> listhd = HoaDon.GetAll();
            chart1.Series["Tổng Tiền"].XValueMember = "HoaDon.TongTien";
            chart1.Series["Tổng Tiền"].YValueMembers= "HoaDon.NgayHD.Month";
            chart1.DataBind();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void frmThongKe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.ExitTHONGKE();
        }
    }
}
