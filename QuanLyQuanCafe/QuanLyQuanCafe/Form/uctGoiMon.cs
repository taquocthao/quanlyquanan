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

namespace QuanLyQuanCafe.Form
{
    public partial class uctGoiMon : UserControl
    {

        public static uctGoiMon uct = new uctGoiMon();
        private ThucPhamBUS thucpham = new ThucPhamBUS();
        private KhuVucBUS khuvuc = new KhuVucBUS();
        private BanBUS ban = new BanBUS();
        private ChiTietHoaDonBUS chiTietHD = new ChiTietHoaDonBUS();
        private int maTP = 0;
        private int soluong = 1;
        private decimal donGia = 0;

        public static int getNumber = 1;


        public uctGoiMon()
        {
            InitializeComponent();
            init();

        }

        private void init()
        {
             
            HienThiDanhSachThucDon(); 
           // HienThiDanhSachThucDonTheoLoai(Convert.ToInt32(cmbLoaiThucPham.SelectedValue));
            HienThiDanhSachLoaiThucPham();
                       
            DanhSachKhuVuc();
            DanhSachBanTheoKhuVuc(Convert.ToInt32(cmbKhuVuc.SelectedValue));

            int id = Convert.ToInt32(cmbBan.SelectedValue);
            if (cmbBan.SelectedValue != null)
            {
                HienThiChiTietHoaDonTheoBan(id);
            }
           // TimKiem(txtTimKiem.Text);

            // tạo chức năng placeholder trên text box
            txtTimKiem.Leave += new EventHandler(this.txtTimKiem_Leave);
            txtTimKiem.Enter += new EventHandler(this.txtTimKiem_Enter);
        }

        #region sự kiện tìm kiếm thực đơn
        /*
         * start
         */
        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm")
            {
                txtTimKiem.Text = "";
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Tìm kiếm";
                int id = (int)cmbLoaiThucPham.SelectedValue;
                HienThiDanhSachThucDonTheoLoai(id);
            }
        }

        private void TimKiem(string item)
        {
            flpDanhSachThucDon.Controls.Clear();
            List<ThucPham> listThucPham = thucpham.TimKiem(item);
            foreach (ThucPham tp in listThucPham)
            {
                uctThongTinThucPham uctInfo = new uctThongTinThucPham();
                uctInfo.getButton().Text = tp.tenTP + Environment.NewLine + tp.donGia;
                uctInfo.getButton().Tag = tp;
                uctInfo.getButton().Click += new EventHandler(btn_Click);
                flpDanhSachThucDon.Controls.Add(uctInfo);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            TimKiem(txtTimKiem.Text);
        }

        /*
         * end 
         */
        #endregion

        #region Hiển thị danh sách thực đơn
        /*
         * 
         */
        // Hiển thị tất cả danh sách thực phẩm
        private void HienThiDanhSachThucDon()
        {
            flpDanhSachThucDon.Controls.Clear();
            List<ThucPham> listThucPham = thucpham.HienThiDanhSachThucPham();
            foreach (ThucPham tp in listThucPham)
            {
                uctThongTinThucPham uctInfo = new uctThongTinThucPham();
                uctInfo.getButton().Text = tp.tenTP + Environment.NewLine + tp.donGia;
                uctInfo.getButton().Tag = tp;


                soluong = (int)uctInfo.getNumericUpDown().Value;


                uctInfo.getButton().Click += new EventHandler(btn_Click);              
                flpDanhSachThucDon.Controls.Add(uctInfo);
            }
        }

        //Hiển thị danh sách thực phẩm theo loai

        private void HienThiDanhSachThucDonTheoLoai(int id)
        {
            flpDanhSachThucDon.Controls.Clear();
            List<ThucPham> listThucPham = thucpham.HienThiDanhSachThucPhamTheoLoai(id);
            foreach (ThucPham tp in listThucPham)
            {
                uctThongTinThucPham uctInfo = new uctThongTinThucPham();
                uctInfo.getButton().Text = tp.tenTP + Environment.NewLine + tp.donGia;
                uctInfo.getButton().Tag = tp;

                uctInfo.getNumericUpDown().ValueChanged += NumericUpDown_ValueChanged;



                uctInfo.getButton().Click += new EventHandler(btn_Click);
                flpDanhSachThucDon.Controls.Add(uctInfo);
            }
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            soluong = (int)(sender as NumericUpDown).Value;
        }
        /*
         * 
         */
        #endregion

        #region Hiển thị dữ liệu lên combobox
        /*
         * start event, function 
        */
        private void HienThiDanhSachLoaiThucPham()
        {
            cmbLoaiThucPham.DataSource = thucpham.HienThiDanhSachLoaiThucPham();
            cmbLoaiThucPham.DisplayMember = "tenLoaiTP";
            cmbLoaiThucPham.ValueMember = "maLoaiTp";
        }

        private void DanhSachKhuVuc()
        {
            cmbKhuVuc.DataSource = khuvuc.HienThiDanhSachKhuVuc();
            cmbKhuVuc.DisplayMember = "tenKhuVuc";
            cmbKhuVuc.ValueMember = "maKhuVuc";
        }

        private void DanhSachBanTheoKhuVuc(int id)
        {
            cmbBan.Controls.Clear();
            cmbBan.DataSource = ban.HienThiDanhSachBanTheoKhuVuc(id);
            cmbBan.DisplayMember = "tenBan";
            cmbBan.ValueMember = "maBan";
        }

        private void cmbLoaiThucPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (cmbLoaiThucPham.SelectedItem as LoaiThucPham).maLoaiTP;
            HienThiDanhSachThucDonTheoLoai(id);
        }

