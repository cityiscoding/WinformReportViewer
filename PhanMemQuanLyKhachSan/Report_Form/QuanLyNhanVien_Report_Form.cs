using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyKhachSan.Report_Form
{
    public partial class QuanLyNhanVien_Report_Form : Form
    {
        public QuanLyNhanVien_Report_Form()
        {
            InitializeComponent();
        }

        private void QuanLyNhanVien_Report_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pMQLKSDataSet2.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.pMQLKSDataSet2.NhanVien);

            this.reportViewer1.RefreshReport();
        }

        private void QuanLyNhanVien_Report_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.EXITQuanLyNhanVien_Report_Form();
        }
    }
}
