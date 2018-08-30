using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using QuanLyQuanCafe.BUS;
using QuanLyQuanCafe.DAO;
using System.Globalization;

namespace QuanLyQuanCafe.Form
{
    public partial class uctHeThong : UserControl
    {
        public static uctHeThong uct = new uctHeThong();
        private Systems sys = new Systems();
        private BanBUS ban = new BanBUS();
        private HoaDonBUS hoadon = new HoaDonBUS();
        public static int idBan = 0;

        public delegate void SendMessage(string sms);
        public event SendMessage send;

        public uctHeThong()
        {
            InitializeComponent();
            init();
            ReloadForm();
        }

        public void init()
        {
            HienThiDanhSachKhuVuc();
            if (cbKhuVuc.SelectedItem != null)
            {
                int id = (cbKhuVuc.SelectedItem as KhuVuc).maKhuVuc;
                HienThiDanhSachBanTheoKhuVuc(id);
            }

        }

        public void ReloadForm()
        {
            uctGoiMon.uct.capNhatBan += uct_capNhatBan;
        }

        private void uct_capNhatBan(int idBan)
        {
            ban.CapNhatTrangThaiBan(idBan);           
            int idKV = (cbKhuVuc.SelectedItem as KhuVuc).maKhuVuc;
            HienThiDanhSachBanTheoKhuVuc(idKV);
            HienThiChiTietHoaDonTheoBan(idBan);
        }


        #region Hàm, giao diện
        //
        public void HienThiDanhSachKhuVuc()
        {
            cbKhuVuc.DataSource = sys.HienThiDanhSachKhuVuc();
            if (cbKhuVuc.DataSource != null)
            {
                cbKhuVuc.DisplayMember = "tenKhuVuc";
                cbKhuVuc.ValueMember = "maKhuVuc";
            }         
        }


        public void HienThiDanhSachBanTheoKhuVuc(int id)
        {
            flpDanhSachBan.Controls.Clear();
            List<Ban> listTable = ban.HienThiDanhSachBanTheoKhuVuc(id);
            if (listTable.Count != 0)
            {
                foreach (Ban table in listTable)
                {
                    Button btn = new Button() { Width = 100, Height = 100 };
                    btn.Text = table.tenBan + Environment.NewLine + table.trangThai;
                    btn.Click += btn_Click;
                    //btn.MouseDoubleClick += btn_MouseDoubleClick;
                    btn.Tag = table;
                    if (table.trangThai == "Trống")
                    {
                        btn.BackColor = Color.Green;
                    }
                    else
                    {
                        btn.BackColor = Color.Pink;
                    }                   
                    flpDanhSachBan.Controls.Add(btn);
                }
            }
            else // nếu khu vực chưa có danh sách bàn
            {   // textbox hiển thị bàn sex rỗng

                txtMaBan.Text = "";
            }
           
        }

        private void btn_Click(object sender, EventArgs e)
        {
            idBan = ((sender as Button).Tag as Ban).maBan;
            HienThiThongTinBan(idBan);
            HienThiChiTietHoaDonTheoBan(idBan);
            //string sms = "called";
            //if (send != null)
            //{
            //    send(sms);
            //} 

        }


        private void HienThiChiTietHoaDonTheoBan(int id)
        {          
            QuanLyQuanCafeDataContext db = new QuanLyQuanCafeDataContext();
            var result = (from c in db.ChiTietHoaDons
                          join t in db.ThucPhams on c.maTP equals t.maTP
                          where c.maBan == id
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
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTongTien.Text = total.ToString("c", culture);
        }

        public void HienThiThongTinBan(int idTable)
        {
            Ban x = new Ban();
            x = ban.HienThiThongTinBan(idTable);
            txtMaBan.Text = x.tenBan;
        }

        //
        #endregion



        private void btnChuyenBan_Click(object sender, EventArgs e)
        {

        }


        private void cbKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (cbKhuVuc.SelectedItem as KhuVuc).maKhuVuc;
            HienThiDanhSachBanTheoKhuVuc(id);           
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {         
            if (ban.LayTrangThaiBan(idBan) == true)
            {
                frmThanhToanHoaDon frmHD = new frmThanhToanHoaDon();
                frmHD.InHoaDon_Click += frmHD_InHoaDon_Click;
                frmHD.ShowDialog();
            }            
        }

        private void frmHD_InHoaDon_Click(object sender, EventArgs e)
        {
            uct_capNhatBan(idBan);
        }

    }
}
