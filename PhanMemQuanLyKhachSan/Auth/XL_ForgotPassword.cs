using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyKhachSan.Auth
{
    public static class XL_QuenMatKhau
    {
        private static readonly string ConnectionString = "Data Source=.;Initial Catalog=PMQLKS;Integrated Security=True";
        private static readonly string SelectQuery = "SELECT COUNT(*) FROM [MatKhau] WHERE cccd = @cccd";


        public static bool TestConnection()
        {
            bool result = false;
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    result = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu. Vui lòng thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return result;
        }
        public static bool KiemTraThongTin(string Cccd)
        {
            // Kiểm tra các trường thông tin
            //if (string.IsNullOrEmpty(Cccd))
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            //    return false;
            //}
            //if (!Regex.IsMatch(Cccd, @"^0\d{9}$"))
            //{
            //    MessageBox.Show("Số điện thoại không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}

            return true;
        }

        public static bool QuenMatKhau(string Cccd)
        {
            if (!KiemTraThongTin(Cccd))
            {
                return false;
            }
            if (!TestConnection())
            {
                return false;
            }
            bool resulf = false;
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(SelectQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@phone", Cccd);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                dr.Read();
                                string password = dr.GetString(0);
                                MessageBox.Show("Mật khẩu tìm được là: " + password, "Tìm Thành Công! Ok để Copy Mật Khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                Clipboard.SetText(password);
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Số điện thoại không tồn tại hoặc chưa được đăng ký!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                TestConnection();
            }
            return resulf;
        }
    }
}