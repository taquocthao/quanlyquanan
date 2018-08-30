using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.BUS;
using System.Globalization;

namespace QuanLyQuanCafe.Form
{
    public partial class frmThanhToanHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public static frmThanhToanHoaDon frmHD = new frmThanhToanHoaDon();
        private HoaDonBUS hoadon = new HoaDonBUS();
        private NhanVienBUS nv = new NhanVienBUS();
        private ChiTietHoaDonBUS chitietHD = new ChiTietHoaDonBUS();
        private int idBan;
        private string tenNV;
        public decimal totalMoney;
        private string user = Properties.Settings.Default.username;
        private string pass = Properties.Settings.Default.password;
        private CultureInfo culture = new CultureInfo("vi-VN");
        public frmThanhToanHoaDon()
        {
            InitializeComponent(); 
            GetInfor();
            nudGiamGia.TextChanged +=nudGiamGia_TextChanged;
            totalMoney = decimal.Parse(txtTongTien.Text, NumberStyles.Currency, culture);
        }

       

        
        public void GetInfor()
        {
            idBan = uctHeThong.idBan;
            ChiTietHoaDonTheoBan(idBan);
            txtMaBan.Text = idBan.ToString();
            tenNV = nv.LayTenNhanVienTuTaiKhoan(user, pass);
            txtTenNV.Text = tenNV;
        }

        public void ChiTietHoaDonTheoBan(int idTable)
        {

            QuanLyQuanCafeDataContext db = new QuanLyQuanCafeDataContext();
            var result = (from c in db.ChiTietHoaDons
                          join t in db.ThucPhams on c.maTP equals t.maTP
                          where c.maBan == idTable
                          select new
                          {
                              TenTP = t.tenTP,
                              DonGia = t.donGia,
                              SoLuong = c.soLuong,
                              ThanhTien = (c.soLuong * c.donGia)
                          }).ToList();

            dgvDanhSachMonDaGoi.DataSource = result;
            decimal total = 0;
            foreach (var item in result)
            {
                total += (decimal)item.ThanhTien;
            }
           // CultureInfo culture = new CultureInfo("vi-VN");
            txtTongTien.Text = total.ToString("c", culture);
        }

        private bool LuuHoaDon()
        {
            HoaDon hd = new HoaDon();
            hd.maNhanVien = nv.LayMaNhanVienTuTaiKhoan(user, pass);
            hd.maBan =  Convert.ToInt32(txtMaBan.Text);
            hd.ngayLap = dtpNgayLap.Value;
            hd.checkout = true;
            
            NumberStyles styles = NumberStyles.Currency | NumberStyles.Any;
            totalMoney = Decimal.Parse(txtTongTien.Text, styles, culture);
            hd.tongTien = totalMoney;
            
            return hoadon.ThemHoaDon(hd);           
        }

        private bool XoaChiTietHoaDon(int idTable)
        {
            return chitietHD.XoaChiTietHoaDon(idTable);
        }

        public delegate void InHoaDon(object sender, EventArgs e);
        public event InHoaDon InHoaDon_Click;

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            bool success = LuuHoaDon();
            if (success == false)
            {
                MessageBox.Show("In hóa đơn thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (XoaChiTietHoaDon(idBan))
                {
                    if (InHoaDon_Click != null)
                    {
                        InHoaDon_Click(sender, e);
                    }
                }
                else
                    MessageBox.Show("In hóa đơn thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }         
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPhuThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }        
        }

        private void nudGiamGia_TextChanged(object sender, EventArgs e)
        {
            decimal total = TongTienKhiGiamGia(nudGiamGia.Value);
            txtTongTien.Text = total.ToString("c", culture);         
            
        }

        public decimal TongTienKhiGiamGia(decimal value)
        {
            try
            {
                return (totalMoney - ((value * totalMoney) / 100));
            }
            catch
            {
                return -1;
            }
        }

        private decimal TongTienKhiPhuThu(decimal value)
        {
            try
            {
                return (totalMoney + value);
            }
            catch
            {
                return -1;
            }
        }

        private void txtPhuThu_TextChanged(object sender, EventArgs e)
        {

            string sDummy = txtPhuThu.Text;
            try
            {
                if (!string.IsNullOrEmpty(sDummy))
                {
                    int iKeep = txtPhuThu.SelectionStart - 1;
                    for (int i = iKeep; i >= 0; i--)
                        if (txtPhuThu.Text[i] == ',')
                            iKeep -= 1;

                    sDummy = String.Format("{0:N0}", Convert.ToInt32(sDummy.Replace(",", "")));
                    for (int i = 0; i <= iKeep; i++)
                        if (sDummy[i] == ',')
                            iKeep += 1;

                    txtPhuThu.Text = sDummy;
                    txtPhuThu.SelectionStart = iKeep + 1;
                }
                else
                {
                    txtPhuThu.Text = "0";
                }
               

                decimal value = decimal.Parse(txtPhuThu.Text);
                decimal total = TongTienKhiPhuThu(value);
                txtTongTien.Text = total.ToString("c", culture);

            }
            catch
            {
                //errorhandling
            }


        }



    }
}