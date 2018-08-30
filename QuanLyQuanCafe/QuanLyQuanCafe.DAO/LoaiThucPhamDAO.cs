using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyQuanCafe.DAO
{
    public class LoaiThucPhamDAO
    {
        private QuanLyQuanCafeDataContext db = new QuanLyQuanCafeDataContext();

        public List<LoaiThucPham> HienThiDanhSachLoaiThucPham()
        {
            return db.LoaiThucPhams.ToList();
        }

        public bool Them(LoaiThucPham x)
        {
            try
            {
                db.LoaiThucPhams.InsertOnSubmit(x);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Xoa(int id)
        {
            try
            {
                LoaiThucPham l = db.LoaiThucPhams.Single(x => x.maLoaiTP == id);
                db.LoaiThucPhams.DeleteOnSubmit(l);
                db.SubmitChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool Sua(LoaiThucPham x)
        {
            try 
            {
                LoaiThucPham l = db.LoaiThucPhams.Single(s => s.maLoaiTP == x.maLoaiTP);
                l.tenLoaiTP = x.tenLoaiTP;
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
