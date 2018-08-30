using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
namespace QuanLyQuanCafe.BUS
{

    public class HoaDonBUS
    {
        private HoaDonDAO hoadon = new HoaDonDAO();

        public List<HoaDonDTO> HienThiDanhSachHoaDon(DateTime startdate, DateTime enddate)
        {
            return hoadon.HienThiDanhSachHoaDon(startdate, enddate);
        }
        public bool ThemHoaDon(HoaDon hd)
        {
            return hoadon.ThemHoaDon(hd);
        }
    }

}
