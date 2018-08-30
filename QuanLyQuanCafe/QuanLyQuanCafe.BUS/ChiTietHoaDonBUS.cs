using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyQuanCafe.DAO;

namespace QuanLyQuanCafe.BUS
{
    public class ChiTietHoaDonBUS
    {
        private ChiTietHoaDonDAO cthd = new ChiTietHoaDonDAO();

        //public List<ChiTietHoaDon> HienThiChiTietHoaDonTheoBan(int id)
        //{
        //    return cthd.HienThiChiTietHoaDonTheoBan(id);
        //}

        public bool ThemChiTietHoaDon(ChiTietHoaDon ct)
        {
            return cthd.ThemChiTietHoaDon(ct);
        }

        public bool KiemTraThucDonDaDuocGoi(int maBan, int idTP)
        {
            return cthd.KiemTraThucDonDaDuocGoi(maBan, idTP);
        }

        public bool ThemSoLuongThucDon(int maTP, int soLuong)
        {
            return cthd.ThemSoLuongThucDon(maTP, soLuong);
        }

        public bool XoaChiTietHoaDon(int maBan, string tenTP)
        {
            return cthd.XoaChiTietHoaDon(maBan, tenTP);
        }

        public bool XoaChiTietHoaDon(int maBan)
        {
            return cthd.XoaChiTietHoaDon(maBan);
        }

    }
}
