using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyQuanCafe.DAO;

namespace QuanLyQuanCafe.BUS
{
    public class LoaiThucPhamBUS
    {
        private LoaiThucPhamDAO typeFood = new LoaiThucPhamDAO();

        public List<LoaiThucPham> HienThiDanhSachLoaiThucPham()
        {
            return typeFood.HienThiDanhSachLoaiThucPham();
        }

        public bool Them(LoaiThucPham x)
        {
            return typeFood.Them(x);
        }

        public bool Xoa(int id)
        {
            return typeFood.Xoa(id);
        }

        public bool Sua(LoaiThucPham x)
        {
            return typeFood.Sua(x);
        }
    }
}
