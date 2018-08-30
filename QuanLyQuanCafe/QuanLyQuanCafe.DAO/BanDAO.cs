using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyQuanCafe.DAO
{
    public class BanDAO
    {
        private QuanLyQuanCafeDataContext db = new QuanLyQuanCafeDataContext();

        public List<KhuVuc> HienThiDanhSachKhuVuc()
        {
            return db.KhuVucs.ToList();
        }

        public List<Ban> HienThiDanhSachBanTheoKhuVuc(int id)
        {
            try
            {
                var list = (from b in db.Bans
                            where b.maKhuVuc == id
                            select b).ToList();

                return list;
            }
            catch
            {
                return null;
            }
            
        }

        public List<Ban> HienThiTatCaDanhSachBan()
        {
            return db.Bans.ToList();
        }


        public Ban HienThiThongTinBan(int id)
        {

            return db.Bans.Single(x => x.maBan == id);
        }

        public bool CapNhatTrangThaiBan(int idBan)
        {
            try
            {
                Ban ban = db.Bans.Single(x => x.maBan == idBan);
                var listCTHD = db.ChiTietHoaDons.ToList();
                if (listCTHD.Count == 0)
                {
                    ban.trangThai = "Trống";
                }
                else
                {
                    foreach (var item in listCTHD)
                    {
                        if (item.maBan == idBan)
                        {
                            ban.trangThai = "Có người";
                        }
                        else
                            ban.trangThai = "Trống";
                    }
                }                              
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool LayTrangThaiBan(int idTable)
        {
            try
            {
                Ban ban = db.Bans.Single(x => x.maBan == idTable);
                return (ban.trangThai != "Trống");
            }
            catch
            {
                return false;
            }
        }


        public bool ThemBan(Ban ban)
        {
            try
            {
                db.Bans.InsertOnSubmit(ban);
                db.SubmitChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool XoaBan(int id)
        {
            try
            {
                Ban b = db.Bans.Single(x => x.maBan == id);
                db.Bans.DeleteOnSubmit(b);
                db.SubmitChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool SuaBan(Ban ban)
        {
            try
            {              
                Ban b = db.Bans.Single(x => x.maBan == ban.maBan);
                b.tenBan = ban.tenBan;
                b.trangThai = ban.trangThai;
                b.maKhuVuc = ban.maKhuVuc;
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
