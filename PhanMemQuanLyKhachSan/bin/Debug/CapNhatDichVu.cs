using PhanMemQuanLyKhachSan.Report_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanMemQuanLyKhachSan.Linq;

namespace PhanMemQuanLyKhachSan
{
    public partial class frmCapNhatDichVu : Form
    {
        public frmCapNhatDichVu()
        {
            InitializeComponent();
        }

        public void SetGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgview.BackgroundColor = Color.White;
            dgview.EnableHeadersVisualStyles = false;
            dgview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgview.AllowUserToDeleteRows = false;
            dgview.AllowUserToAddRows = false;
            dgview.AllowUserToOrderColumns = true;
            dgview.MultiSelect = false;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            frmQuanLyPhong mqv = new frmQuanLyPhong();
            mqv.Show();
            this.Close();
        }

        private void frmCapNhatDichVu_Load(object sender, EventArgs e)
        {
            LoadData();
            txtDichVuID.Enabled = false;
        }
        private void LoadData()
        {
            dbQuanLyKSDataContext db = new dbQuanLyKSDataContext();

            var query = from dichVu in db.DichVus
                        where dichVu.DichVuID.CompareTo("0") > 0
                        orderby dichVu.DichVuID ascending // Sắp xếp theo trường FieldName1 tăng dần
                        select new
                        {
                            DichVuID = dichVu.DichVuID,
                            TenDV = dichVu.TenDV,
                            GiaDV = dichVu.GiaDV
                        };

            dgvCapNhatDichVu.DataSource = query.ToList();
        }
        private void cell_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvCapNhatDichVu.Rows.Count) // Kiểm tra nếu chỉ số hàng hợp lệ
            {
                DataGridViewRow row = dgvCapNhatDichVu.Rows[e.RowIndex];
                txtDichVuID.Text = row.Cells["DichVuID"].Value.ToString();
                txtTenDV.Text = row.Cells["TenDichVu"].Value.ToString();
                txtGiaGV.Text = row.Cells["GiaDV"].Value.ToString();
                return;
            }else
            {
                return;

                MessageBox.Show("Hàng chọn không hợp lệ");
            }
        }
        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
            txtDichVuID.Enabled = false;
            string TenDV = txtTenDV.Text;
            string GiaDV = txtGiaGV.Text;

            // Kiểm tra xem các trường dữ liệu có được điền đầy đủ hay không
            if (string.IsNullOrEmpty(TenDV) || string.IsNullOrEmpty(GiaDV))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }

            // Kiểm tra xem dữ liệu đã tồn tại trong CSDL hay chưa
            using (var db = new dbQuanLyKSDataContext())
            {
                // Kiểm tra theo TenDV
                var exitDichVu = db.DichVus.FirstOrDefault(m => m.TenDV == TenDV);
                if (exitDichVu != null)
                {
                    MessageBox.Show("Dữ liệu đã tồn tại trong CSDL");
                    return;
                }

                // Create a new DichVu object
                var newDV = new DichVu
                {
                    TenDV = TenDV,
                    GiaDV = GiaDV
                };

                // Add the new DichVu to the database
                db.DichVus.InsertOnSubmit(newDV);
                db.SubmitChanges();

                // Refresh the data grid view
                LoadData();

                MessageBox.Show("Thêm dịch vụ thành công");
            }
        }

        private void btnXoaDichVu_Click(object sender, EventArgs e)
        {
            if (dgvCapNhatDichVu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa");
                return;
            }

            DataGridViewRow selectedRow = dgvCapNhatDichVu.SelectedRows[0];
            string DichVuID = selectedRow.Cells["DichVuID"].Value.ToString();
            int dichVuID = int.Parse(DichVuID);

            using (var db = new dbQuanLyKSDataContext())
            {
                // Tìm kiếm dữ liệu theo DichVuID để xóa
                var delDV = db.DichVus.FirstOrDefault(m => m.DichVuID == dichVuID);
                if (delDV == null)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu để xóa");
                    return;
                }

                // Xóa dữ liệu khỏi cơ sở dữ liệu
                db.DichVus.DeleteOnSubmit(delDV);
                db.SubmitChanges();
            }
            MessageBox.Show("Xóa dữ liệu thành công");

            LoadData();
        }
        private void btnLuuCapNhatDichVu_Click(object sender, EventArgs e)
        {
            txtDichVuID.Enabled= false;
            dbQuanLyKSDataContext db = new dbQuanLyKSDataContext();
            DichVu emp = db.DichVus.FirstOrDefault(empl => empl.DichVuID.Equals(txtDichVuID.Text));
            emp.TenDV = txtTenDV.Text;
            emp.GiaDV = txtGiaGV.Text;
            db.SubmitChanges();
            MessageBox.Show("Update success");
            LoadData();
        }

        private void dgvCapNhatDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCapNhatDichVu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.EXITCAPNHATDICHVU();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            DichVu_Report_Form dichVu_Report_Form = new DichVu_Report_Form();
            dichVu_Report_Form.ShowDialog();
        }
    }
}
