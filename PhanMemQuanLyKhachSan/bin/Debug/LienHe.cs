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
    public partial class frmLienHe : Form
    {
        public frmLienHe()
        {
            InitializeComponent();
        }
        private void btnTroVeCuaLienHe_Click(object sender, EventArgs e)
        {
            frmManHinhChinh frmManHinhChinh = new frmManHinhChinh();
            frmManHinhChinh.Show();
            this.Close();
        }

        private void frmLienHe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.ExitLIENHE();
        }
    }
}
