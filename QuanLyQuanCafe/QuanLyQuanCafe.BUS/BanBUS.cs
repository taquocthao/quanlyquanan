using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyQuanCafe.DAO;

namespace QuanLyQuanCafe.BUS
{
    public class BanBUS
    {

        private BanDAO ban = new BanDAO();


        public List<KhuVuc> HienThiDanhSachKhuVuc()
        {
            return ban.HienThiDanhSachKhuVuc();
        }

        public List<Ban> HienThiDanhSachBanTheoKhuVuc(int id)
        {
            return ban.HienThiDanhSachBanTheoKhuVuc(id);
        }

        public List<Ban> HienThiTatCaDanhSachBan()
        {
            return ban.HienThiTatCaDanhSachBan();
        }

        public Ban HienThiThongTinBan(int id)
        {
            return ban.HienThiThongTinBan(id);
        }

        public bool CapNhatTrangThaiBan(int idBan)
        {
            return ban.CapNhatTrangThaiBan(idBan);
        }

        public bool LayTrangThaiBan(int idTable)
        {
            return ban.LayTrangThaiBan(idTable);
        }

        public bool XoaBan(int id)
        {
            return ban.XoaBan(id);
        }
        public bool ThemBan(Ban b)
        {
            return ban.ThemBan(b);
        }
        public bool SuaBan(Ban b)
        {
            return ban.SuaBan(b);
        }

    }
}
