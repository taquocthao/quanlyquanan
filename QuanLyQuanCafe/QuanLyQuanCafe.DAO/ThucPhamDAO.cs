using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyQuanCafe.DAO
{
    public partial class ThucPhamDAO
    {
        private QuanLyQuanCafeDataContext db = new QuanLyQuanCafeDataContext();

        public List<ThucPham> HienThiDanhSachThucPham()
        {
            return db.ThucPhams.ToList();
        }

        public List<ThucPham> HienThiDanhSachThucPhamTheoLoai(int id)
        {
            var list = (from x in db.ThucPhams
                        where x.maLoaiTP == id
                        select x).ToList();
            return list;
        }

        public ThucPham HienThiThongTinThucPham(int id)
        {
           return db.ThucPhams.Single(x => x.maTP == id);
        }

        public bool ThemThucPham(ThucPham x)
        {
            try
            {
                db.ThucPhams.InsertOnSubmit(x);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaThucPham(int id)
        {
            try
            {
                ThucPham food = db.ThucPhams.Single(x => x.maTP == id);
                db.ThucPhams.DeleteOnSubmit(food);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaThucPham(ThucPham t)
        {
            try
            {
                ThucPham food = db.ThucPhams.Single(x => x.maTP == t.maTP);
                food.maLoaiTP = t.maLoaiTP;
                food.tenTP = t.tenTP;     
                food.dvt = t.dvt;
                food.donGia = t.donGia;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<ThucPham> TimKiem(string item)
        {
            try
            {
                var result = (from tp in db.ThucPhams
                             where tp.tenTP.StartsWith(item)
                              select tp).ToList() ;
                return result;
            }
            catch
            {
                return null;
            }
        }
        
    }
}