        private void cmbKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maKhuVuc = (cmbKhuVuc.SelectedItem as KhuVuc).maKhuVuc;
            DanhSachBanTheoKhuVuc(maKhuVuc);
        }

        private void cmbBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (cmbBan.SelectedItem as Ban).maBan;
            HienThiChiTietHoaDonTheoBan(id);
        }
        /*
         * end event
        */
        #endregion

        //private void cmbSoLuong_Click(object sender, EventArgs e)
        //{
        //    //int id = ((sender as DevExpress.XtraEditors.ComboBoxEdit).Tag as ThucPham).maTP;
        //    soluong = Convert.ToInt32((sender as DevExpress.XtraEditors.ComboBoxEdit).SelectedText);
        //}

        // sự kiện click chuột vào một thực đơn
        private void btn_Click(object sender, EventArgs e)
        {
            int id = ((sender as Button).Tag as ThucPham).maTP;
            donGia = (decimal)((sender as Button).Tag as ThucPham).donGia;
            maTP = id;
        }

        public delegate void CapNhatBan(int idBan);
        public event CapNhatBan capNhatBan;
        

        private bool ThemMonAn()
        {
            ChiTietHoaDon cthd = new ChiTietHoaDon();
            //cthd.maCTHD = "Tự tăng";
            cthd.maBan = (cmbBan.SelectedItem as Ban).maBan;
            cthd.maTP = maTP;
            cthd.soLuong = soluong;
            cthd.donGia = donGia;
            if (chiTietHD.KiemTraThucDonDaDuocGoi(cthd.maBan, cthd.maTP))
            {
                CustomsMessageBox customMessage = new CustomsMessageBox();
                customMessage.ShowDialog();
                //label3.Text = ""+getNumber;
                return chiTietHD.ThemSoLuongThucDon(cthd.maTP, getNumber);              
            }
            else
            {
                
                return chiTietHD.ThemChiTietHoaDon(cthd);
            }
        }

        //Hiển thị danh sách các món đã chọn trong bàn

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

            dataGridView1.DataSource = result;

        }

        
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            bool success = ThemMonAn();
            int id = (cmbBan.SelectedItem as Ban).maBan;
            if (success)
            {
                if (capNhatBan != null)
                {
                    capNhatBan(id);
                }
            }           
            HienThiChiTietHoaDonTheoBan(id);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int idBan = (cmbBan.SelectedItem as Ban).maBan;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string tenThucPham = dataGridView1.SelectedCells[0].OwningRow.Cells["tenTP"].Value.ToString();
                bool success = chiTietHD.XoaChiTietHoaDon(idBan, tenThucPham);
                if (success)
                {
                    if (capNhatBan != null)
                    {
                        capNhatBan(idBan);
                    }
                } 
            }         
            HienThiChiTietHoaDonTheoBan(idBan);
        }




        
        

    }
}
