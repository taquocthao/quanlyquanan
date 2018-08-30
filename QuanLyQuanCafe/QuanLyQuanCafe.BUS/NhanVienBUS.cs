using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyQuanCafe.DAO;

namespace QuanLyQuanCafe.BUS
{
    public class NhanVienBUS
    {
        private NhanVienDAO nv = new NhanVienDAO();

        public List<NhanVien> HienThiDanhSachNhanVien()
        {
            return nv.HienThiDanhSachNhanVien();
        }

        public bool KiemTraDangNhap(string user, string pass)
        {
            return nv.KiemTraDangNhap(user, pass);
        }

        public string LayTenNhanVienTuTaiKhoan(string user, string pass)
        {
            return nv.LayTenNhanVienTuTaiKhoan(user, pass);
        }

        public int LayMaNhanVienTuTaiKhoan(string user, string pass)
        {
            return nv.LayMaNhanVienTuTaiKhoan(user, pass);
        }

        public bool ThemNhanVien(NhanVien n)
        {
            return nv.ThemNhanVien(n);
        }

        public bool XoaNhanVien(int id)
        {
            return nv.XoaNhanVien(id);
        }

        public bool SuaNhanVien(NhanVien n)
        {
            return nv.SuaNhanVien(n);
        }
    }
}
