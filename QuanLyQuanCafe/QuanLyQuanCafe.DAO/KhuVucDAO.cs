using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyQuanCafe.DAO
{
    public class KhuVucDAO
    {
        private QuanLyQuanCafeDataContext db = new QuanLyQuanCafeDataContext();

        public List<KhuVuc> HienThiDanhSachKhuVuc()
        {
            return db.KhuVucs.ToList();
            
        }

        public bool ThemKhuVuc(KhuVuc kv)
        {
            try
            {
                db.KhuVucs.InsertOnSubmit(kv);
                db.SubmitChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool XoaKhuVuc(int id)
        {
            try
            {
                //var listTableInArea = (from table in db.Bans
                //                       where table.maKhuVuc == id
                //                       select table).ToList();
   
                //BanDAO b = new BanDAO();
                //foreach (Ban x in listTableInArea)
                //{
                //    b.XoaBan(x.maKhuVuc);
                //}

                KhuVuc kv = db.KhuVucs.Single(x => x.maKhuVuc == id);
                db.KhuVucs.DeleteOnSubmit(kv);              
                db.SubmitChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool SuaKhuVuc(KhuVuc k)
        {
            try
            {
                KhuVuc kv = db.KhuVucs.Single(x => x.maKhuVuc == k.maKhuVuc);
                kv.maKhuVuc = k.maKhuVuc;
                kv.tenKhuVuc = k.tenKhuVuc;
                kv.trangThai = k.trangThai;
                kv.soLuongBan = k.soLuongBan;
                //db.KhuVucs.InsertOnSubmit(kv);
                db.SubmitChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
