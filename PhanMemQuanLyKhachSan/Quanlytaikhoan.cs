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
using PhanMemQuanLyKhachSan.Linq;
using PhanMemQuanLyKhachSan.Report_Form;


namespace PhanMemQuanLyKhachSan
{
    public partial class frmQLTK : Form
    {
        //SqlConnection con = new SqlConnection("data source=.;initial catalog=PMQLKS;integrated security=True;MultipleActiveResultSets=True;");

        public frmQLTK()
        {
            InitializeComponent();
            txtCccd.Enabled = false;
        }
        private void Quanlytaikhoan_Load(object sender, EventArgs e)
        {
            LoadData();
            txtCccd.Enabled = false;
        }
        private void LoadData()
        {
             dbQuanLyKSDataContext db = new dbQuanLyKSDataContext();

            var query = from matKhau in db.MatKhaus
                        where matKhau.cccd.CompareTo("0") > 0
                        orderby matKhau.cccd ascending // Sắp xếp theo trường FieldName1 tăng dần
                        select new
                        {
                            cccd = matKhau.cccd,
                            username = matKhau.username,
                            password = matKhau.password
                        };

            dgvQuanLyTK.DataSource = query.ToList();
        }
        private void frmQLTK_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.EXITQLTK();
        }

        private void dgvQuanLyTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvQuanLyTK.Rows.Count) // Kiểm tra nếu chỉ số hàng hợp lệ
            {
                DataGridViewRow row = dgvQuanLyTK.Rows[e.RowIndex];
                txtCccd.Text = row.Cells["cccd"].Value.ToString();
                txtUsername.Text = row.Cells["username"].Value.ToString();
                txtPassword.Text = row.Cells["password"].Value.ToString();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtCccd.Enabled = true;

            string cccd = txtCccd.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Kiểm tra xem các trường dữ liệu có được điền đầy đủ hay không
            if (string.IsNullOrEmpty(cccd) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }

            // Kiểm tra xem dữ liệu đã tồn tại trong CSDL hay chưa
            using (var db = new dbQuanLyKSDataContext())
            {
                // Kiểm tra theo cccd
                var existingMatKhau = db.MatKhaus.FirstOrDefault(m => m.cccd == cccd);
                if (existingMatKhau != null)
                {
                    MessageBox.Show("Dữ liệu đã tồn tại trong CSDL");
                    return;
                }

                // Kiểm tra theo username
                existingMatKhau = db.MatKhaus.FirstOrDefault(m => m.username == username);
                if (existingMatKhau != null)
                {
                    MessageBox.Show("Dữ liệu đã tồn tại trong CSDL");
                    return;
                }
            }

            // Tạo một đối tượng mới từ dữ liệu nhập vào
            var newMatKhau = new MatKhau
            {
                cccd = cccd,
                username = username,
                password = password
            };

            using (var db = new dbQuanLyKSDataContext())
            {
                db.MatKhaus.InsertOnSubmit(newMatKhau);
                db.SubmitChanges();
            }

            txtCccd.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;

            MessageBox.Show("Thêm dữ liệu thành công");
            LoadData();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtCccd.Enabled = true; 
            if (dgvQuanLyTK.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa");
                return;
            }

            DataGridViewRow selectedRow = dgvQuanLyTK.SelectedRows[0];
            string cccd = selectedRow.Cells["cccd"].Value.ToString();

            using (var db = new dbQuanLyKSDataContext())
            {
                // Tìm kiếm dữ liệu theo cccd để xóa
                var matKhauToDelete = db.MatKhaus.FirstOrDefault(m => m.cccd == cccd);
                if (matKhauToDelete == null)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu để xóa");
                    return;
                }

                // Xóa dữ liệu khỏi cơ sở dữ liệu
                db.MatKhaus.DeleteOnSubmit(matKhauToDelete);
                db.SubmitChanges();
            }

            // Load lại dữ liệu trong DataGridView
            LoadData();

            MessageBox.Show("Xóa dữ liệu thành công");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtCccd.Enabled = false;
            if (txtCccd.Enabled == true)
            {
                return;
            }
            else if (txtCccd.Enabled == false)
            {
                txtCccd.Enabled = false;
                dbQuanLyKSDataContext db = new dbQuanLyKSDataContext();
                MatKhau emp = db.MatKhaus.FirstOrDefault(empl => empl.cccd.Equals(txtCccd.Text));
                emp.username = txtUsername.Text;
                emp.password = txtPassword.Text;
                db.SubmitChanges();
                MessageBox.Show("Update success");
                LoadData();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmRPQLTK f = new frmRPQLTK();
            f.ShowDialog();
        }

        private void btnThoatCapNhatDichVu_Click(object sender, EventArgs e)
        {
            frmManHinhChinh mhc = new frmManHinhChinh();
            mhc.Show();
            Program.EXITRPQLTK();
        }
    }
}
