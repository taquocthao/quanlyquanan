using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyQuanCafe.DAO;

namespace QuanLyQuanCafe.BUS
{
    public class ThucPhamBUS
    {
        private ThucPhamDAO tp = new ThucPhamDAO();
        private LoaiThucPhamDAO type = new LoaiThucPhamDAO();

        public List<ThucPham> HienThiDanhSachThucPham()
        {
            return tp.HienThiDanhSachThucPham();
        }

        public List<ThucPham> HienThiDanhSachThucPhamTheoLoai(int id)
        {
            return tp.HienThiDanhSachThucPhamTheoLoai(id);
        }

        public List<LoaiThucPham> HienThiDanhSachLoaiThucPham()
        {
            return type.HienThiDanhSachLoaiThucPham();
        }


        public ThucPham HienThiThongTinThucPham(int id)
        {
            return tp.HienThiThongTinThucPham(id);
        }

        public List<ThucPham> TimKiem(string item)
        {
            return tp.TimKiem(item);
        }


        public bool ThemThucPham(ThucPham x)
        {
            return tp.ThemThucPham(x);
        }

        public bool XoaThucPham(int id)
        {
            return tp.XoaThucPham(id);
        }

        public bool SuaThucPham(ThucPham x)
        {
            return tp.SuaThucPham(x);
        }
    }
}
