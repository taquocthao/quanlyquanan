using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyQuanCafe.DAO;

namespace QuanLyQuanCafe.BUS
{

    public class KhuVucBUS
    {
        KhuVucDAO kv = new KhuVucDAO();
        public List<KhuVuc> HienThiDanhSachKhuVuc()
        {
            return kv.HienThiDanhSachKhuVuc();
        }

        public bool XoaKhuVuc(int id)
        {
            return kv.XoaKhuVuc(id);
        }
        public bool ThemKhuVuc(KhuVuc k)
        {
            return kv.ThemKhuVuc(k);
        }
        public bool SuaKhuVuc(KhuVuc k)
        {
            return kv.SuaKhuVuc(k);
        }
    }

}
