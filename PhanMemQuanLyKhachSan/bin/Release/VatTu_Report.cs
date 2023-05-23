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
    public partial class frmVatTuRP : Form
    {
        public frmVatTuRP()
        {
            InitializeComponent();
        }

        private void VatTu_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pMQLKSDataSet.VatTu' table. You can move, or remove it, as needed.
            this.vatTuTableAdapter.Fill(this.pMQLKSDataSet.VatTu);

            this.reportViewer1.RefreshReport();
        }


    }
}
