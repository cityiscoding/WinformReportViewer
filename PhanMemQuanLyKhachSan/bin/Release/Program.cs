using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PhanMemQuanLyKhachSan
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmManHinhChinh());
        }
        public static void ExitApplication()
        {
            Application.Exit();
        }
        public static void ExitMHC()
        {
            frmManHinhChinh mhc = new frmManHinhChinh();
            mhc.Close();
            Application.Exit();
        }
        public static void ExitTHONGKE()
        {
            frmThongKe ftk = new frmThongKe();
            ftk.Close();
        }
        public static void ExitQUANLYNHANVIEN()
        {
            frmQuanLyNhanVien fqlnv = new frmQuanLyNhanVien();
            fqlnv.Close();
        }
        public static void ExitLIENHE()
        {
            frmLienHe flh = new frmLienHe();
            flh.Close();
        }
        public static void ExitVATTU()
        {
            frmCapNhatVatTu fcnvt = new frmCapNhatVatTu();
            fcnvt.Close();
        }
        public static void EXITCAPNHATDICHVU()
        {
            frmCapNhatDichVu fcndv = new frmCapNhatDichVu();
            fcndv.Close();
        }
        public static void EXITCAPNHATLOAIPHONG()
        {
            frmCapNhatLoaiPhong fcnlp = new frmCapNhatLoaiPhong();  
            fcnlp.Close();
        }
        public static void EXITfrmCapNhatLichLamViec()
        {
            frmCapNhatLichLamViec fcnllv = new frmCapNhatLichLamViec();
            fcnllv.Close();
        }
        public static void EXITfrmCapNhatThongTinNhanVien()
        {
            frmCapNhatThongTinNhanVien cnttnv = new frmCapNhatThongTinNhanVien();
            cnttnv.Close();
        }
        public static void EXITfrmChiTietPhieuPhong()
        {
            frmChiTietPhieuPhong ctpp = new frmChiTietPhieuPhong();
            ctpp.Close();
        }
        public static void EXITfrmQuanLyKhachHang()
        {
            frmQuanLyKhachHang qlkh = new frmQuanLyKhachHang();
            qlkh.Close();
        }
        public static void EXITfrmQuanLyPhong()
        {
            frmQuanLyPhong qlp = new frmQuanLyPhong();
            qlp.Close();
        }
    }
}
