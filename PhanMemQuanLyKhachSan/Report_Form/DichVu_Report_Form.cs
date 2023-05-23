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
    public partial class DichVu_Report_Form : Form
    {
        public DichVu_Report_Form()
        {
            InitializeComponent();
        }

        private void DichVu_Report_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dichVuDataSet.DichVu' table. You can move, or remove it, as needed.
            this.dichVuTableAdapter.Fill(this.dichVuDataSet.DichVu);

            this.reportViewer1.RefreshReport();
        }

        private void DichVu_Report_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.EXITRPDICHVU();
        }
    }
}
