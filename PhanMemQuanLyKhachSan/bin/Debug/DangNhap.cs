using PhanMemQuanLyKhachSan.Auth;
using PhanMemQuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace PhanMemQuanLyKhachSan
{

    public partial class frmDangNhap : Form
    {
        public object Messagebox { get; private set; }

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void txtTendangnhap_Enter(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "Tên đăng nhập")
            {
                txtTenDangNhap.Text = "";
                txtTenDangNhap.ForeColor = Color.Black;
            }
        }

        private void txtTendangnhap_Leave(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "")
            {
                txtTenDangNhap.Text = "Tên đăng nhập";
                txtTenDangNhap.ForeColor = Color.Silver;
            }
        }

        private void txtMatkhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Mật khẩu")
            {
                txtMatKhau.UseSystemPasswordChar = true;
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Black;
            }
        }

        private void txtMatkhau_Leave(object sender, EventArgs e)
        {

            if (txtMatKhau.Text == "")
            {
                txtMatKhau.UseSystemPasswordChar = false;
                txtMatKhau.Text = "Mật khẩu";
                txtMatKhau.ForeColor = Color.Silver;
            }
        }

        private void btnHienmatkhau_MouseDown(object sender, MouseEventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = false;
        }

        private void btnHienmatkhau_MouseUp(object sender, MouseEventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;
        }


        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            string TenDangNhap = txtTenDangNhap.Text.Trim();
            string MatKhau = txtMatKhau.Text.Trim();
            bool result = XL_DangNhap.DangNhap(TenDangNhap, MatKhau);
            if (result)
            {
                this.Hide();
                frmManHinhChinh mhc = new frmManHinhChinh();
                mhc.Show();
            }

        }
        private void ClearData()
        {
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy frmDangKy = new frmDangKy();
            this.Visible = false;
            frmDangKy.Show();
        }

        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {
            frmTimMatKhau frmTimMatKhau = new frmTimMatKhau();
            this.Hide();
            frmTimMatKhau.Show();
            
        }
        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
                Application.Exit();
                Program.ExitApplication();
        }

        private void ENTER(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnDangNhap_Click(sender, e);
            }
        }
    }
}
