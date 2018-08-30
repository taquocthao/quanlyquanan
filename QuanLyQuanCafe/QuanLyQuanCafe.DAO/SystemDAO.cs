using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyQuanCafe.DAO
{
    public class SystemDAO
    {
        private QuanLyQuanCafeDataContext db = new QuanLyQuanCafeDataContext();
        private KhuVucDAO kv = new KhuVucDAO();
        private BanDAO ban = new BanDAO();

        public List<KhuVuc> HienThiDanhSachKhuVuc()
        {
            return kv.HienThiDanhSachKhuVuc();
        }

        public List<Ban> HienThiDanhSachBanTheoKhuVuc(int id)
        {
            return ban.HienThiDanhSachBanTheoKhuVuc(id);
        }

        public List<Ban> HienThiTatCaDanhSachBan()
        {
            return ban.HienThiTatCaDanhSachBan();
        }
    }
}
