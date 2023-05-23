using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanMemQuanLyKhachSan.Report_Form;
using PhanMemQuanLyKhachSan.Auth;
using PhanMemQuanLyKhachSan;

namespace PhanMemQuanLyKhachSan.Report_Form
{
    public partial class frmRPQLTK : Form
    {
        public frmRPQLTK()
        {
            InitializeComponent();
        }

        private void frmRPQLTK_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.EXITRPQLTK();
        }

        private void frmRPQLTK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pMQLKSDataSet1.MatKhau' table. You can move, or remove it, as needed.
            this.matKhauTableAdapter.Fill(this.pMQLKSDataSet1.MatKhau);

            this.frm.RefreshReport();
        }
    }
}
