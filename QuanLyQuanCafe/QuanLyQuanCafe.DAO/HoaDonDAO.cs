using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe.DAO
{
    public class HoaDonDAO
    {
        QuanLyQuanCafeDataContext db = new QuanLyQuanCafeDataContext();


        public List<HoaDonDTO> HienThiDanhSachHoaDon(DateTime startdate, DateTime enddate)
        {
            try
            {

                List<HoaDonDTO> result = (from h in db.HoaDons
                                          join nv in db.NhanViens on h.maNhanVien equals nv.maNhanVien
                                          where h.ngayLap >= startdate && h.ngayLap <= enddate
                                          select new HoaDonDTO
                                          {
                                              MaHD = h.maHD,
                                              TenNV = nv.ten,
                                              MaBan = h.maBan,
                                              NgayLap = h.ngayLap,
                                              PhuThu = h.phuThu,
                                              GiamGia = h.giamGia,
                                              TongTien = h.tongTien
                                          }).ToList();
                return result;
                
            }
            catch
            {
                return null;
            }
        }

        public bool ThemHoaDon(HoaDon hd)
        {
            try
            {
                db.HoaDons.InsertOnSubmit(hd);
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
