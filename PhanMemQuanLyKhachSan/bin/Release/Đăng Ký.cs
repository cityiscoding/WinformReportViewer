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

namespace PhanMemQuanLyKhachSan
{
    public partial class frmDangKy : Form
    {

        public frmDangKy()
        {
            InitializeComponent();
        }

        private void bntBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap frmDN = new frmDangNhap(); // Tạo một đối tượng mới của frmDangNhap
            frmDN.Show(); // Hiển thị frmDangNhap
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }
        private void ClearData()
        {
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            txtCccd.Text = "";
        }

        private void frmDangKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.ExitApplication();
            Application.Exit();
        }


        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string connection = @"Server=.; Database=PMQLKS;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    string query = "INSERT INTO MatKhau (cccd, username, password) VALUES (@Cccd, @Username, @Password)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Cccd", txtCccd.Text);
                        cmd.Parameters.AddWithValue("@Username", txtTenDangNhap.Text);
                        cmd.Parameters.AddWithValue("@Password", txtMatKhau.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đăng ký thành công");
                        ClearData();
                    }
                }
                catch
                {
                    MessageBox.Show("Thông tin đã tồn tại hoặc bạn nhập không đúng!", "Đăng ký thất bại!");
                }
            }
        }

        private void txtTenDangNhap_Enter(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "Tên đăng nhập")
            {
                txtTenDangNhap.Text = "";
                txtTenDangNhap.ForeColor = Color.Black;
            }
        }

        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "")
            {
                txtTenDangNhap.Text = "Tên đăng nhập";
                txtTenDangNhap.ForeColor = Color.Silver;
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Mật khẩu")
            {
                txtMatKhau.UseSystemPasswordChar = true;
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Black;
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.UseSystemPasswordChar = false;
                txtMatKhau.Text = "Mật khẩu";
                txtMatKhau.ForeColor = Color.Silver;
            }
        }

        private void txtCccd_Enter(object sender, EventArgs e)
        {
            if (txtCccd.Text == "Căn cước công dân")
            {
                txtCccd.Text = "";
                txtCccd.ForeColor = Color.Black;
            }
        }

        private void txtCccd_Leave(object sender, EventArgs e)
        {
            if (txtCccd.Text == "")
            {
                txtCccd.Text = "Căn cước công dân";
                txtCccd.ForeColor = Color.Silver;
            }
        }

        private void ENTER(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangKy_Click(sender, e);
            }
        }

        private void ENTER(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }
    }
}
