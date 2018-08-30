using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace QuanLyQuanCafe.BUS
{
    /*

    public class LoaiThucUongBUS
    {
        QuanLyQuanCafeDataContext db = new QuanLyQuanCafeDataContext();
        public List<LoaiThucUong> HienThiLoaiThucUong()
        {
            return db.LoaiThucUongs.ToList();
        }

        public bool XoaLoaiThucUong(string MNV)
        {
            LoaiThucUong nv = db.LoaiThucUongs.Single(x => x.maLoai == MNV);
            db.LoaiThucUongs.DeleteOnSubmit(nv);
            db.SubmitChanges();
            return true;
        }
        public bool ThemLoaiThucUong(LoaiThucUong nv)
        {
            db.LoaiThucUongs.InsertOnSubmit(nv);
            db.SubmitChanges();
            return true;
        }
        public bool CapNhatLoaiThucUong(LoaiThucUong nv)
        {
            XoaLoaiThucUong(nv.maLoai);
            ThemLoaiThucUong(nv);
            return true;
        }
    }
    */
}
