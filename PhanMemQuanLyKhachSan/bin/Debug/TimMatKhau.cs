using PhanMemQuanLyKhachSan.Auth;
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
    public partial class frmTimMatKhau : Form
    {
        public frmTimMatKhau()
        {
            InitializeComponent();
        }

        private void btnTimmatkhau_Click(object sender, EventArgs e)
        {
            string connection = @"Server=.; Database=PMQLKS;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from MatKhau where cccd=@cccd", con);
                // Chuyển giá trị của txtCccd.Text sang kiểu int
                int cccd;
                if (int.TryParse(txtCccd.Text, out cccd))
                {
                    cmd.Parameters.AddWithValue("@cccd", cccd);

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        string matKhau = dr["password"].ToString();
                        MessageBox.Show("Mật khẩu của bạn là: " + matKhau, "Thông báo", MessageBoxButtons.OK);
                        Clipboard.SetText(matKhau);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mật khẩu");
                        ClearData();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số căn cước không hợp lệ.");
                }
            }
        }
        private void ClearData()
        {
            txtCccd.Text = "";
        }
        private void frmTimMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.ExitApplication();
        }
        private void txtCccd_Leave(object sender, EventArgs e)
        {
            if (txtCccd.Text == "")
            {
                txtCccd.Text = "Nhập căn cước công dân";
                txtCccd.ForeColor = Color.Silver;
            }
        }

        private void txtCccd_Enter(object sender, EventArgs e)
        {
            if (txtCccd.Text == "Nhập căn cước công dân")
            {
                txtCccd.Text = "";
                txtCccd.ForeColor = Color.Black;
            }
        }

        private void btnTrolai_Click(object sender, EventArgs e)
        {
            frmDangNhap fdn = new frmDangNhap();
            this.Hide();
            fdn.Show();
        }
    }
}
