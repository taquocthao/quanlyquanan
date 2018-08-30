using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyQuanCafe.DAO
{
    public class NhanVienDAO
    {
        QuanLyQuanCafeDataContext db = new QuanLyQuanCafeDataContext();

        public List<NhanVien> HienThiDanhSachNhanVien()
        {
            return db.NhanViens.ToList();
        }


        public bool KiemTraDangNhap(string user, string pass)
        {
            try
            {
                var result = db.TaiKhoans.Single(x => x.tenTaiKhoan == user && x.matKhau == pass);
                return (result != null);
            }
            catch
            {
                return false;
            }

        }

        public string LayTenNhanVienTuTaiKhoan(string user, string pass)
        {
            try
            {
                var result = db.TaiKhoans.Single(x => x.tenTaiKhoan == user && x.matKhau == pass);
                var nv = db.NhanViens.Single(x => x.maNhanVien == result.maNhanVien);
                return nv.ten;
            }
            catch
            {
                return null;
            }
        }


        public int LayMaNhanVienTuTaiKhoan(string user, string pass)
        {
            try
            {
                var result = db.TaiKhoans.Single(x => x.tenTaiKhoan == user && x.matKhau == pass);
                var nv = db.NhanViens.Single(x => x.maNhanVien == result.maNhanVien);
                return nv.maNhanVien;
            }
            catch
            {
                return -1;
            }
        }


        public bool ThemNhanVien(NhanVien nv)
        {
            try
            {
                db.NhanViens.InsertOnSubmit(nv);
                db.SubmitChanges();            
            }
            catch (Exception)
            {
                return false;
            }          
            return true;
        }

        public bool XoaNhanVien(int id)
        {
            try
            {
                NhanVien nv = db.NhanViens.Single(x => x.maNhanVien == id);
                db.NhanViens.DeleteOnSubmit(nv);
                db.SubmitChanges();
            }
            catch
            {
                return false;
            }
            return true;

        }

        public bool SuaNhanVien(NhanVien nv)
        {
            try
            {
                NhanVien n = db.NhanViens.Single(x => x.maNhanVien == nv.maNhanVien);
                n.hoLot = nv.hoLot;
                n.ten = nv.ten;
                n.soCMND = nv.soCMND;
                n.diaChi = nv.diaChi;
                n.sdt = nv.sdt;
                n.gioiTinh = nv.gioiTinh;
                n.chucVu = nv.chucVu;
                n.ngayLam = nv.ngayLam;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
           
        }
    }
}
