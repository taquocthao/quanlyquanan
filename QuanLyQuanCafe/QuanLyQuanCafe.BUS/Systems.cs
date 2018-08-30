using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyQuanCafe.DAO;

namespace QuanLyQuanCafe.BUS
{
    public class Systems
    {
        private SystemDAO sys = new SystemDAO();

        public List<KhuVuc> HienThiDanhSachKhuVuc()
        {
            return sys.HienThiDanhSachKhuVuc();
        }

        public List<Ban> HienThiDanhSachBanTheoKhuVuc(int id)
        {
            return sys.HienThiDanhSachBanTheoKhuVuc(id);
        }

        public List<Ban> HienThiTatCaDanhSachBan()
        {
            return sys.HienThiTatCaDanhSachBan();
        }
    }
}
