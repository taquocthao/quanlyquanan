using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyQuanCafe.DTO
{
    public class HoaDonDTO
    {
        public int MaHD { get; set; }
        public string TenNV { get; set; }
        public int MaBan { get; set; }
        public DateTime? NgayLap { get; set; }
        public decimal? PhuThu { get; set; }
        public string GiamGia { get; set; }
        public decimal? TongTien { get; set; }

        public HoaDonDTO()
        {
            this.MaBan = 0;
            this.TenNV = null;
            this.MaHD = 0;
            this.NgayLap = null;
            this.PhuThu = 0;
            this.GiamGia = null;
            this.TongTien = 0;
        }

        public HoaDonDTO(int mahd, string ten, int maban, DateTime ngaylam, decimal phuthu, string giamgia, decimal tongtien)
        {
            this.MaHD = mahd;
            this.MaBan = maban;
            this.TenNV = ten;
           
            this.NgayLap = ngaylam;
            this.PhuThu = phuthu;
            this.GiamGia = giamgia;
            this.TongTien = tongtien;
        }
    }
}
