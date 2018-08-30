using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyQuanCafe.DAO
{
    public class ChiTietHoaDonDAO
    {
        private QuanLyQuanCafeDataContext db = new QuanLyQuanCafeDataContext();

        public bool ThemChiTietHoaDon(ChiTietHoaDon ct)
        {
            try 
            {
                db.ChiTietHoaDons.InsertOnSubmit(ct);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // kiểm tra thực đơn đã dược gọi hay chưa
        public bool KiemTraThucDonDaDuocGoi(int maBan, int idTP)
        {
            try
            {
                var result = db.ChiTietHoaDons.Single(x => x.maBan== maBan && x.maTP == idTP);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ThemSoLuongThucDon(int maTP, int soLuong)
        {
            try
            {
                ChiTietHoaDon cthd = db.ChiTietHoaDons.Single(x => x.ThucPham.maTP == maTP);
                cthd.soLuong += soLuong;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

       

        public bool XoaChiTietHoaDon(int idBan, string tenTP)
        {
            try
            {
                ChiTietHoaDon ct = db.ChiTietHoaDons.Single(x => x.maBan == idBan && x.ThucPham.tenTP == tenTP);
                db.ChiTietHoaDons.DeleteOnSubmit(ct);
                db.SubmitChanges();
                return true;               
            }
            catch
            {
                return false;
            }
        }

        public bool XoaChiTietHoaDon(int idBan)
        {
            try
            {
                var result = (from c in db.ChiTietHoaDons
                              where c.maBan == idBan
                              select c);
                foreach (var item in result)
                {
                    db.ChiTietHoaDons.DeleteOnSubmit(item);
                    db.SubmitChanges();
                }
                //ChiTietHoaDon ct = db.ChiTietHoaDons.Single(x => x.maBan == idBan);
                //db.ChiTietHoaDons.DeleteOnSubmit(ct);
                
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
